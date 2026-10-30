using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_minuto
{
    public partial class Form3_Consulta : Form
    {
        public List<string> titulos = new List<string>();
        public List<string> genero = new List<string>();
        public List<int> secao = new List<int>();
        public List<double> preco = new List<double>();
        public List<int> codigo = new List<int>();


        public Form3_Consulta()
        {
            InitializeComponent();
            titulos.Add("Cem Anos de Solidão,Gabriel García Márquez");
            titulos.Add("A Revolução dos Bichos,George Orwell");
            titulos.Add("Dom Quixote,Miguel de Cervantes");

            lb_Livros.DataSource = titulos;
            cb_titulo.DataSource = titulos;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_Livros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
