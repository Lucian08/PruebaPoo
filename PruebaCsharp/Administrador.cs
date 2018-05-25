using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCsharp
{
    public class Administrador : Trabajador
    {

        public void AgregarEmpleado(Empleado empleado)
        {
            
        }
        public void QuitarEmpleado(Empleado empleado)
        {
            
        }
        public void AgregarBonificacion(Empleado empleado, int monto)
        {
            
        }
        public List<Pedido> VisualizaVentas(DateTime inicio, DateTime termino)
        {

            List<Pedido> pedido = new List<Pedido>();
            return pedido;
        }
        public List<Pedido> VisualizaVentas()
        {

            List<Pedido> pedido = new List<Pedido>();
            return pedido;
        }
        public void PagarEmpleados(Empleado empleado,int mes,int año)
        {

            
        }
    }
}
