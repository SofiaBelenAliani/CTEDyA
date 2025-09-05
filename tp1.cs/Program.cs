using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nivel 0 (raíz)
            ArbolBinario<int> raiz = new ArbolBinario<int>(10);

            // Nivel 1
            ArbolBinario<int> nodo5 = new ArbolBinario<int>(5);
            ArbolBinario<int> nodo15 = new ArbolBinario<int>(15);
            raiz.agregarHijoIzquierdo(nodo5);
            raiz.agregarHijoDerecho(nodo15);

            // Nivel 2 (hijos de 5)
            ArbolBinario<int> nodo3 = new ArbolBinario<int>(3);
            ArbolBinario<int> nodo7 = new ArbolBinario<int>(7);
            nodo5.agregarHijoIzquierdo(nodo3);
            nodo5.agregarHijoDerecho(nodo7);

            // Nivel 2 (hijos de 15)
            ArbolBinario<int> nodo12 = new ArbolBinario<int>(12);
            ArbolBinario<int> nodo18 = new ArbolBinario<int>(18);
            nodo15.agregarHijoIzquierdo(nodo12);
            nodo15.agregarHijoDerecho(nodo18);

            // Crear objeto de la clase pedida
            ProfundidadDeArbolBinario profundidad = new ProfundidadDeArbolBinario(raiz);

            
            Console.WriteLine("Suma en profundidad 0: " + profundidad.sumaElementosProfundidad(0));
            Console.WriteLine("Suma en profundidad 1: " + profundidad.sumaElementosProfundidad(1));
            Console.WriteLine("Suma en profundidad 2: " + profundidad.sumaElementosProfundidad(2));
        }
    }
}
