using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculateprqacticaka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //+
            textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-
            textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //*
            textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*  /  */
            textBox3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        { 
            //topdesign
            this.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = Color.White;

            this.button1.Size = new System.Drawing.Size(44, 31);
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button1.Text = "✚";
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackColor = System.Drawing.Color.White;

            this.button2.Size = new System.Drawing.Size(44, 31);
            this.button2.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button2.Text = "-";
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.BackColor = System.Drawing.Color.White;

            this.button3.Size = new System.Drawing.Size(44, 31);
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button3.Text = "✘";
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.BackColor = System.Drawing.Color.White;

            this.button4.Size = new System.Drawing.Size(44, 31);
            this.button4.Font = new System.Drawing.Font("Segoe Print", 9.25F);           
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.BackColor = System.Drawing.Color.White;

            this.button5.Size = new System.Drawing.Size(104, 31);
            this.button5.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.BackColor = System.Drawing.Color.White;

            this.button6.Size = new System.Drawing.Size(104, 31);
            this.button6.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.BackColor = System.Drawing.Color.White;

            
            this.button7.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Text = "↻";
            
            


            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.ForeColor = System.Drawing.Color.LightGreen;

            this.button8.BackColor = Color.White;






        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.button8.BackColor = Color.White;

            this.label1.ForeColor = Color.Black;
            this.BackColor = Color.Gainsboro;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(56, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первое число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(222, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Второе число";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(399, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Результат";

            //label5
            this.label5.ForeColor = Color.DarkRed;

            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(47, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            //
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(129, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button3.Location = new System.Drawing.Point(445, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button4.Location = new System.Drawing.Point(360, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            //
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(77, 260);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Очистить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);

           this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Location = new System.Drawing.Point(445, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "закрыть";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);


        }
    }
}
