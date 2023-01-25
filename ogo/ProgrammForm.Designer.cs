
namespace ogo
{
    partial class ProgrammForm
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
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.textBoxGeneration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScrenShotButton = new System.Windows.Forms.Button();
            this.ShowTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Location = new System.Drawing.Point(281, 147);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(131, 23);
            this.buttonGeneration.TabIndex = 0;
            this.buttonGeneration.Text = "Найти простые числа ";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // textBoxGeneration
            // 
            this.textBoxGeneration.Location = new System.Drawing.Point(300, 121);
            this.textBoxGeneration.Name = "textBoxGeneration";
            this.textBoxGeneration.Size = new System.Drawing.Size(96, 20);
            this.textBoxGeneration.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите число от 1 до 50";
            // 
            // ScrenShotButton
            // 
            this.ScrenShotButton.Location = new System.Drawing.Point(281, 186);
            this.ScrenShotButton.Name = "ScrenShotButton";
            this.ScrenShotButton.Size = new System.Drawing.Size(131, 23);
            this.ScrenShotButton.TabIndex = 6;
            this.ScrenShotButton.Text = "Сделать скриншот";
            this.ScrenShotButton.UseVisualStyleBackColor = true;
            this.ScrenShotButton.Click += new System.EventHandler(this.ScrenShotButton_Click);
            // 
            // ShowTextBox
            // 
            this.ShowTextBox.Location = new System.Drawing.Point(45, 121);
            this.ShowTextBox.Name = "ShowTextBox";
            this.ShowTextBox.Size = new System.Drawing.Size(131, 65);
            this.ShowTextBox.TabIndex = 7;
            this.ShowTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Найденые простые числа";
            // 
            // ProgrammForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowTextBox);
            this.Controls.Add(this.ScrenShotButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGeneration);
            this.Controls.Add(this.buttonGeneration);
            this.Name = "ProgrammForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.TextBox textBoxGeneration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScrenShotButton;
        private System.Windows.Forms.RichTextBox ShowTextBox;
        private System.Windows.Forms.Label label2;
    }
}