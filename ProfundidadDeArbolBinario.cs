using System;
using System.Collections.Generic;

namespace Practica1CTEDyA
{
    // Clase genérica Cola (FIFO) para recorrer el árbol
    public class Cola<T>
    {
        private readonly List<T> datos = new List<T>(); // Lista interna donde se guardan los elementos

        public void encolar(T elem) => datos.Add(elem); // Agrego un elemento al final de la cola

        public T desencolar() // Saco el primer elemento de la cola
        {
            T temp = datos[0]; // Agarro el primer elemento
            datos.RemoveAt(0); // Lo eliminamos de la lista
            return temp;
        }

        public T tope() => datos[0]; // Devuelve el primer elemento sin eliminarlo

        public bool esVacia() => datos.Count == 0; // Retorna true si la cola está vacía
    }

    // Nodo del árbol
    public class Nodo
    {
        public int Dato { get; }
        public Nodo? Izquierdo { get; set; } // Referencia al hijo izquierdo 
        public Nodo? Derecho { get; set; } // Referencia al hijo derecho 

        public Nodo(int dato, Nodo? izquierdo = null, Nodo? derecho = null)    // Constructor: inicializa el nodo con su dato y opcionalmente con hijos
        {
            Dato = dato;
            Izquierdo = izquierdo;
            Derecho = derecho;
        }
    }

    // Clase: ProfundidadDeArbolBinario 
    public class ProfundidadDeArbolBinario
    {
        private readonly Nodo? raiz; // Nodo raíz del árbol (puede ser null si está vacío)

        public ProfundidadDeArbolBinario(Nodo? raiz)
        {
            this.raiz = raiz;
        }

        // Suma de los elementos en profundidad p
        public int sumaElementosProfundidad(int p) 
        {
            if (raiz is null || p < 0) return 0; // Si no hay árbol o p es inválido, devolvemos 0


            var cola = new Cola<(Nodo nodo, int nivel)>(); // Cola para el recorrido por niveles
            cola.encolar((raiz, 0)); // Agregamos la raíz en el nivel 0

            int suma = 0; 

            while (!cola.esVacia())  // Bucle While, mientras la cola no esté vacía
            {
                var (nodo, nivel) = cola.desencolar(); // Saco un nodo con su nivel

                if (nivel == p) // Si el nodo está en el nivel pedido
                    suma += nodo.Dato; // Sumo su valor

                //si ya pasamos el nivel p, no hace falta seguir
                if (nivel > p) continue;

                if (nodo.Izquierdo is not null)  // Si existe hijo izquierdo
                    cola.encolar((nodo.Izquierdo, nivel + 1)); // Lo agrego con su nivel correspondiente


                if (nodo.Derecho is not null) // Si existe hijo derecho
                    cola.encolar((nodo.Derecho, nivel + 1));  // Lo agrego con su nivel correspondiente
            }

            return suma;
        }
    }
}