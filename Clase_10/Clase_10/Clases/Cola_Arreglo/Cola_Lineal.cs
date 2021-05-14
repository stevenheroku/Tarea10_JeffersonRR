using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10.Clases.Cola_Arreglo
{
    class Cola_Lineal
    {
        protected int fin;
        private static int MAXIMAQ = 39;
        protected int frente;

        protected Object[] listaCola;


        public Cola_Lineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXIMAQ];
        }


        public void insertar(Object elemento)
        {
            if(!Cola_Llena())
            {
                listaCola[++fin] = elemento;
                
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //retorna si esta vacia
        public bool Cola_Vacia()
        {
            return frente > fin;
        }
        //detecta cola si esta llena
        public bool Cola_Llena()
        {
           if(fin == MAXIMAQ -1)
            {
                return true;
            }
            return false;
        }

        //quitar elementos
        public Object quitar()
        {
            if(!Cola_Vacia())
            {
                return listaCola[frente++];
                //      
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }

        //limpiamos la cola
        public void LimpiarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object FrenteCola()
        {
            if(!Cola_Vacia())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }
    }//end class
}
