using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Borelli_TelecomandoTV
{
    public partial class Form1 : Form
    {
        private Telecomando t;
        int numPremuto = 0;
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando("SAMSUNG", "EU...", 1);
            label1.Text = $"STATO: {t.getStato()}";
            label2.Text = $"VOLUME: {t.getVolume()}";
            label3.Text = "";
            label4.Text = $"CANALE: {t.getCanale()}";
        }
        private void button1_Click(object sender, EventArgs e)//on/off
        {
            if (numPremuto % 2 == 0)
                t.Accendi();
            else
                t.Spegni();

            label1.Text = $"STATO: {t.getStato()}";

            numPremuto++;
        }
        private void button2_Click(object sender, EventArgs e)//vol++
        {
            t.AumentaVolume();
            label2.Text=$"VOLUME: {t.getVolume()}";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            t.DiminuisciVolume();
            label2.Text = $"VOLUME: {t.getVolume()}";
        }
        private void button4_Click(object sender, EventArgs e)//1
        {
            label3.Text += button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)//2
        {
            label3.Text += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)//3
        {
            label3.Text += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)//4
        {
            label3.Text += button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)//5
        {
            label3.Text += button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)//6
        {
            label3.Text += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)//7
        {
            label3.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)//8
        {
            label3.Text += button11.Text;
        }
        private void button12_Click(object sender, EventArgs e)//9
        {
            label3.Text += button12.Text;
        }
        private void button13_Click(object sender, EventArgs e)//0
        {
            label3.Text += button13.Text;
        }
        private void button14_Click(object sender, EventArgs e)//ok canale
        {
            if (int.Parse(label3.Text) < 999 && label3.Text != "")
                t.setCanale(int.Parse(label3.Text));
            else
                MessageBox.Show("Inserire valori validi");

            label3.Text = "";
            label4.Text = $"CANALE: {t.getCanale()}";
        }
        private void button15_Click(object sender, EventArgs e)//can --
        {
            if(int.Parse(label4.Text.Substring(7, label4.Text.Length-7)) -1>0)
                t.setCanale(int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) - 1 );

            label4.Text = $"CANALE: {t.getCanale()}";
        }
        private void button16_Click(object sender, EventArgs e)//can ++
        {
            if (int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) + 1 < 999)
                t.setCanale(int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) + 1);

            label4.Text = $"CANALE: {t.getCanale()}";
        }
    }
}
