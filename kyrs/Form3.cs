using System;
using System.Windows.Forms;

namespace kyrs
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            btnLogout.Click += new EventHandler(btnLogout_Click_1); // Подписываемся на событие нажатия кнопки выхода
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
