using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{ //clase C# llamada ProfundidadDeArbolBinario  
    public class ProfundidadDeArbolBinario
    {
        private ArbolBinario<int> arbol;  //variable de instancia un árbol binario de números enteros

        // Constructor de la clase, recibe como argumento un árbol binario y lo asigna a la variable de instancia
        public ProfundidadDeArbolBinario(ArbolBinario<int> arbol)
        {
            this.arbol = arbol;
        }
        //metodo de instancia sumaElementosProfundidad(int p):int
        public int sumaElementosProfundidad(int p) //Devuelve la suma de todos los nodos que se encuentren en la profundidad p
        {
            return sumaRec(arbol, p, 0); // Comienzo desde la raíz (nivelActual = 0)
        }
        // Metodo privado recursivo que se encarga de recorrer el árbol     
        private int sumaRec(ArbolBinario<int> nodo, int p, int nivelActual)
        {
            if (nodo == null) //Caso base: si el nodo es nulo, no aporta a la suma
                return 0;

            if (nivelActual == p)   // Caso en el que llego a la profundidad pedida
                return nodo.getDatoRaiz();

            return sumaRec(nodo.getHijoIzquierdo(), p, nivelActual + 1)  // Caso recursivo:sigo recorriendo subárbol izquierdo y derecho, aumentando el nivel
                 + sumaRec(nodo.getHijoDerecho(), p, nivelActual + 1);
        }
    }
}
