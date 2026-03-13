using static System.Windows.Forms.DataFormats;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NewCena();
        }

        private void NewCena()
        {
            int cena = listViewKoszyk.Items.Count * 10;
            label1.Text = "Cena: " + cena + " zł";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var okno = new Form2();
            okno.ShowDialog();

            if (Globals.ProduktWybrany != "")
            {
                listViewKoszyk.Items.Add(Globals.ProduktWybrany);
                Globals.ProduktWybrany = "";
                NewCena();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var okno = new Form5();
            okno.ShowDialog();

            if (Globals.Transport != "")
            {
                MessageBox.Show("Wybrano transport: " + Globals.Transport);
            }
            else
            {
                MessageBox.Show("Transport nie został wybrany");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var okno = new Form3();
            okno.ShowDialog();

            if (Globals.WybranaPlatnosc != "")
            {
                MessageBox.Show("Zaplacone: " + Globals.WybranaPlatnosc);
                Globals.WybranaPlatnosc = "";
            }
        }

    }
}
