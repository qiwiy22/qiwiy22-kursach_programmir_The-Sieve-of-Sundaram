
namespace ogo
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterLogin = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRegisterPassword2
            // 
            this.textBoxRegisterPassword2.Location = new System.Drawing.Point(242, 138);
            this.textBoxRegisterPassword2.Name = "textBoxRegisterPassword2";
            this.textBoxRegisterPassword2.PasswordChar = '*';
            this.textBoxRegisterPassword2.Size = new System.Drawing.Size(97, 20);
            this.textBoxRegisterPassword2.TabIndex = 1;
            this.textBoxRegisterPassword2.UseSystemPasswordChar = true;
            this.textBoxRegisterPassword2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegisterPassword2_KeyPress);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(242, 112);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(97, 20);
            this.textBoxRegisterPassword.TabIndex = 2;
            this.textBoxRegisterPassword.UseSystemPasswordChar = true;
            this.textBoxRegisterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegisterPassword_KeyPress);
            // 
            // textBoxRegisterLogin
            // 
            this.textBoxRegisterLogin.Location = new System.Drawing.Point(242, 86);
            this.textBoxRegisterLogin.Name = "textBoxRegisterLogin";
            this.textBoxRegisterLogin.Size = new System.Drawing.Size(97, 20);
            this.textBoxRegisterLogin.TabIndex = 3;
            this.textBoxRegisterLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegisterLogin_KeyPress);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Повторение пороля:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя пользователя:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textBoxRegisterLogin);
            this.Controls.Add(this.textBoxRegisterPassword);
            this.Controls.Add(this.textBoxRegisterPassword2);
            this.Controls.Add(this.button1);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRegisterPassword2;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterLogin;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}