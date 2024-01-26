using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace kyrs
{
    public partial class ServicesForm : Form
    {

        string connectionString = "Server=localhost;Database=autorepair;UserID=root;Password=root;";

        public ServicesForm()
        {
            InitializeComponent();
            LoadServices();
        }


        private void ServicesForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadServices()
        {
            // Подключение к базе данных и получение информации о услугах

            listBoxServices.Items.Clear(); // Очистите список перед загрузкой обновленных данных

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Выполнение SQL-запроса для получения информации о услугах
                    string query = "SELECT * FROM Services";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    // Вывод информации на форму
                    while (reader.Read())
                    {
                        listBoxServices.Items.Add(reader["name"].ToString());
                        // Добавьте другие поля, если необходимо
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке информации о услугах: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listBoxServices.SelectedIndexChanged += new EventHandler(ListBoxServices_SelectedIndexChanged);
            }
        }
        private void ListBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Очистка предыдущей информации
            ClearServiceInfo();

            // Проверка, выбрана ли какая-то услуга
            if (listBoxServices.SelectedIndex != -1)
            {
                // Получение ID выбранной услуги
                int selectedServiceID = 0; // Инициализация переменной

                // Получение значения service_id из базы данных
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Выполнение SQL-запроса для получения информации о выбранной услуге
                        string query = $"SELECT service_id FROM Services WHERE name = '{listBoxServices.SelectedItem.ToString()}'";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        // Проверка, найдена ли услуга в базе данных
                        if (reader.Read())
                        {
                            selectedServiceID = Convert.ToInt32(reader["service_id"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении ID выбранной услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Получение информации о выбранной услуге
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Выполнение SQL-запроса для получения информации о выбранной услуге
                        string query = $"SELECT name, description, cost FROM Services WHERE service_id = {selectedServiceID}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        // Отображение информации о выбранной услуге
                        if (reader.Read())
                        {
                            lblServiceName.Text = reader["name"].ToString();
                            lblServiceDescription.Text = reader["description"].ToString();
                            lblServicePrice.Text = $"Цена: {reader["cost"].ToString()} руб.";
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении информации о выбранной услуге: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Метод для очистки информации о выбранной услуге
        private void ClearServiceInfo()
        {
            lblServiceName.Text = string.Empty;
            lblServiceDescription.Text = string.Empty;
            lblServicePrice.Text = string.Empty;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Services (name, description, cost) VALUES (@name, @description, @cost)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtNewServiceName.Text);
                    command.Parameters.AddWithValue("@description", txtNewServiceDescription.Text);
                    command.Parameters.AddWithValue("@cost", Convert.ToDecimal(txtNewServicePrice.Text));

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadServices(); // Обновить список после добавления
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedIndex != -1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE Services SET name = @name, description = @description, cost = @cost WHERE name = @selectedName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtNewServiceName.Text);
                        command.Parameters.AddWithValue("@description", txtNewServiceDescription.Text);
                        command.Parameters.AddWithValue("@cost", Convert.ToDecimal(txtNewServicePrice.Text));
                        command.Parameters.AddWithValue("@selectedName", listBoxServices.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadServices(); // Обновить список после обновления
            }
            else
            {
                MessageBox.Show("Выберите услугу для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedIndex != -1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM Services WHERE name = @selectedName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@selectedName", listBoxServices.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadServices(); // Обновить список после удаления
            }
            else
            {
                MessageBox.Show("Выберите услугу для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}