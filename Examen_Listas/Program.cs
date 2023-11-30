using System;
namespace Examen_Listas
{
    class program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();


            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese el nombre de la persona: ");
                string nuevoNombre = Console.ReadLine();

                Console.Write($"Ingrese la edad de la persona: ");
                int nuevaEdad = int.Parse(Console.ReadLine());

                miLista.Insertarfinal(nuevoNombre, nuevaEdad);
            }

         

            Console.Write("Ingrese el nombre que desea buscar: ");
            string nombreABuscar = Console.ReadLine();
            string resultadoBusqueda = miLista.Buscar(nombreABuscar);
            Console.WriteLine(resultadoBusqueda);

            Console.WriteLine("\nLista ordenada por edad:");
            miLista.ImprimirListaOrdenadaPorEdad();

         
            Console.ReadLine();

        }

    }
}
