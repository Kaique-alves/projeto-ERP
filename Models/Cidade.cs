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
    public class Cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        
        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades WHERE nome like @Nome " +
                                                 "ORDER BY nome", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", nome + "%");
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
                Banco.Comando = new MySqlCommand("INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)", Banco.Conexao);
                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
                // Executa o Comando, no MYSQL, tem a função do Raio do WorkBench
                Banco.Comando.ExecuteNonQuery();
                // Fecha a conexão
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
        }

        // Método update
        public void Alterar()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();

                //Alimenta o método Command com a instrução desehada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("UPDATE cidades SET nome = @nome, uf = @uf WHERE id = @id ", Banco.Conexao);

                // Cria os parâmetros utilizados na instrução SQL com seu respectivo contéudo
                Banco.Comando.Parameters.AddWithValue("@nome", nome); // Parâmetro String
                Banco.Comando.Parameters.AddWithValue("@uf", uf);
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

        // Excluir
        public void Excluir()
        {
            try
            {
                // Abre a conexão com o banco
                Banco.AbrirConexao();

                // Alimentar o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand("DELETE FROM cidades WHERE id = @id", Banco.Conexao);

                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@id", id);

                // Executa o Comando, no MySQL, tem a função do Raio do WorkBench
                Banco.Comando.ExecuteNonQuery();

                // Fecha conexão
                Banco.FecharConexao();


            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

    
}
