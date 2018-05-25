using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Persona
    {
        private int run;
        private string nombre;
        private int celular;
        private string email;
        private string clave;

        protected void ReiniciarClave(Persona persona)
        {
           

        }

        public bool IniciarSesion(string[]param)
        {
            return true;

        }

    }
}
