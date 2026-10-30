namespace Biblioteca_minuto
{
    partial class Form1_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Home));
            lb_Titulo = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            rEGISTROToolStripMenuItem = new ToolStripMenuItem();
            locatariosToolStripMenuItem = new ToolStripMenuItem();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            cONSULTAToolStripMenuItem = new ToolStripMenuItem();
            locatariosToolStripMenuItem1 = new ToolStripMenuItem();
            livrosToolStripMenuItem1 = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem1 = new ToolStripMenuItem();
            cONFIGURAÇÕESToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.AutoSize = true;
            lb_Titulo.Font = new Font("CHAMAN ELEGANT FONT", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Titulo.Location = new Point(93, 34);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(196, 27);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "BIBLIOTECA MINUTO";
            lb_Titulo.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 62, 49);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(-7, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 88);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(187, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Font = new Font("CHAMAN ELEGANT FONT", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { rEGISTROToolStripMenuItem, cONSULTAToolStripMenuItem, cONFIGURAÇÕESToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(398, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // rEGISTROToolStripMenuItem
            // 
            rEGISTROToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locatariosToolStripMenuItem, livrosToolStripMenuItem, fornecedoresToolStripMenuItem });
            rEGISTROToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rEGISTROToolStripMenuItem.Image = (Image)resources.GetObject("rEGISTROToolStripMenuItem.Image");
            rEGISTROToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            rEGISTROToolStripMenuItem.Size = new Size(98, 24);
            rEGISTROToolStripMenuItem.Text = "&REGISTRO";
            rEGISTROToolStripMenuItem.Click += rEGISTROToolStripMenuItem_Click;
            // 
            // locatariosToolStripMenuItem
            // 
            locatariosToolStripMenuItem.Image = (Image)resources.GetObject("locatariosToolStripMenuItem.Image");
            locatariosToolStripMenuItem.Name = "locatariosToolStripMenuItem";
            locatariosToolStripMenuItem.Size = new Size(184, 26);
            locatariosToolStripMenuItem.Text = "Locatarios";
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.Image = (Image)resources.GetObject("livrosToolStripMenuItem.Image");
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(184, 26);
            livrosToolStripMenuItem.Text = "Livros";
            livrosToolStripMenuItem.Click += livrosToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Image = (Image)resources.GetObject("fornecedoresToolStripMenuItem.Image");
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(184, 26);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // cONSULTAToolStripMenuItem
            // 
            cONSULTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { locatariosToolStripMenuItem1, livrosToolStripMenuItem1, fornecedoresToolStripMenuItem1 });
            cONSULTAToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cONSULTAToolStripMenuItem.Image = (Image)resources.GetObject("cONSULTAToolStripMenuItem.Image");
            cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            cONSULTAToolStripMenuItem.Size = new Size(102, 24);
            cONSULTAToolStripMenuItem.Text = "C&ONSULTA";
            // 
            // locatariosToolStripMenuItem1
            // 
            locatariosToolStripMenuItem1.Image = (Image)resources.GetObject("locatariosToolStripMenuItem1.Image");
            locatariosToolStripMenuItem1.Name = "locatariosToolStripMenuItem1";
            locatariosToolStripMenuItem1.Size = new Size(184, 26);
            locatariosToolStripMenuItem1.Text = "Locatarios";
            // 
            // livrosToolStripMenuItem1
            // 
            livrosToolStripMenuItem1.Image = (Image)resources.GetObject("livrosToolStripMenuItem1.Image");
            livrosToolStripMenuItem1.Name = "livrosToolStripMenuItem1";
            livrosToolStripMenuItem1.Size = new Size(184, 26);
            livrosToolStripMenuItem1.Text = "Livros";
            livrosToolStripMenuItem1.Click += livrosToolStripMenuItem1_Click;
            // 
            // fornecedoresToolStripMenuItem1
            // 
            fornecedoresToolStripMenuItem1.Image = (Image)resources.GetObject("fornecedoresToolStripMenuItem1.Image");
            fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            fornecedoresToolStripMenuItem1.Size = new Size(184, 26);
            fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            // 
            // cONFIGURAÇÕESToolStripMenuItem
            // 
            cONFIGURAÇÕESToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cONFIGURAÇÕESToolStripMenuItem.Image = (Image)resources.GetObject("cONFIGURAÇÕESToolStripMenuItem.Image");
            cONFIGURAÇÕESToolStripMenuItem.Name = "cONFIGURAÇÕESToolStripMenuItem";
            cONFIGURAÇÕESToolStripMenuItem.Size = new Size(141, 24);
            cONFIGURAÇÕESToolStripMenuItem.Text = "CON&FIGURAÇÕES";
            cONFIGURAÇÕESToolStripMenuItem.Click += cONFIGURAÇÕESToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(46, 24);
            sairToolStripMenuItem.Text = "&SAIR";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 450);
            Controls.Add(panel1);
            Controls.Add(lb_Titulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1_Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca Minuto";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Titulo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rEGISTROToolStripMenuItem;
        private ToolStripMenuItem cONSULTAToolStripMenuItem;
        private ToolStripMenuItem cONFIGURAÇÕESToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem locatariosToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem locatariosToolStripMenuItem1;
        private ToolStripMenuItem livrosToolStripMenuItem1;
        private ToolStripMenuItem fornecedoresToolStripMenuItem1;
    }
}