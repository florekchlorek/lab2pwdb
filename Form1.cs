namespace lab2
{
    public partial class Form1 : Form
    {
        private List<string> koszyk = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var okno = new Form2();
            okno.ShowDialog();

            if (!string.IsNullOrEmpty(Globals.ProduktWybrany))
            {
                koszyk.Add(Globals.ProduktWybrany);
                listViewKoszyk.Items.Add(Globals.ProduktWybrany);

                Globals.ProduktWybrany = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            var okno = new Form3();

            okno.Kwota = koszyk.Count * 10;

            if (okno.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Wybrano płatność: " + okno.WybranaPlatnosc);
            }
        }

        private void listViewKoszyk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
