using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Atendimento
{
    class Senhas
    {
        //Propriedades
        private int _proximoAtendimento;
        private Queue<Senha> _filaSenhas;

        //Construtor
        public Senhas()
        {
            ProximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }

        //Getters e Setters
        public int ProximoAtendimento
        {
            get { return _proximoAtendimento; }
            set { _proximoAtendimento = value; }
        }

        public Queue<Senha> FilaSenhas
        {
            get { return _filaSenhas; }
            set { _filaSenhas = value; }
        }

        //Metodos Publicos
        public void gerar()
        {
            FilaSenhas.Enqueue(new Senha(ProximoAtendimento));
            ProximoAtendimento++;
        }

    }
}
