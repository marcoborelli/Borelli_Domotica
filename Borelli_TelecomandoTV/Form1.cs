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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.NumPad0)) 
                button13.PerformClick();
            else if (keyData == (Keys.NumPad1)) 
                button4.PerformClick();
            else if (keyData == (Keys.NumPad2))
                button5.PerformClick();
            else if (keyData == (Keys.NumPad3))
                button6.PerformClick();
            else if (keyData == (Keys.NumPad4))
                button7.PerformClick();
            else if (keyData == (Keys.NumPad5))
                button8.PerformClick();
            else if (keyData == (Keys.NumPad6))
                button9.PerformClick();
            else if (keyData == (Keys.NumPad7))
                button10.PerformClick();
            else if (keyData == (Keys.NumPad8))
                button11.PerformClick();
            else if (keyData == (Keys.NumPad9))
                button12.PerformClick();
            else if (keyData == (Keys.Enter))//enter
                button14.PerformClick();
            else if (keyData == (Keys.Oemplus)|| keyData == (Keys.Add))//aumenta volume
                button2.PerformClick();
            else if (keyData == (Keys.OemMinus) || keyData == (Keys.Subtract))//aumenta volume
                button3.PerformClick();
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public Form1()
        {
            InitializeComponent();
            t = new Telecomando("SAMSUNG", "EU...", 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"STATO: {t.getStato()}";
            label2.Text = $"VOLUME: {t.getVolume()}";
            label3.Text = "";
            label4.Text = $"CANALE: {t.getCanale()}";
            label1.Select();
            if (!t.getStato())
                button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = button13.Enabled = button14.Enabled = button15.Enabled = button16.Enabled = false;
            else
                button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = button13.Enabled = button14.Enabled = button15.Enabled = button16.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)//on/off
        {
            if (numPremuto % 2 == 0)
                t.Accendi();
            else
                t.Spegni();

            numPremuto++;

            Form1_Load(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)//vol++
        {
            t.AumentaVolume();
            Form1_Load(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)//vol--
        {
            t.DiminuisciVolume();
            Form1_Load(sender, e);
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

            Form1_Load(sender, e);
        }
        private void button15_Click(object sender, EventArgs e)//can --
        {
            if(int.Parse(label4.Text.Substring(7, label4.Text.Length-7)) -1>0)
                t.setCanale(int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) - 1 );

            Form1_Load(sender, e);
        }
        private void button16_Click(object sender, EventArgs e)//can ++
        {
            if (int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) + 1 < 999)
                t.setCanale(int.Parse(label4.Text.Substring(7, label4.Text.Length - 7)) + 1);

            Form1_Load(sender, e);
        }
    }
}
