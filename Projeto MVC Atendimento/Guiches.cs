using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Atendimento
{
    class Guiches
    {
         //Propriedades
         public List<Guiche> ListaGuiches { get; set; }
        
         //Construtor
         public Guiches()
         { 
             ListaGuiches = new List<Guiche>();
         }
        
        
         public void Adicionar(Guiche guiche)
         {
             if (guiche != null)
             { 
                 ListaGuiches.Add(guiche);
             }
         }
    }
}
