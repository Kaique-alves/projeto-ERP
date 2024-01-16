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
    public partial class FrmProdutos : Form
    {
        Categoria cate;
        Marca mc;
        Produto pd;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            cate = new Categoria();
            CboCategoria.DataSource = cate.Consultar();
            CboCategoria.DisplayMember = "categoria";
            CboCategoria.ValueMember = "id";

            mc = new Marca();
            CboMarca.DataSource = mc.Consultar();
            CboMarca.DisplayMember = "marca";
            CboMarca.ValueMember = "id";

            
            limpaControles();
            carregarGrid("");

             DgvProdutos.Columns["idCategoria"].Visible = false;
             DgvProdutos.Columns["idMarca"].Visible = false;
            DgvProdutos.Columns["foto"].Visible = false;

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            if (TxtDescricao.Text == "") return;

            pd = new Produto()
            {
                descricao = TxtDescricao.Text,
                idCategoria = (int)CboCategoria.SelectedValue,
                idMarca = (int)CboMarca.SelectedValue,
                valorVenda = double.Parse(TxtVenda.Text),
                estoque = double.Parse(TxtEstoque.Text),
                foto = PicFoto.ImageLocation,
            };
            pd.Incluir();

            limpaControles();
            carregarGrid("");
        }

        void limpaControles()
        {
            TxtID.Clear();
            TxtDescricao.Clear();
            CboCategoria.SelectedIndex = -1;
            CboMarca.SelectedIndex = -1;
            TxtVenda.Clear();
            TxtEstoque.Clear();
            PicFoto.ImageLocation = "";
        }

        void carregarGrid(string pesquisa)
        {
            pd = new Produto()
            {
                descricao = pesquisa,
            };
            DgvProdutos.DataSource = pd.Consultar();
        }

        private void CboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCategoria.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)CboCategoria.SelectedItem;
               
            }
        }

        private void CboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboMarca.SelectedIndex != -1)
            {
                DataRowView reg = (DataRowView)CboMarca.SelectedItem;
            }

        }

        private void PicFoto_Click(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/produtos/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            PicFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void DgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProdutos.RowCount > 0)
            {
                TxtID.Text = DgvProdutos.CurrentRow.Cells["id"].Value.ToString();
                TxtDescricao.Text = DgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
                CboCategoria.Text = DgvProdutos.CurrentRow.Cells["categoria"].Value.ToString();
                CboMarca.Text = DgvProdutos.CurrentRow.Cells["marca"].Value.ToString();
                TxtVenda.Text = DgvProdutos.CurrentRow.Cells["valorVenda"].Value.ToString();
                TxtEstoque.Text = DgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
                PicFoto.ImageLocation = DgvProdutos.CurrentRow.Cells["foto"].Value.ToString();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "") return;

            pd = new Produto()
            {
                id = int.Parse(TxtID.Text),
                descricao = TxtDescricao.Text,
                idCategoria = (int)CboCategoria.SelectedValue,
                idMarca = (int)CboMarca.SelectedValue,
                valorVenda = double.Parse(TxtVenda.Text),
                estoque = double.Parse(TxtEstoque.Text),
                foto = PicFoto.ImageLocation,
            };
            pd.Alterar();

            limpaControles();
            carregarGrid("");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pd = new Produto()
                {
                    id = int.Parse(TxtID.Text),
                };
                pd.Excluir();

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
