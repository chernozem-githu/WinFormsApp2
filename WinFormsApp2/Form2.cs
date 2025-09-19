using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public class Form2 : Form
    {
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;

        public Form2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxC = new TextBox();
            this.textBoxF = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();

           
            this.textBoxC.Location = new Point(120, 30);
            this.textBoxC.Size = new Size(100, 23);

           
            this.textBoxF.Location = new Point(120, 70);
            this.textBoxF.Size = new Size(100, 23);


            this.label1.AutoSize = true;
            this.label1.Location = new Point(30, 33);
            this.label1.Text = "Цельсий °C";

            
            this.label2.AutoSize = true;
            this.label2.Location = new Point(30, 73);
            this.label2.Text = "Фаренгейт °F";

           
            this.button1.Location = new Point(250, 30);
            this.button1.Text = "В °F";
            this.button1.Click += new EventHandler(this.button1_Click);

           
            this.button2.Location = new Point(250, 70);
            this.button2.Text = "В °C";
            this.button2.Click += new EventHandler(this.button2_Click);

            
            this.ClientSize = new Size(400, 150);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Text = "Конвертер градусов";
        }

        // °C → °F
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxC.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                textBoxF.Text = fahrenheit.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Введите число в поле °C!");
            }
        }

        // °F → °C
        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxF.Text, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBoxC.Text = celsius.ToString("0.##");
            }
            else
            {
                MessageBox.Show("Введите число в поле °F!");
            }
        }
    }
}
