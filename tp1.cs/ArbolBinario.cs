using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    //Creo la clase ArbolBinario
    public class ArbolBinario<T>
    {
        private T dato;

        //Referencia a los hijos izquierdo y derecho
        private ArbolBinario<T>? hijoIzquierdo; // Permitir valores NULL
        private ArbolBinario<T>? hijoDerecho;   // Permitir valores NULL

        //Inicializo el nodo con ese dato. Constructor
        public ArbolBinario(T dato)
        {
            this.dato = dato;
        }

        //Getters/setters de hijos
        public T getDatoRaiz()
        {
            return this.dato;
        }

        public ArbolBinario<T>? getHijoIzquierdo()
        {
            return this.hijoIzquierdo;
        }

        public ArbolBinario<T>? getHijoDerecho()
        {
            return this.hijoDerecho;
        }

        public void agregarHijoIzquierdo(ArbolBinario<T> hijo)
        {
            this.hijoIzquierdo = hijo;
        }

        public void agregarHijoDerecho(ArbolBinario<T> hijo)
        {
            this.hijoDerecho = hijo;
        }

        public void eliminarHijoIzquierdo()
        {
            this.hijoIzquierdo = null;
        }

        public void eliminarHijoDerecho()
        {
            this.hijoDerecho = null;
        }

        //Creo un booleano para saber si es una hoja, es "true" si no tiene hijos.
        public bool esHoja() 
        { 
            return this.hijoIzquierdo == null && this.hijoDerecho == null; 
        }
    }
}
