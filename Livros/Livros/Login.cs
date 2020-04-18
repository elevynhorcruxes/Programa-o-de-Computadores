using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Login
    {
        //atributos
        private String login;
        private String senha;

        //getters e setters
        public String Login1
        {
            get { return login; }
            set { login = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        //construtor com valor de parâmetro
        public Login(string login, string senha)
        {
            this.Login1 = login;
            this.Senha = senha;
        }

        //construtor sem parâmetro
        public Login()
        {

        }
    }
}
