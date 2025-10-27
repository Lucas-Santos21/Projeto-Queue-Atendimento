using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Atendimento
{
    class Senha
    {
        //Propriedades
        private int _id;
        private DateTime _dataGerac;
        private DateTime _horaGerac;
        private DateTime? _dataAtend;
        private DateTime? _horaAtend;

        //Construtor
        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now.Date;
            HoraGerac = DateTime.Now;
            DataAtend = null;
            HoraAtend = null;
        }

        //propriedades privadas
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime DataGerac
        {
            get { return _dataGerac; }
            set { _dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return _horaGerac; }
            set { _horaGerac = value; }
        }

        public DateTime? DataAtend
        {
            get { return _dataAtend; }
            set { _dataAtend = value; }
        }

        public DateTime? HoraAtend
        {
            get { return _horaAtend; }
            set { _horaAtend = value; }
        }

        //Metodos Publicos
        public string dadosParciais()
        {
            string saida = $"{Id}-{DataGerac:dd/MM/yyyy}-{HoraGerac:HH:mm}";

            return saida;
        }

        public string dadosCompletos()
        {
            string saida = $"{Id}-{DataGerac:dd/MM/yyyy}-{HoraGerac:HH:mm}-{DataAtend:dd/MM/yyyy}-{HoraAtend:HH:mm}";

            return saida;
        }

    }
}
