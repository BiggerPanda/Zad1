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
        private Plecak plecak;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox4.Text = "Brak parametrów";
            }
            else
            {
                textBox4.Text = "";
                var amount = textBox1.Text;
                var weight = textBox2.Text;
                var value = textBox3.Text;


                plecak = new Plecak(int.Parse(amount), int.Parse(value), int.Parse(weight));
                var wholeBackpack = plecak.WriteAllItems();
                textBox4.Text += wholeBackpack;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (plecak == null)
            {
                textBox5.Text = "Nie wygenerowano plecaka";
            }
            else
            {
                textBox5.Text = "";
                plecak.GatherItems();
                var GatherBackpack =  plecak.WriteListBackpack();
                textBox5.Text += "Cała warotść :" + plecak.ValueCurrent.ToString() + System.Environment.NewLine;
                textBox5.Text += GatherBackpack;
            }
        }
    }
}
