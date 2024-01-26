using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace kyrs
{
    public partial class EmployeesForm : Form
    {
        private string connectionString = "Server=localhost;Database=autorepair;UserID=root;Password=root;";

        public EmployeesForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {

            listBoxEmployees.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Employees";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listBoxEmployees.Items.Add(reader["name"].ToString());
                        // Добавьте другие поля, если необходимо
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке информации о сотрудниках: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                listBoxEmployees.SelectedIndexChanged += new EventHandler(ListBoxEmployees_SelectedIndexChanged);
            }
        }

        private void ListBoxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearEmployeeInfo();

            if (listBoxEmployees.SelectedIndex != -1)
            {
                int selectedEmployeeID = 0;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = $"SELECT employee_id FROM Employees WHERE name = '{listBoxEmployees.SelectedItem.ToString()}'";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            selectedEmployeeID = Convert.ToInt32(reader["employee_id"]);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении ID выбранного сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = $"SELECT name, position, salary FROM Employees WHERE employee_id = {selectedEmployeeID}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            lblEmployeeName.Text = reader["name"].ToString();
                            lblEmployeePosition.Text = reader["position"].ToString();
                            lblEmployeeSalary.Text = reader["salary"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при получении информации о выбранном сотруднике: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearEmployeeInfo()
        {
            lblEmployeeName.Text = string.Empty;
            lblEmployeePosition.Text = string.Empty;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNewEmployeeName.Text) && !string.IsNullOrEmpty(txtNewEmployeePosition.Text) && !string.IsNullOrEmpty(txtNewEmployeeSalary.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Employees (name, position, salary) VALUES (@name, @position, @salary)";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtNewEmployeeName.Text);
                        command.Parameters.AddWithValue("@position", txtNewEmployeePosition.Text);
                        command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtNewEmployeeSalary.Text));

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadEmployees(); // Обновить список после добавления
            }
            else
            {
                MessageBox.Show("Заполните все поля для добавления сотрудника.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex != -1 && !string.IsNullOrEmpty(txtNewEmployeeName.Text) && !string.IsNullOrEmpty(txtNewEmployeePosition.Text) && !string.IsNullOrEmpty(txtNewEmployeeSalary.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE Employees SET name = @name, position = @position, salary = @salary WHERE name = @selectedName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtNewEmployeeName.Text);
                        command.Parameters.AddWithValue("@position", txtNewEmployeePosition.Text);
                        command.Parameters.AddWithValue("@salary", Convert.ToDecimal(txtNewEmployeeSalary.Text));
                        command.Parameters.AddWithValue("@selectedName", listBoxEmployees.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при обновлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadEmployees(); // Обновить список после обновления
            }
            else
            {
                MessageBox.Show("Выберите сотрудника и заполните все поля для обновления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex != -1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM Employees WHERE name = @selectedName";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@selectedName", listBoxEmployees.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                LoadEmployees(); // Обновить список после удаления
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}