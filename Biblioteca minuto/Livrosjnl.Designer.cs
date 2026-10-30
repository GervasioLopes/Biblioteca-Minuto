namespace Biblioteca_minuto
{
    partial class Livrosjnl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "0", "\"Cem Anos de Solidão\"", "Gabriel García Márquez", "Realismo Mágico", "A-2", "40,00", "25", "Ativo" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "1", "\"A Revolução dos Bichos\" ", "George Orwell", "Ficção Política", "B-4", "25,00", "40", "Ativo" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "2", "\"Dom Quixote\"", "Miguel de Cervantes", "Romance de Cavalaria", "C-1", "30,00", "20", "Estoque" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "3", "\"O Pequeno Príncipe\"", "Antoine de Saint-Exupéry", "Literatura Infantil e Filosofia", "D-6", "20,00", "35", "Ativo" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livrosjnl));
            lv_livros = new ListView();
            col_id = new ColumnHeader();
            col_titulo = new ColumnHeader();
            col_autor = new ColumnHeader();
            col_genero = new ColumnHeader();
            col_secao = new ColumnHeader();
            col_preco = new ColumnHeader();
            col_qnt = new ColumnHeader();
            col_situacao = new ColumnHeader();
            panel1 = new Panel();
            btn_buscar = new Button();
            lb_procurar = new TextBox();
            btn_limpar = new Button();
            label8 = new Label();
            tb_id = new TextBox();
            btn_obter = new Button();
            btn_remove = new Button();
            btn_add = new Button();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tb_situacao = new TextBox();
            label6 = new Label();
            tb_quantidade = new TextBox();
            label5 = new Label();
            tb_preco = new TextBox();
            label4 = new Label();
            tb_secao = new TextBox();
            label3 = new Label();
            tb_autor = new TextBox();
            label2 = new Label();
            tb_genero = new TextBox();
            label1 = new Label();
            tb_titulo = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lv_livros
            // 
            lv_livros.Columns.AddRange(new ColumnHeader[] { col_id, col_titulo, col_autor, col_genero, col_secao, col_preco, col_qnt, col_situacao });
            lv_livros.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lv_livros.FullRowSelect = true;
            lv_livros.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            lv_livros.Location = new Point(15, 12);
            lv_livros.MultiSelect = false;
            lv_livros.Name = "lv_livros";
            lv_livros.Size = new Size(621, 164);
            lv_livros.TabIndex = 0;
            lv_livros.UseCompatibleStateImageBehavior = false;
            lv_livros.View = View.Details;
            // 
            // col_id
            // 
            col_id.Text = "ID";
            // 
            // col_titulo
            // 
            col_titulo.Text = "TÍTULO";
            col_titulo.Width = 120;
            // 
            // col_autor
            // 
            col_autor.Text = "AUTOR";
            col_autor.Width = 80;
            // 
            // col_genero
            // 
            col_genero.Text = "GÊNERO";
            // 
            // col_secao
            // 
            col_secao.Text = "SEÇÃO";
            // 
            // col_preco
            // 
            col_preco.Text = "PREÇO";
            // 
            // col_qnt
            // 
            col_qnt.Text = "QUANTIDADE";
            // 
            // col_situacao
            // 
            col_situacao.Text = "SITUAÇÃO";
            col_situacao.Width = 80;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btn_buscar);
            panel1.Controls.Add(lb_procurar);
            panel1.Controls.Add(btn_limpar);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tb_id);
            panel1.Controls.Add(btn_obter);
            panel1.Controls.Add(btn_remove);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tb_situacao);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tb_quantidade);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tb_preco);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_secao);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_autor);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_genero);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_titulo);
            panel1.Location = new Point(0, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 372);
            panel1.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(491, 14);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(134, 39);
            btn_buscar.TabIndex = 24;
            btn_buscar.Text = "BUSCAR";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // lb_procurar
            // 
            lb_procurar.Location = new Point(27, 23);
            lb_procurar.Name = "lb_procurar";
            lb_procurar.Size = new Size(425, 23);
            lb_procurar.TabIndex = 23;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(480, 130);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(156, 34);
            btn_limpar.TabIndex = 22;
            btn_limpar.Text = "LIMPAR";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 64);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 21;
            label8.Text = "ID";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(27, 82);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(203, 23);
            tb_id.TabIndex = 20;
            // 
            // btn_obter
            // 
            btn_obter.Location = new Point(480, 236);
            btn_obter.Name = "btn_obter";
            btn_obter.Size = new Size(156, 34);
            btn_obter.TabIndex = 19;
            btn_obter.Text = "OBTER";
            btn_obter.UseVisualStyleBackColor = true;
            btn_obter.Click += btn_obter_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(480, 203);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(156, 34);
            btn_remove.TabIndex = 18;
            btn_remove.Text = "REMOVER";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(480, 96);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(156, 34);
            btn_add.TabIndex = 17;
            btn_add.Text = "INCLUIR";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(249, 116);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 16;
            label7.Text = "SITUAÇÃO";
            label7.Click += label7_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(70, 62, 49);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(3, 305);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 139);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // tb_situacao
            // 
            tb_situacao.Location = new Point(249, 134);
            tb_situacao.Name = "tb_situacao";
            tb_situacao.Size = new Size(203, 23);
            tb_situacao.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(249, 223);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 14;
            label6.Text = "QUANTIDADE";
            // 
            // tb_quantidade
            // 
            tb_quantidade.Location = new Point(249, 241);
            tb_quantidade.Name = "tb_quantidade";
            tb_quantidade.Size = new Size(203, 23);
            tb_quantidade.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(249, 170);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "PREÇO";
            // 
            // tb_preco
            // 
            tb_preco.Location = new Point(249, 188);
            tb_preco.Name = "tb_preco";
            tb_preco.Size = new Size(203, 23);
            tb_preco.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 222);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 10;
            label4.Text = "SEÇÃO";
            // 
            // tb_secao
            // 
            tb_secao.Location = new Point(27, 240);
            tb_secao.Name = "tb_secao";
            tb_secao.Size = new Size(203, 23);
            tb_secao.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(249, 64);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "AUTOR";
            // 
            // tb_autor
            // 
            tb_autor.Location = new Point(249, 82);
            tb_autor.Name = "tb_autor";
            tb_autor.Size = new Size(203, 23);
            tb_autor.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 168);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "GÊNERO";
            // 
            // tb_genero
            // 
            tb_genero.Location = new Point(27, 186);
            tb_genero.Name = "tb_genero";
            tb_genero.Size = new Size(203, 23);
            tb_genero.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 116);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "TÍTULO DA OBRA";
            // 
            // tb_titulo
            // 
            tb_titulo.Location = new Point(27, 134);
            tb_titulo.Name = "tb_titulo";
            tb_titulo.Size = new Size(203, 23);
            tb_titulo.TabIndex = 3;
            // 
            // Livrosjnl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 556);
            Controls.Add(panel1);
            Controls.Add(lv_livros);
            Name = "Livrosjnl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO LIVROS";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lv_livros;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox tb_titulo;
        private Label label7;
        private TextBox tb_situacao;
        private Label label6;
        private TextBox tb_quantidade;
        private Label label5;
        private TextBox tb_preco;
        private Label label4;
        private TextBox tb_secao;
        private Label label3;
        private TextBox tb_autor;
        private Label label2;
        private TextBox tb_genero;
        private Label label1;
        private ColumnHeader col_id;
        private ColumnHeader col_titulo;
        private ColumnHeader col_autor;
        private ColumnHeader col_genero;
        private ColumnHeader col_secao;
        private ColumnHeader col_preco;
        private ColumnHeader col_qnt;
        private ColumnHeader col_situacao;
        private Button btn_remove;
        private Button btn_add;
        private Button btn_obter;
        private Label label8;
        private TextBox tb_id;
        private Button btn_limpar;
        private Button btn_buscar;
        private TextBox lb_procurar;
    }
}