using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Menu
    {
        private List<Alimento> alimento = new List<Alimento>();
        
        private Pedido pedido;
        private int precio;
        private string nombre;

        public void AgregarAlimento(Alimento alimento)
        {
            
        }
        public void QuitarAlimento(Alimento alimento)
        {
           
        }
        public int ObtienePrecio()
        {
            return 1;
        }
        public int CambiarPrecio(int precio)
        {
            return 1;
        }
        public Menu(Pedido pedido,int precio,string nombre)
        {
            this.pedido = pedido;
            this.precio = precio;
            this.nombre = nombre;
            
        }
    }

    
}
