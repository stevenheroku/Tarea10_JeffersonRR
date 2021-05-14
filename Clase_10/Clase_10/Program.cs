using Clase_10.Clases.Cola_Arreglo;
using Clase_10.Clases.Pilas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10
{
    class Program
    {

        private static bool valido(string numero)
        {
            bool sw = true;
            int i = 0;
            while(sw && (i<numero.Length))
            {
                Char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        static void EnClase()
        {
            bool capicua;
            string numero;
            PilaLista pila = new PilaLista();
            Cola_Circular cola = new Cola_Circular();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("INGRESE UN NUMERO");
                        numero = Console.ReadLine();
                    } while (!valido(numero));

                    //pone en la cola y en la pila cada digito

                    for (int i = 0; i < numero.Length; i++)
                    {
                        Char c;
                        c = numero[i];
                        cola.insertar(c);
                        pila.insertar(c);
                    }
                    int pausa = 0;

                    //se retira de la cola

                    do
                    {
                        Char d;
                        d = (char)cola.quitar();
                        //capicua = d.Equals(cola.quitar());
                         capicua = d.Equals(pila.quitar());//compara igualdad
                    } while (capicua && !cola.Cola_Vacia() /*&& !pila.PilaVacia()*/);

                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua0");
                    }
                    else
                    {
                        Console.WriteLine("el numero no es Capicua");
                    }


                    //vaciar estrucutras

                    cola.BorrarCola();
                    //pila.limpiar();
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("error" + e);
            }
        }



        //metodo tarea 10
        static Queue queue1 = new Queue();
        static Stack snack1 = new Stack();

        static void tarea10()
        {
            bool capicua;
            string numero;
            
            //Queue qt = new Queue();

            capicua = false;
            while (!capicua)
            {
                do
                {
                    Console.WriteLine("INGRESE UN NUMERO PARA COMPROBAR SI ES CAPICUA O NO ");
                    numero = Console.ReadLine();

                } while (!valido(numero));

                for (int i = 0; i < numero.Length; i++)
                {
                    Char c;
                    c = numero[i];
                    queue1.Enqueue(c);
                    snack1.Push(c);
                    //pila.insertar(c);
                }
                int pausa = 0;

                //se retira de la cola

                do
                {
                    Char d;
                    d = (char)queue1.Dequeue();
                     capicua = d.Equals(snack1.Peek());//compara igualdad
                    snack1.Pop();
                } while (capicua && queue1.Count!=0);

                if (capicua)
                {
                    Console.WriteLine($"EL NUMERO {numero} SI ES CAPICUA!");
                }
                else
                {
                    Console.WriteLine($"EL NUMERO {numero} !NO ES CAPICUA!");
                }

            }
            queue1.Clear();
            snack1.Clear();
        }

        static void Main(string[] args)//colas
        {


            tarea10();



            Console.ReadKey();
        }
    }
}
