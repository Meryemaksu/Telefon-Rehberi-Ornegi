using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telrehberi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                {
                if (textBox1.TextLength < 2)
                {
                    MessageBox.Show("İsminiz en az 2 harften oluşmalı");
                }
                else if (textBox2.TextLength < 2)
                {
                    MessageBox.Show("Soyadınız en az 2 haften oluşmalı");
                }
                else
                {
                    if (comboBox1.SelectedIndex < 0)
                    {
                        MessageBox.Show("lütfen bir renk seçiniz...");
                    }
                    else if (comboBox2.SelectedIndex < 0)
                    {
                        MessageBox.Show("lütfen bir renk seçiniz...");
                    }
                    else if (comboBox3.SelectedIndex < 0)
                    {
                        MessageBox.Show("lütfen bir renk seçiniz...");
                    }
                    else
                    {
                        StreamWriter yaz = File.AppendText("veriler.txt");
                        yaz.WriteLine(comboBox1.Text.Substring(0, 1) + (comboBox2.Text.Substring(0, 1)) + (comboBox3.Text.Substring(0, 1)) + "#" + textBox1.Text + "#" + textBox2.Text + "#" + maskedTextBox1.Text);


                        yaz.Close();
                    }
                }
                }

            //yaz.Flush();
            //yaz.FlushAsync();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                // listBox1.Items.Add(a+" "+b+" "+c);

                //listBox1.Items.Add(c);

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                
        }
    }
}
