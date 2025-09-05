using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{ //Clase que calcula la suma de los elementos en una profundidad dada  
    public class ProfundidadDeArbolBinario
    {
        private ArbolBinario<int> arbol;

        public ProfundidadDeArbolBinario(ArbolBinario<int> arbol)
        {
            this.arbol = arbol;
        }

        public int sumaElementosProfundidad(int p)
        {
            return sumaRec(arbol, p, 0); 
        }
        //Funcion recursiva que calcula la suma de los elementos en la profundidad p
        private int sumaRec(ArbolBinario<int> nodo, int p, int nivelActual)
        {
            if (nodo == null)
                return 0;

            if (nivelActual == p)
                return nodo.getDatoRaiz();

            return sumaRec(nodo.getHijoIzquierdo(), p, nivelActual + 1)
                 + sumaRec(nodo.getHijoDerecho(), p, nivelActual + 1);
        }
    }
}
