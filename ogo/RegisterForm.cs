using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;
namespace ogo
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            textBoxRegisterLogin.MaxLength = 15;
            textBoxRegisterPassword.MaxLength = 20;
            textBoxRegisterPassword2.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textBoxRegisterPassword2 = this.textBoxRegisterPassword2.Text;
            var textBoxRegisterPassword = this.textBoxRegisterPassword.Text;
            var textBoxRegisterLogin = this.textBoxRegisterLogin.Text;

            SQLiteConnection connection = new SQLiteConnection("Data Source=dataBase.db");
            connection.Open();

            SQLiteCommand command = connection.CreateCommand();
            command.Connection = connection;

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable table = new DataTable();

            command.CommandText = "SELECT * FROM 'users' WHERE login = @login";
            command.Parameters.Add("@login", DbType.String).Value = textBoxRegisterLogin;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (textBoxRegisterPassword2 != textBoxRegisterPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }else if (textBoxRegisterPassword == "" || textBoxRegisterPassword2 == "" || textBoxRegisterLogin == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            { 
                string pass = md5.hashPassword(textBoxRegisterPassword);
                new Database("Data Source=dataBase.db;Version=3;").createUser(this.textBoxRegisterLogin.Text, pass);
                MessageBox.Show("Вы зарегестрированы", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            connection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxRegisterLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void textBoxRegisterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }

        private void textBoxRegisterPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char S = e.KeyChar;

            if (!Char.IsLetterOrDigit(S) && S != 8)
                e.Handled = true;
        }
    }
}
