using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class LoginDao
    {
        string Con;//variável para string de conexão
        fmrLogin log = new fmrLogin();//chamada da classe Login

        //obtém a string e conexão do arquivo App.config
        public LoginDao()
        {
            //define string de conexão e cria a conexão
            Con = "Persist Security Info=False;server=localhost;" +
                "database=livros;uid=root;pwd=";
        }

        public Boolean logar(fmrLogin login)
        {//método para verificar se o login e senha existem no banco de dados
            Boolean resp = false;
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            //realiza o select no banco de dados
            Com.CommandText = "select login, senha from usuarios WHERE"
                            + " login='" + login.Login1 + "'"
                            + " AND " + "senha='" + login.Senha + "'";

            try//tenta selecionar e, se existirem dados, ele retorna "true"
            {
                CN.Open();
                //int registrosAfetados = Com.ExecuteNonQuery();
                bool verifica = Com.ExecuteReader().HasRows;
                if (verifica == true)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
            }
            catch (MySqlException ex)//exceção do banco de dados
            {
                resp = false;
                throw new ApplicationException(ex.ToString());
                //exceção no sistema
            }
            finally
            {
                CN.Close();
            }
            return resp;

        }
    }

    [Serializable]
    internal class MySqlException : Exception
    {
        public MySqlException()
        {
        }

        public MySqlException(string message) : base(message)
        {
        }

        public MySqlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MySqlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    internal class MySqlCommand
    {
        public string CommandText { get; internal set; }
        public object Parameters { get; internal set; }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }

    internal class MySqlConnection
    {
        private string con;

        public MySqlConnection(string con)
        {
            this.con = con;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal MySqlCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
