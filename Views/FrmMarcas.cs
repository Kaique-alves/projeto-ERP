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
    public partial class FrmMarcas : Form
    {
        Marca m;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            TxtID.Clear();
            TxtMarca.Clear();
            TxtPesquisa.Clear();
        }

        void carregarGrid(string pesquisa)
        {
            m = new Marca()
            {
                marca = pesquisa
            };
            DgvMarcas.DataSource = m.Consultar();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtMarca.Text == string.Empty) return;

            m = new Marca()
            {
                marca = TxtMarca.Text
            };
            m.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void DgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvMarcas.RowCount > 0)
            {
                TxtID.Text = DgvMarcas.CurrentRow.Cells["id"].Value.ToString();
                TxtMarca.Text = DgvMarcas.CurrentRow.Cells["marca"].Value.ToString();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if(TxtID.Text == string.Empty) return;

            m = new Marca()
            {
                id = int.Parse(TxtID.Text),
                marca = TxtMarca.Text
            };
            m.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == string.Empty) return;

            if (MessageBox.Show("Deseja excluir a marca?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    id = int.Parse(TxtID.Text)
                };
                m.Excluir();

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
