using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing2
{
    public partial class Form1 : Form
    {
        double tax1=0, price1=0,tax2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            wramt();
            wtot();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            wtot();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tot.Text != "")
            {
                listBox1.Items.Add(comboBox1.Text + "\t" + price.Text + "\t" + qun.Text + "\t" + amt.Text + "\t" + comboBox2.Text + "\t" + tot.Text);
                tax1 += tax2;
                price1 += int.Parse(amt.Text);
            }
            tt.Text = tax1 + "";
            tp.Text = price1 + "";
            bill.Text = (tax1 + price1) + "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                price.Text = "50";
            else if (comboBox1.SelectedIndex == 1)
                price.Text = "150";
            else if (comboBox1.SelectedIndex == 2)
                price.Text = "250";
            else
                price.Text = "500";
            wramt();
            wtot();
            
        }

        public void wramt()
        {
            if (qun.Text != "" && price.Text != "")
                amt.Text = int.Parse(qun.Text) * int.Parse(price.Text) + "";
            else
                amt.Text = "";
        }

        public void wtot()
        {
            if (qun.Text != "" && price.Text != "" && comboBox2.Text != "")
            {
                double t;
                if (comboBox2.SelectedIndex == 0)
                    t = 7;
                else if (comboBox2.SelectedIndex == 1)
                    t = 6.5;
                else if (comboBox2.SelectedIndex == 2)
                    t = 6;
                else if (comboBox2.SelectedIndex == 3)
                    t = 5.5;
                else
                    t = 5;
                tax2 = int.Parse(amt.Text) * t / 100;
                tot.Text = (int.Parse(amt.Text) + tax2) + "";
            }
            else
                tot.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
        }
    }
}
