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

        //propriedades privadas
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
