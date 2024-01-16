using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211469.Models;

namespace _211469.Views
{
    public partial class FrmClientes : Form
    {
        Cidade ci;
        Cliente cl;

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Cria um objeto do tipo cidade
            // E alimenta o comboBox
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            // Deixa invisível colunas do Grid
            DgvClientes.Columns["idCidade"].Visible = false;
            DgvClientes.Columns["foto"].Visible = false;

        }

        void limpaControles()
        {
            TxtID.Clear();
            TxtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            cgkVenda.Checked = false;
        }

         void carregarGrid(string pesquisa)
        {
            cl = new Cliente()
            {
                nome = pesquisa 
            };
            DgvClientes.DataSource = cl.Consultar();
        }

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)cboCidades.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/clientes/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "") return;

            cl = new Cliente()
            {
                nome = TxtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = cgkVenda.Checked
            };
            cl.Incluir();

            limpaControles();
            carregarGrid("");
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvClientes.RowCount > 0)
            {
                TxtID.Text = DgvClientes.CurrentRow.Cells["id"].Value.ToString();
                TxtNome.Text = DgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidades.Text = DgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = DgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                cgkVenda.Checked = (bool)DgvClientes.CurrentRow.Cells["venda"].Value;
                mskCPF.Text = DgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = DgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = DgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.ImageLocation = DgvClientes.CurrentRow.Cells["foto"].Value.ToString();
            }

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "") return;

            cl = new Cliente()
            {
                id = int.Parse(TxtID.Text),
                nome = TxtNome.Text,
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = cgkVenda.Checked
            };
            cl.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o Cliente?", "Exclusão",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    id = int.Parse(TxtID.Text),
                };
                cl.Excluir();

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
