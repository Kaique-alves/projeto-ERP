using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211469.Models;

namespace _211469.Views
{
    public partial class FrmCidades : Form
    {
        Cidade c;
        public FrmCidades()
        {
            InitializeComponent();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            TxtID.Clear();
            TxtNome.Clear();
            TxtUF.Clear();
            TxtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
            DgvCidades.DataSource = c.Consultar();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == String.Empty) return;

            c = new Cidade()
            {
                nome = TxtNome.Text,
                uf = TxtUF.Text
            };
            c.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void DgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvCidades.RowCount > 0)
            {
                TxtID.Text = DgvCidades.CurrentRow.Cells["id"].Value.ToString();
                TxtNome.Text = DgvCidades.CurrentRow.Cells["nome"].Value.ToString();
                TxtUF.Text = DgvCidades.CurrentRow.Cells["uf"].Value.ToString();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == String.Empty) return;

            c = new Cidade()
            {
                id = int.Parse(TxtID.Text),
                nome = TxtNome.Text,
                uf = TxtUF.Text
            };

            c.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir a cidade?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Cidade()
                {
                    id = int.Parse(TxtID.Text)
                };

                c.Excluir();

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
