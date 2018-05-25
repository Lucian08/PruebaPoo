using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Cliente : Persona
    {
        private Pedido pedido;
        

        public bool Registrarse(string[]param)
        {
            return true;
        }
        public void ReservarMesa()
        {
            
            List<Mesa> mesa = new List<Mesa>();
            
        }
        public void QuitarMesa()
        {
           
        }
        public Cliente(Pedido pedido)
        {
            this.pedido = pedido;
        }
    }
}
