using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace _211469.Models
{
    public class Categoria
    {
        public int id { get; set; }

        public string categoria { get; set; }


        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Categorias WHERE categoria like @Categoria " +
                                                 "ORDER BY categoria", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@Categoria", categoria + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);
                Banco.FecharConexao();
                return Banco.datTabela;

            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("INSERT INTO categorias (categoria) VALUES (@categoria)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();

            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("UPDATE categorias SET categoria = @categoria WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("DELETE FROM categorias WHERE id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();

                Banco.FecharConexao();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
