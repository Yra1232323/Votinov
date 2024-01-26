using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace kyrs
{
    public partial class ClientsForm : Form
    {
        private string connectionString = "Server=localhost;Database=autorepair;UserID=root;Password=root;";

        public ClientsForm()
        {
            InitializeComponent();
            LoadClients();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadClients()
        {

            listBoxClients.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM newcustomers";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listBoxClients.Items.Add(reader["name"].ToString());
                        // Добавьте другие поля, если необходимо
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке информации о клиентах: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBoxClients.SelectedIndexChanged += new EventHandler(ListBoxClients_SelectedIndexChanged);
            }
        }

        private void ListBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearClientInfo();

            if (listBoxClients.SelectedIndex != -1)
            {
                int selectedClientID = 0;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = $"SELECT customer_id FROM newcustomers WHERE name = '{listBoxClients.SelectedItem.ToString()}'";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            selectedClientID = Convert.ToInt32(reader["customer_id"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении ID выбранного клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = $"SELECT name, email, contact_number FROM newcustomers WHERE customer_id = {selectedClientID}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            lblClientName.Text = reader["name"].ToString();
                            lblClientEmail.Text = reader["email"].ToString();
                            lblClientPhone.Text = reader["contact_number"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении информации о выбранном клиенте: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearClientInfo()
        {
            lblClientName.Text = string.Empty;
            lblClientEmail.Text = string.Empty;
            lblClientPhone.Text = string.Empty;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewClientName.Text) && !string.IsNullOrEmpty(txtNewClientContact.Text) && !string.IsNullOrEmpty(txtNewClientEmail.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Проверяем, существует ли клиент с таким именем
                        string checkQuery = "SELECT COUNT(*) FROM newcustomers WHERE name = @name";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@name", txtNewClientName.Text);

                        int existingClients = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingClients == 0)
                        {
                            // Если клиента с таким именем нет, выполняем добавление
                            string insertQuery = "INSERT INTO newcustomers (name, contact_number, email) VALUES (@name, @contact_number, @email)";
                            MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@name", txtNewClientName.Text);
                            insertCommand.Parameters.AddWithValue("@contact_number", txtNewClientContact.Text);
                            insertCommand.Parameters.AddWithValue("@email", txtNewClientEmail.Text);

                            insertCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Клиент с таким именем уже существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadClients(); // Обновить список после добавления
            }
            else
            {
                MessageBox.Show("Заполните все поля для добавления клиента.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1 && !string.IsNullOrEmpty(txtNewClientName.Text) && !string.IsNullOrEmpty(txtNewClientContact.Text) && !string.IsNullOrEmpty(txtNewClientEmail.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Проверяем, существует ли клиент с таким именем, исключая выбранный клиент
                        string checkQuery = "SELECT COUNT(*) FROM newcustomers WHERE name = @name AND name != @selectedName";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@name", txtNewClientName.Text);
                        checkCommand.Parameters.AddWithValue("@selectedName", listBoxClients.SelectedItem.ToString());

                        int existingClients = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingClients == 0)
                        {
                            // Если клиента с таким именем (не считая выбранного) нет, выполняем обновление
                            string updateQuery = "UPDATE newcustomers SET name = @name, contact_number = @contact_number, email = @email WHERE name = @selectedName";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@name", txtNewClientName.Text);
                            updateCommand.Parameters.AddWithValue("@contact_number", txtNewClientContact.Text);
                            updateCommand.Parameters.AddWithValue("@email", txtNewClientEmail.Text);
                            updateCommand.Parameters.AddWithValue("@selectedName", listBoxClients.SelectedItem.ToString());

                            updateCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Клиент с таким именем уже существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadClients(); // Обновить список после обновления
            }
            else
            {
                MessageBox.Show("Выберите клиента и заполните все поля для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (listBoxClients.SelectedIndex != -1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Получаем имя выбранного клиента
                        string selectedClientName = listBoxClients.SelectedItem.ToString();

                        // Проверяем, существует ли клиент с таким именем
                        string checkQuery = "SELECT COUNT(*) FROM newcustomers WHERE name = @name";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@name", selectedClientName);

                        int existingClients = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingClients > 0)
                        {
                            // Если клиент с таким именем существует, выполняем удаление
                            string deleteQuery = "DELETE FROM newcustomers WHERE name = @name";
                            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@name", selectedClientName);

                            deleteCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Клиент с таким именем не существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении клиента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadClients(); // Обновить список после удаления
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNewClientContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}