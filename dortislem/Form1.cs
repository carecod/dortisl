using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dortislem
{
    public partial class Form1 : Form
    {string text = "";
       static   Random rnd = new Random();
         int birinci = rnd.Next(1, 20);
            int ikinci = rnd.Next(1, 20);
        int sonuc =0;
        public Form1()
        {
            InitializeComponent();
            textBox1.GotFocus += new EventHandler(textBox_GotFocus);
          
            

            label1.Text = Convert.ToString(birinci);
            label2.Text = "+";
            label3.Text = Convert.ToString(ikinci);
            sonuc = birinci + ikinci;
            

        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(birinci + ikinci);
            if (textBox1.Text==sonuc.ToString())
            {
                label4.Text = "Cevap.:" + label1.Text+" + "+label3.Text+"="+ sonuc.ToString() +  "\nDoğru bildin.....";
                int birinci = rnd.Next(1, 20);
                int ikinci = rnd.Next(1, 20);
                label1.Text = Convert.ToString(birinci);
                label2.Text = "+";
                label3.Text = Convert.ToString(ikinci);
                sonuc = birinci + ikinci;
                textBox1.Text="Peki Bu?";
                textBox1.BackColor = Color.FromArgb(rnd.Next(90, 155), rnd.Next(80,155), rnd.Next(0,255));


            }
            else
            {
                label4.Text = "Malesef Bilemedin";
            }
            
        }
    }
}
