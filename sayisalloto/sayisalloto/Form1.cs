using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd1 = new Random();

            int s1, s2, s3, s4;

            s1 = rnd1.Next(1, 9);//ilk dahil ikinci değil

            s2 = rnd1.Next(1, 9);

            s3 = rnd1.Next(1, 9);

            s4 = rnd1.Next(1, 9);


            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();


            //sayi1
            if (label1.Text == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            //sayi2
            if (label2.Text == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            //sayi3
            if (label3.Text == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            //sayi4
            if (label4.Text == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if(label4.Text == textBox4.Text && label3.Text == textBox3.Text && label2.Text == textBox2.Text && label1.Text == textBox1.Text)
            {
                MessageBox.Show("Tebrikler Kazandınız");
                this.Hide();
            }


        }
    }
}
