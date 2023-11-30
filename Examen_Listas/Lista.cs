using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Listas
{
    public class Lista
    {
        Nodo primero;
        Nodo ultimo;

        public Lista()
        {
            primero = ultimo = null;
        }
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            return false;
        }
        public void Insertarfinal(string nombre, int edad)
        {
            Persona nuevaPersona = new Persona(nombre, edad);
            Nodo nuevoNodo = new Nodo(nuevaPersona);

            if (ListaVacia())
            {
                primero = ultimo = nuevoNodo;
            }
            else
            {
                ultimo._Siguiente = nuevoNodo;
                ultimo = nuevoNodo;
            }
        }
        public string Buscar(string nombre)
        {
            Nodo actual = primero;
            int posicion = 1;

            while (actual != null)
            {
                if (actual.getDatos().Nombre == nombre)
                {
                    return $"La persona llamada {nombre} se encuentra en la posición {posicion}.";
                }

                actual = actual.getSiguiente();
                posicion++;
            }

            return $"La persona llamada {nombre} no se encuentra en la lista.";
        }
        public void ImprimirListaOrdenadaPorEdad()
        {
            Nodo actual = primero;
            int menor = int.MaxValue;

            while (actual != null)
            {
                if (actual.getDatos().Edad < menor)
                {
                    menor = actual.getDatos().Edad;
                }

                Console.WriteLine(actual.getDatos().Edad);

                actual = actual.getSiguiente();
            }
        }
    }
}
