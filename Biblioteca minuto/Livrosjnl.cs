using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Biblioteca_minuto
{
    public partial class Livrosjnl : Form
    {
        public Livrosjnl()
        {
            InitializeComponent();
        }

        private void limpar()
        {

            tb_id.Clear();
            tb_titulo.Clear();
            tb_autor.Clear();
            tb_genero.Clear();
            tb_secao.Clear();
            tb_preco.Clear();
            tb_quantidade.Clear();
            tb_situacao.Clear();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (tb_id.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("ID não pode ser vazio");
                tb_id.Focus();
                return;
            }
            if (tb_titulo.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Titulo não pode ser vazio");
                tb_id.Focus();
                return;
            }
            if (tb_autor.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Autor não pode ser vazio");
                tb_id.Focus();
                return;
            }

            if (tb_genero.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Gênero não pode ser vazio");
                tb_id.Focus();
                return;
            }


            if (tb_secao.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Seção não pode ser vazia");
                tb_id.Focus();
                return;
            }

            if (tb_preco.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Preço não pode ser vazio");
                tb_id.Focus();
                return;
            }

            if (tb_quantidade.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Quantidade não pode ser vazia");
                tb_id.Focus();
                return;
            }

            if (tb_situacao.Text == "")  //programando mensagens de erro 
            {
                MessageBox.Show("Situacão não pode ser vazia");
                tb_id.Focus();
                return;
            }






            string[] pr = new string[8];
            pr[0] = tb_id.Text;
            pr[1] = tb_titulo.Text;
            pr[2] = tb_autor.Text;
            pr[3] = tb_genero.Text;
            pr[4] = tb_secao.Text;
            pr[5] = tb_preco.Text;
            pr[6] = tb_quantidade.Text;
            pr[7] = tb_situacao.Text;

            ListViewItem l = new ListViewItem(pr); // Crie o ListViewItem

            lv_livros.Items.Add(l); // Adicione o ListViewItem à lista
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lv_livros.Items.RemoveAt(lv_livros.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_livros.SelectedItems[0].SubItems[0].Text;
            tb_titulo.Text = lv_livros.SelectedItems[0].SubItems[1].Text;
            tb_autor.Text = lv_livros.SelectedItems[0].SubItems[2].Text;
            tb_genero.Text = lv_livros.SelectedItems[0].SubItems[3].Text;
            tb_secao.Text = lv_livros.SelectedItems[0].SubItems[4].Text;
            tb_preco.Text = lv_livros.SelectedItems[0].SubItems[5].Text;
            tb_quantidade.Text = lv_livros.SelectedItems[0].SubItems[6].Text;
            tb_situacao.Text = lv_livros.SelectedItems[0].SubItems[7].Text;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarProduto();
        }

        private void BuscarProduto()
        {
            foreach (ListViewItem item in lv_livros.Items) // metodo de busca por nome 
            {
                
                if (item.SubItems[1].Text.ToLower().Contains(lb_procurar.Text.ToLower())) //metodo de busca por ID 
                {
                    lv_livros.Focus();
                    item.Selected = true; // Corrigi o método para Selected
                    lv_livros.TopItem = item;
                    break;
                }

            }

        }
    }
}
