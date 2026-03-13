using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Globals.Transport = "Kurier";
            else if (checkBox2.Checked)
                Globals.Transport = "Odbior";
            else if (checkBox3.Checked)
                Globals.Transport = "Dron";
            else
                Globals.Transport = "";

            this.Close();
        }
    }
}
