namespace Biblioteca_minuto
{
    partial class Form3_Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_Consulta));
            lb1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_search = new Button();
            btn_remove = new Button();
            cb_titulo = new ComboBox();
            cb_ID = new ComboBox();
            cb_genero = new ComboBox();
            cb_secao = new ComboBox();
            cb_preco = new ComboBox();
            lb_Livros = new ListBox();
            SuspendLayout();
            // 
            // lb1
            // 
            resources.ApplyResources(lb1, "lb1");
            lb1.Name = "lb1";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // btn_search
            // 
            resources.ApplyResources(btn_search, "btn_search");
            btn_search.Name = "btn_search";
            btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            resources.ApplyResources(btn_remove, "btn_remove");
            btn_remove.Name = "btn_remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += button2_Click;
            // 
            // cb_titulo
            // 
            resources.ApplyResources(cb_titulo, "cb_titulo");
            cb_titulo.FormattingEnabled = true;
            cb_titulo.Name = "cb_titulo";
            // 
            // cb_ID
            // 
            cb_ID.FormattingEnabled = true;
            resources.ApplyResources(cb_ID, "cb_ID");
            cb_ID.Name = "cb_ID";
            // 
            // cb_genero
            // 
            cb_genero.FormattingEnabled = true;
            resources.ApplyResources(cb_genero, "cb_genero");
            cb_genero.Name = "cb_genero";
            // 
            // cb_secao
            // 
            cb_secao.FormattingEnabled = true;
            resources.ApplyResources(cb_secao, "cb_secao");
            cb_secao.Name = "cb_secao";
            // 
            // cb_preco
            // 
            cb_preco.FormattingEnabled = true;
            resources.ApplyResources(cb_preco, "cb_preco");
            cb_preco.Name = "cb_preco";
            // 
            // lb_Livros
            // 
            resources.ApplyResources(lb_Livros, "lb_Livros");
            lb_Livros.FormattingEnabled = true;
            lb_Livros.Name = "lb_Livros";
            lb_Livros.SelectedIndexChanged += lb_Livros_SelectedIndexChanged;
            // 
            // Form3_Consulta
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_Livros);
            Controls.Add(cb_preco);
            Controls.Add(cb_secao);
            Controls.Add(cb_genero);
            Controls.Add(cb_ID);
            Controls.Add(cb_titulo);
            Controls.Add(btn_remove);
            Controls.Add(btn_search);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb1);
            Name = "Form3_Consulta";
            Load += Form3_Consulta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_search;
        private Button btn_remove;
        private ComboBox cb_titulo;
        private ComboBox cb_ID;
        private ComboBox cb_genero;
        private ComboBox cb_secao;
        private ComboBox cb_preco;
        private ListBox lb_Livros;
    }
}