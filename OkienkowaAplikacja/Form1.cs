using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zad1;

namespace OkienkowaAplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            var amount = textBox1.Text;
            var weight = textBox2.Text;
            var value = textBox3.Text;
            

            Plecak plecak = new Plecak(int.Parse(amount), int.Parse(value), int.Parse(weight));
            var wholeBackpack = plecak.WriteAllItems();
            wholeBackpack.Split();
            textBox4.Text += wholeBackpack;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
