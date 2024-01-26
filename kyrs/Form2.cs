using System;
using System.Drawing;
using System.Windows.Forms;

namespace kyrs
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Проверка имени пользователя и пароля
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                // Если успешно, открываем форму администратора
                AdminForm adminForm = new AdminForm();
                adminForm.Show();

                // Скрываем форму авторизации
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные имя пользователя или пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
