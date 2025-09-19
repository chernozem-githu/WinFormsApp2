using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxC = new TextBox();
            this.textBoxF = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.SuspendLayout();
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new Point(120, 30);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new Size(100, 23);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new Point(120, 70);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new Size(100, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 33);
            this.label1.Text = "Цельсий °C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(30, 73);
            this.label2.Text = "Фаренгейт °F";
            // 
            // button1
            // 
            this.button1.Location = new Point(250, 30);
            this.button1.Text = "В °F";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new Point(250, 70);
            this.button2.Text = "В °C";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new Size(400, 150);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Name = "Form2";
            this.Text = "Конвертер градусов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
