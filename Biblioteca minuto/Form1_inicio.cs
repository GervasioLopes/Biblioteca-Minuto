using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace Biblioteca_minuto
{
    public partial class Form1_inicio : Form
    {
        Thread t1;
        public Form1_inicio()
        {
            InitializeComponent();
            // Configure o intervalo do timer para 4000 milissegundos (4 segundos)
            timer1.Interval = 2000;
            // Ative o timer para começar a contagem
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Se o intervalo do timer atingir 0 (1 segundo passou)
            if (timer1.Interval <= 1000)
            {
                // Cria uma nova instância do segundo formulário
                this.Close();
                t1 = new Thread(abrirjanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();

                // Para o timer para evitar chamadas adicionais
                timer1.Stop();




            }
            else
            {
                // A cada tick do timer, subtrai 1000 milissegundos (1 segundo) do intervalo
                timer1.Interval -= 1000;
            }


        }

        private void abrirjanela(object obj)
        {
            Application.Run(new Form1_Home());

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
