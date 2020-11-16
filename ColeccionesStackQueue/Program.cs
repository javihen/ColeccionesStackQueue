using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto objP1 = new Producto("Pantallas");
            Producto objP2 = new Producto("Mouse");
            Producto objP3 = new Producto();
            // --------- COLECCION STACK ------------ ultimo en entrar, primero en salir
            Stack<Producto> aProducto = new Stack<Producto>();

            aProducto.Push(objP1);
            aProducto.Push(objP2);
            aProducto.Push(objP3);

            foreach (Producto P in aProducto)
            {
                Console.WriteLine(P.Descripcion);
            }

            Console.WriteLine(aProducto.Peek().Descripcion);

            aProducto.Pop();

            foreach (Producto P in aProducto)
            {
                Console.WriteLine(P.Descripcion);
            }
            //--------- CLASE COLECCION QUEUE ------------ Primero en entrar, primero en salir.

            Queue<Producto> aProducto2 = new Queue<Producto>();

            aProducto2.Enqueue(objP1);
            aProducto2.Enqueue(objP2);
            aProducto2.Enqueue(objP3);
            
            foreach (Producto P in aProducto2)
            {
                Console.WriteLine(P.Descripcion);
            }

            Console.WriteLine("--------------------------------");

            Console.WriteLine(aProducto2.Peek().Descripcion);

            Console.WriteLine("--------------------------------");

            aProducto2.Dequeue();

            foreach (Producto P in aProducto2)
            {
                Console.WriteLine(P.Descripcion);
            }
            Console.ReadKey();

        }
    }
}
