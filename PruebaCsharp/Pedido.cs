using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Pedido
    {
        private Cliente cliente;
        private Garzon garzon;
        private List<Menu> menu;
        private List<Alimento> alimento;
        private Mesa mesa;
        private DateTime fecha;
        private DateTime hora;
        private bool estado;

        public bool Registrarse(string[]param)
        {
            return true;
        }
        
    }
}
