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
    public class Marca
    {
        public int id {  get; set; }
        public string marca {  get; set; }



        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Comando = new MySqlCommand("SELECT * FROM Marcas WHERE marca like @Marca " +
                                                    "ORDER BY marca", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Marca", marca + "%");
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
                // Abre a conexão com o banco
                Banco.AbrirConexao();
                // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("INSERT INTO marcas (marca) VALUES (@marca)", Banco.Conexao);
                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
                
                // Executa o Comando, no MYSQL, tem a função do Raio do WorkBench
                Banco.Comando.ExecuteNonQuery();
                // Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();

                //Alimenta o método Command com a instrução desehada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("UPDATE marcas SET marca = @marca WHERE id = @id ", Banco.Conexao);

                // Cria os parâmetros utilizados na instrução SQL com seu respectivo contéudo
                Banco.Comando.Parameters.AddWithValue("@marca", marca); // Parâmetro String                
                Banco.Comando.Parameters.AddWithValue("@id", id);

                // Executa o Comando, no MySQL, tem a função do raio do workbench
                Banco.Comando.ExecuteNonQuery();

                // Fecha conexão
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
                // Abre a conexão com o banco
                Banco.AbrirConexao();

                // Alimentar o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("DELETE FROM marcas WHERE id = @id", Banco.Conexao);

                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@id", id);

                // Executa o Comando, no MySQL, tem a função do Raio do WorkBench
                Banco.Comando.ExecuteNonQuery();

                // Fecha conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }


}
