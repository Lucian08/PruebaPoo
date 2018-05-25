using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Alimento
    {
        private Pedido pedido;
        private string nombre;
        private int precio;

        public Alimento(Pedido pedido,string nombre,int precio)
        {
            this.pedido = pedido;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
    public class Plato
    {

    }
    public class Bebida
    {

    }
    public class Postre
    {

    }
    public class Ensalada
    {

    }
    public class Agregado
    {

    }
}
