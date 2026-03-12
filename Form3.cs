using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form3 : Form
    {
        public int Kwota { get; set; }
        public string WybranaPlatnosc { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        /*
   if (radioKarta.Checked)
       WybranaPlatnosc = "Karta";
   else if (radioBlik.Checked)
       WybranaPlatnosc = "BLIK";
   else
       WybranaPlatnosc = "Gotówka";

   this.DialogResult = DialogResult.OK;
   this.Close();*/
    }
}
