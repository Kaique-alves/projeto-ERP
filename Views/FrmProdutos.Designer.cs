namespace _211469.Views
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicFoto = new System.Windows.Forms.PictureBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.TxtVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(12, 27);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(77, 20);
            this.TxtID.TabIndex = 1023;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1022;
            this.label1.Text = "Código:";
            // 
            // PicFoto
            // 
            this.PicFoto.Location = new System.Drawing.Point(461, 11);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(232, 239);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFoto.TabIndex = 1031;
            this.PicFoto.TabStop = false;
            this.PicFoto.Click += new System.EventHandler(this.PicFoto_Click);
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(12, 76);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(443, 20);
            this.TxtDescricao.TabIndex = 1032;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1033;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1035;
            this.label3.Text = "Categoria:";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(12, 123);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(443, 21);
            this.CboCategoria.TabIndex = 1034;
            this.CboCategoria.SelectedIndexChanged += new System.EventHandler(this.CboCategoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1037;
            this.label4.Text = "Marca:";
            // 
            // CboMarca
            // 
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(12, 175);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(443, 21);
            this.CboMarca.TabIndex = 1036;
            this.CboMarca.SelectedIndexChanged += new System.EventHandler(this.CboMarca_SelectedIndexChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // TxtVenda
            // 
            this.TxtVenda.Location = new System.Drawing.Point(15, 230);
            this.TxtVenda.Name = "TxtVenda";
            this.TxtVenda.Size = new System.Drawing.Size(165, 20);
            this.TxtVenda.TabIndex = 1038;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 1039;
            this.label7.Text = "Valor de Venda:";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Location = new System.Drawing.Point(290, 230);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(165, 20);
            this.TxtEstoque.TabIndex = 1040;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1041;
            this.label5.Text = "Estoque:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvProdutos);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 243);
            this.groupBox1.TabIndex = 1047;
            this.groupBox1.TabStop = false;
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToOrderColumns = true;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(16, 65);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.Size = new System.Drawing.Size(630, 164);
            this.DgvProdutos.TabIndex = 10;
            this.DgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.Location = new System.Drawing.Point(578, 12);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(69, 48);
            this.BtnConsultar.TabIndex = 12;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(14, 31);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(558, 20);
            this.TxtPesquisa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Digite o nome do produto para pesquisar:";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechar.Location = new System.Drawing.Point(548, 256);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(130, 57);
            this.BtnFechar.TabIndex = 1046;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(416, 256);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(130, 57);
            this.BtnExcluir.TabIndex = 1045;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(285, 256);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 57);
            this.BtnCancelar.TabIndex = 1044;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.Image")));
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(154, 256);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(130, 57);
            this.BtnAlterar.TabIndex = 1043;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnIncluir.Image")));
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(23, 256);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(130, 57);
            this.BtnIncluir.TabIndex = 1042;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 579);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicFoto);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicFoto;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboMarca;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox TxtVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}