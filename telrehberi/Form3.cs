using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telrehberi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }
        static int sayac = 0;
        private void yaz(string kisi)
        {


            string[] str = kisi.Split('#');
            sayac++;
            string renk = str[0];
            string ad = str[1];
            string soyad = str[2];
            string telefon = str[3];
            string renk1 = renk.Substring(0, 1);
            string renk2 = renk.Substring(1, 1);
            string renk3 = renk.Substring(2, 1);
            if (sayac % 2 == 1)
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, richTextBox1.Font.Style ^ FontStyle.Bold);


                if (renk1 == "K")
                {
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectedText += ad + " ";
                }
                else if (renk1 == "Y")
                {
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.SelectedText += ad + " ";
                }
                else if (renk1 == "M")
                {
                    richTextBox1.SelectionColor = Color.Blue;
                    richTextBox1.SelectedText += ad + " ";
                }
            if (renk2 == "K")
            {
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectedText += soyad + " ";
            }
            else if (renk2 == "Y")
            {
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.SelectedText += soyad + " ";
            }
            else if (renk2 == "M")
            {
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectedText += soyad + " ";
            }
            if (renk3 == "K")
            {
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectedText += telefon + "\n";
            }
            else if (renk3 == "Y")
            {
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.SelectedText += telefon + "\n";
            }
            else if (renk3 == "M")
            {
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectedText += telefon + "\n";
            }



        }
        private void Form3_Load(object sender, EventArgs e)
        {
            /*StreamReader SR = new StreamReader("C:\\Users\\Hp\\Desktop\\a.txt");
             richTextBox1.Text = SR.ReadLine();
             SR.Close();
             StreamWriter SW = File.AppendText("C:\\Users\\Hp\\Desktop\\a.txt");
             SW.WriteLine(richTextBox1.Text);
             SW.Close();*/
            StreamReader dosya = File.OpenText("veriler.txt");//dosyayı açtık.

            string siradaki_satir = dosya.ReadLine();// 
                                                     //Form3.MessageBox("siradaki_satir");
                                                     //    int satir = 0;
            while (siradaki_satir != null)
            {
                //  string[] line = siradaki_satir.Split(' ');

                this.yaz(siradaki_satir);
                siradaki_satir = dosya.ReadLine();

            }

            dosya.Close();

        }

    }
}

