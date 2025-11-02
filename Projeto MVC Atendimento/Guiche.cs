using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Atendimento
{
    class Guiche
    {
        //Propriedades
        private int _id;
        private Queue<Senha> _atendimentos;

        //construtores
        public Guiche ()
        {
            _id = 0;
            _atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            Id = id;
            _atendimentos = new Queue<Senha>();
        }
        
        //get e set
        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }
        
        public Queue<Senha> Atendimentos
        {
            get { return _atendimentos; }
        
            set { _atendimentos = value; }
        }
        
        //metodos
        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas == null || filaSenhas.Count == 0)
            { 
                return false;
            }
        
            Senha proximaSenha = filaSenhas.Dequeue();
            Atendimentos.Enqueue(proximaSenha);
        
            return true;
        }
    }
}
