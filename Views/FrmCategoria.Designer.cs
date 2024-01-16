namespace _211469.Views
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvCategoria = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvCategoria);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 243);
            this.groupBox1.TabIndex = 1019;
            this.groupBox1.TabStop = false;
            // 
            // DgvCategoria
            // 
            this.DgvCategoria.AllowUserToAddRows = false;
            this.DgvCategoria.AllowUserToDeleteRows = false;
            this.DgvCategoria.AllowUserToOrderColumns = true;
            this.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoria.Location = new System.Drawing.Point(16, 65);
            this.DgvCategoria.Name = "DgvCategoria";
            this.DgvCategoria.ReadOnly = true;
            this.DgvCategoria.Size = new System.Drawing.Size(630, 164);
            this.DgvCategoria.TabIndex = 10;
            this.DgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategoria_CellClick);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.Location = new System.Drawing.Point(578, 12);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(69, 48);
            this.BtnConsultar.TabIndex = 8;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(14, 31);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(558, 20);
            this.TxtPesquisa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o nome da Categoria para pesquisar:";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFechar.Location = new System.Drawing.Point(541, 120);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(130, 57);
            this.BtnFechar.TabIndex = 1018;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(409, 120);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(130, 57);
            this.BtnExcluir.TabIndex = 1017;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(278, 120);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 57);
            this.BtnCancelar.TabIndex = 1016;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlterar.Image")));
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(147, 120);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(130, 57);
            this.BtnAlterar.TabIndex = 1015;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnIncluir.Image")));
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(16, 120);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(130, 57);
            this.BtnIncluir.TabIndex = 1014;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(12, 80);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(659, 20);
            this.TxtCategoria.TabIndex = 1012;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1013;
            this.label2.Text = "Categoria:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(12, 25);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(77, 20);
            this.TxtID.TabIndex = 1011;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1010;
            this.label1.Text = "Código:";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvCategoria;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
    }
}