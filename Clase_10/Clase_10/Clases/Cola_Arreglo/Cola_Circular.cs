using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Clases.Cola_Arreglo
{
    class Cola_Circular
    {
        private static int fin;
        private static int MAXIAMQ = 99;
        protected int frente;

        protected Object[] listaCola;

        //avanza a una posicion
        private int siguiente(int n)
        {
            return (n + 1) % MAXIAMQ;
        }

        //constructor
        public Cola_Circular()
        {
            frente = 0;
            fin = MAXIAMQ - 1;
            listaCola = new Object[MAXIAMQ];
        }

        //validaciones
        public bool Cola_Vacia()
        {
            return frente == siguiente(fin);
        }
        //detecta cola si esta llena
        public bool Cola_Llena()
        {
            return fin == siguiente(siguiente(fin));
        }


        //operaciones modificacion de cola
        //inserta

        public void insertar(Object elemento)
        {
            if(!Cola_Llena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elemento

        public Object quitar()
        {
            if (!Cola_Vacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiar cola

        public void BorrarCola()
        {
            frente = 0;
            fin = MAXIAMQ - 1;
            listaCola = new Object[MAXIAMQ];
        }


        //detener el valor de frente

        public Object frenteCola()
        {
            if(!Cola_Vacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

   



    }
}
