using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogo
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
            textBoxLogin.MaxLength = 15;
            textBoxPassword.MaxLength = 20;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            RegisterForm RF = new RegisterForm();
            RF.ShowDialog();
        }
        private void buttonAutorisation_Click(object sender, EventArgs e)
        {
            if (userAuthSucceess())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private bool userAuthSucceess()
        {
            string pass = md5.hashPassword(textBoxPassword.Text);
            if (incorrectFiledsOnForm())
            {
                MessageBox.Show("Некорректно заполнены поля на форме", "Ошибка авторизации");
                return false;
            }
            if (hasUser() == true)
            {
                MessageBox.Show("Вы авторизировались", "Авторизация");

                return true;
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
                return false;
            }
        }
        private bool incorrectFiledsOnForm()
        {
            if (isUnCorrectField(textBoxLogin.Text) || isUnCorrectField(textBoxPassword.Text))
                return true;
            return false;

        }
        private bool isUnCorrectField(string field)
        {
            if (String.IsNullOrWhiteSpace(field))
                return true;
            return false;
        }
        private bool hasUser()
        {
            string pass = md5.hashPassword(textBoxPassword.Text);

            if (new Database("Data Source=dataBase.db;Version=3;").ValidUser(textBoxLogin.Text, pass) == true)
                return true;
            else return false;
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

    }

}
