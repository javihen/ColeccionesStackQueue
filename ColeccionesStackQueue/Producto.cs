using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesStackQueue
{
    public class Producto
    {
        public String Descripcion;

        public Producto()
        {
            this.Descripcion = "Esta vacio";
        }

        public Producto(String d)
        {
            this.Descripcion = d;
        }


        public String GetDescripcion()
        {
            return this.Descripcion;
        }
        public void SetDescripcion(String Dato)
        {
            this.Descripcion = Dato;
        }
    }
}
