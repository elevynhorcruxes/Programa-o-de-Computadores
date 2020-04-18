using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class LivrosDao
    {
        string Con;
        Livros liv = new Livros();//instanciação da classe livros

        //obtém string e a conexão ao arquivo App.config
        public LivrosDao()
        {
            //define string de conexão e cria a conexão

            Con = "Persist Security Info=False;server=localhost;database=livros;uid=root;pwd=";
        }

        //inclui um novo livro na tabela
        public void IncluirLivro(Livros livros)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO livros(codLivro,tituloLivro,autorLivro,editoraLivro,precoLivro,capa) " +
                              "Values(?codLivro,?tituloLivro,?autorLivro,?editoraLivro,?precoLivro,?capa)";

            Com.Parameters.AddWithValue("?codLivro", livros.LivroID);
            Com.Parameters.AddWithValue("?tituloLivro", livros.Titulo);
            Com.Parameters.AddWithValue("?autorLivro", livros.Autor);
            Com.Parameters.AddWithValue("?editoraLivro", livros.Editora);
            Com.Parameters.AddWithValue("?precoLivro", livros.Preco);
            Com.Parameters.AddWithValue("?capa", livros.Capa);

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        //altera um aluno na tabela
        public void AlterarLivro(Livros livros)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            //string capa = livros.Capa;
            Com.CommandText = "UPDATE Livros SET titulo= '" + livros.Titulo + "'" + "," + " autor='"
                                + livros.Autor + "'" + "," + " preco=" + livros.Preco + "," + " capa ='"
                                + livros.Capa + "' WHERE id=" + livros.LivroID;

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        //excluir um livro na tabela
        public void ExcluirLivro(Livros livros)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "DELETE FROM alunos WHERE id=" + livros.LivroID;

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
        
        //obtém todos os livros selecionados
        public DataTable getLivros()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "select * from livros";
            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);

                DataTable dtLivros = new System.Data.DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;
            }

            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }


            //parei aqui, morrendo por dentro
            //por favor, alguém me ajuda

        }


    }
}
