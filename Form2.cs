using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        //public event Action<string> ProduktWybrany;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Pizza");
            listBox1.Items.Add("Ramen");
            listBox1.Items.Add("Sushi");
            listBox1.Items.Add("Makaron");
            listBox1.Items.Add("FastFood");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem != null)
                {
                    Globals.ProduktWybrany = listBox1.SelectedItem.ToString();
                    this.Close();
                }
            }
        }
    }
}
