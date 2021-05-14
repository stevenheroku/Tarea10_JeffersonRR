using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Clases.Pilas
{
    class PilaLista
    {
        private static int INCIAL = 19;
        private int cima;
        private List<Object> listaPila;

        public PilaLista()
        {
            cima = -1;
            listaPila = new List<object>();
        }

        public void insertar(Object elemento)
        {

            
            listaPila.Add(elemento);
            cima++;
        }

        public Object quitar()
        {
            Object aux;
            if (PilaVacia())
            {
                throw new Exception("PILA VACIA");
            }
            aux = listaPila[cima];
            listaPila.RemoveAt(cima);
            cima--;
            return aux;
        }

        public Object cimaPila()
        {
            if(!PilaVacia())
            {
                throw new Exception("PILA VACIA, NO SE PUEDE SACAR ELEMENTO");
            }
            return listaPila[cima];
        }

        public void limpiar()
        {
            while(!PilaVacia())
            {
                quitar();
            }

        }

        public bool PilaVacia()
        {
            return cima == -1;
        }

    }//end class
}
