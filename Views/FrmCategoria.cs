using _211469.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _211469.Views
{
    public partial class FrmCategoria : Form
    {
        Categoria cat;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            TxtID.Clear();
            TxtCategoria.Clear();
            TxtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            cat = new Categoria()
            {
                categoria = pesquisa
            };
            DgvCategoria.DataSource = cat.Consultar();

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtCategoria.Text == String.Empty) return;

            cat = new Categoria()
            {
                categoria = TxtCategoria.Text,
            };
            cat.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
           if (TxtID.Text == String.Empty) return;

           cat = new Categoria()
           {
               id = int.Parse(TxtID.Text),
               categoria = TxtCategoria.Text
           };
            cat.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void DgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCategoria.RowCount > 0)
            {
                TxtID.Text = DgvCategoria.CurrentRow.Cells["id"].Value.ToString();
                TxtCategoria.Text = DgvCategoria.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if(TxtID.Text == String.Empty) return;

            if(MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cat = new Categoria()
                {
                    id = int.Parse(TxtID.Text)
                };
                cat.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(TxtPesquisa.Text);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
