using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace kyrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=autorepair;UserID=root;Password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    Console.WriteLine("Подключение к базе данных успешно!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка подключения к базе данных: {ex.Message}");
                }
            }

            // Остальной код, который вы хотите выполнить при загрузке формы
        }
    }
}