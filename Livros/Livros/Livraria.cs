using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    class Livraria
    {

        private int _codliv;

        public int Codliv
        {
            get
            { return _codliv; }

            set
            { _codliv = value; }
        }

        private String _nomeliv;

        public String Nomeliv
        {
            get
            { return _nomeliv; }
            set
            { _nomeliv = value; }
        }

        private String _end;

        public String End
        {
            get
            { return _end; }
            set
            { _end = value; }
        }

        private String _bairro;

        public String Bairro
        {
            get
            { return _bairro; }
            set
            { _bairro = value; }
        }

        private int _num;

        public int Num
        {
            get
            { return _num; }
            set
            { _num = value; }
        }

        private String _cidade;

        public String Cidade
        {
            get
            { return _cidade; }
            set
            { _cidade = value; }
        }

        private String _estado;

        public String Estado
        {
            get
            { return _estado; }
            set
            { _estado = value; }
        }

        private String _tel;

        public String Tel
        {
            get
            { return _tel; }
            set
            { _tel = value; }
        }

        public Livraria()
        {

        }

        public Livraria(int codliv)
        {
            Codliv = codliv;
        }

        public Livraria(int codliv, string nomeliv, string end, string bairro, int num, string cidade, string estado, string tel)
        {
            Codliv = codliv;
            Nomeliv = nomeliv;
            End = end;
            Bairro = bairro;
            Num = num;
            Cidade = cidade;
            Estado = estado;
            Tel = tel;
        }
    }
}
