using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ogo
{
    public partial class ProgrammForm : Form
    {
        public ProgrammForm()
        {
            InitializeComponent();
            AutorisationForm AF = new AutorisationForm();
            AF.ShowDialog();
        }


        private void buttonGeneration_Click(object sender, EventArgs e) 
        {
            char[] chisla =  { '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            string znach = null;
            string textbox = this.textBoxGeneration.Text;
            int count = 0;
            for (int i = 0; i < textbox.Length; i++)
            {
                int count2 = 0;
                for (int j = 0; j < chisla.Length; j++)
                {
                    if (textbox[i] == chisla[j])
                    {
                        count2++;
                    }
                }
                if (count2 == 0) count++;
            }
            if (count == 0 && textBoxGeneration.Text != "")
            {
                int textBoxGeneration = Convert.ToInt32(this.textBoxGeneration.Text);
                Main Sundaram = new Main();
                if (textBoxGeneration > 0 && textBoxGeneration < 51)
                {
                    znach = Sundaram.Sundarammmm(textBoxGeneration);
                    ShowTextBox.Text = znach;
                }
                else
                {
                    MessageBox.Show("Введено неверное значение", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    this.textBoxGeneration.Clear();
                }
            }
            else
            {
                MessageBox.Show("Поле заполнено не верно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.textBoxGeneration.Clear();
            }
        }

        private void ScrenShotButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"С://";
            sfd.RestoreDirectory = true;
            sfd.FileName = "Скриншот результата работы программы";
            sfd.DefaultExt = "JPG";
            sfd.Filter = "Image Files(.BMP)|.BMP|Image Files(.JPG)|.JPG|Image Files(.GIF)|.GIF|Image Files(.PNG)|.PNG|All files (.)|.";
            Rectangle bounds = this.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics graph = Graphics.FromImage(bitmap))
                {
                    graph.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }
                if (sfd.ShowDialog() == DialogResult.OK)
                    bitmap.Save(sfd.FileName);
            }
        }
    }
}
