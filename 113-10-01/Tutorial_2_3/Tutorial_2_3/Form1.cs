namespace Tutorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Buongiorno";
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Buenos Dias";
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "Guten Morgen";
        }
    }
}
