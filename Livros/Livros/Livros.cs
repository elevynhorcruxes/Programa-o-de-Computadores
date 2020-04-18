using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Livros
    {
        private int _livroID;
        private String _titulo;
        private String _autor;
        private String _editora;
        private double _preco;
        private String _capa;

        public int LivroID
        {
            get { return _livroID; }
            set { _livroID = value; }
        }

        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public String Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public String Editora
        {
            get { return _editora; }
            set { _editora = value; }
        }

        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public String Capa
        {
            get { return _capa; }
            set { _capa = value; }
        }

        //construtor do objeto sem valor de parâmetro
        public Livros()
        {

        }

        //construtor do objeto com valor de parâmetro id
        public Livros(int ID)
        {
            this.LivroID = ID;
        }

        //construtor do objeto com valor de parâmetro titulo, autor, preco
        public Livros(string titulo, string autor, double preco, string capa)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Preco = preco;
            this.Capa = capa;
        }

        //construtor do objeto com valor de parâmetro id, titulo, autor, preco
        public Livros(int ID, string titulo, string autor, double preco, String capa)
        {
            this.LivroID = ID;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Preco = preco;
            this.Capa = capa;
        }
    }
}
