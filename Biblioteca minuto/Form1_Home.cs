namespace Biblioteca_minuto
{
    public partial class Form1_Home : Form
    {
        public Form1_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cONFIGURAÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Livrosjnl jn2 = new Livrosjnl();
            jn2.Show();

        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3_Consulta jn3 = new Form3_Consulta();
            jn3.Show();
        }
    }
}