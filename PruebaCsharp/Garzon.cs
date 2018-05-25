using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Garzon:Empleado
    {
        private Pedido pedido;

        public Garzon(Pedido pedido)
        {
            this.pedido=pedido;
         
        }

        
    }
}
