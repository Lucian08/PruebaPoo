using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    class Mesa
    {
        private Pedido pedido;
        private int numero;
        private int cantidadPersona;
        private bool estado;

        public void Registrar(bool tipo)
        {
            
        }
        public bool ConsultarEstado()
        {
            return true;
        }
        public List<Mesa> Disponibles()
        {
            return new List<Mesa>();
        }
        public Mesa(Pedido pedido, int numero, int cantidadPersona, bool estado)
        {
            this.pedido = pedido;
            this.numero = numero;
            this.cantidadPersona = cantidadPersona;
            this.estado = estado;
        }
    }
}
