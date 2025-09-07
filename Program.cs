using Practica1CTEDyA;

class Program
{
    static void Main()
    {
        Nodo raiz = new Nodo(10); // Crea el nodo raíz con valor 10
        raiz.Izquierdo = new Nodo(5); // Asigna hijo izquierdo con valor 5
        raiz.Derecho = new Nodo(20); // Asigna hijo derecho con valor 20
        raiz.Izquierdo.Izquierdo = new Nodo(3); // Al hijo izquierdo (5) le asigna hijo izquierdo con valor 3
        raiz.Izquierdo.Derecho = new Nodo(7); // Al hijo izquierdo (5) le asigna hijo derecho con valor 7
        raiz.Derecho.Izquierdo = new Nodo(15); // Al hijo derecho (20) le asigna hijo izquierdo con valor 15
        raiz.Derecho.Derecho = new Nodo(25); // Al hijo derecho (20) le asigna hijo derecho con valor 25


        ProfundidadDeArbolBinario arbol = new ProfundidadDeArbolBinario(raiz); // Crea el objeto árbol a partir de la raíz que armamos arriba

        Console.WriteLine("Suma de elementos por profundidad:\n"); 

        Console.WriteLine($"Nivel 0: {arbol.sumaElementosProfundidad(0)}"); // Nivel 0 → nodo: [10], suma: 10
        
        Console.WriteLine($"Nivel 1: {arbol.sumaElementosProfundidad(1)}"); // Nivel 1 → nodos: [5, 20], suma: 25   

        Console.WriteLine($"Nivel 2: {arbol.sumaElementosProfundidad(2)}"); // Nivel 2 → nodos: [3, 7, 15, 25], suma: 50

    }
}
