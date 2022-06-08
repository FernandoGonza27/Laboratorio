using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string opcionMenu = "";
                mostrarIndicaciones();

                mostrarMenuJuegoVectores();
                opcionMenu = Console.ReadLine();

                do {
                    if (opcionMenu=="1")
                    {
                        sumarArreglo();
                    }
                    else if (opcionMenu == "2") 
                    {
                        ordenarArreglo();
                    }
                    else if (opcionMenu == "3") 
                    {
                        mostrarTrianguloPascal();
                    }

                    else if (opcionMenu == "4") 
                    {
                        mostarFibonacii();
                    }
                    
                } while (opcionMenu != "5");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void mostrarMenuJuegoVectores() 
        {
            string menu = "***** JUEGO DE VECTORES *****" + Environment.NewLine+
                         "1.Suma Especial." + Environment.NewLine +
                         "2.Ordenar Arreglos." + Environment.NewLine +
                         "3.Crear Triángulo de Pascal." + Environment.NewLine +
                         "4.Serie de Fibbonacci." + Environment.NewLine +
                         "5.Salir" + Environment.NewLine;
            Console.WriteLine(menu);
        }

        public static void mostrarIndicaciones()
        {
            string indicaciones = "--Bienvenidos al juego de vectores, en el podran realizar cada una de las opciones que se muestren--" + Environment.NewLine +
                         "Este programa como tal solo va realizar funciones solicitadas por el laboratorio." + Environment.NewLine+
                         "Esperamos que te seamos de ayuda " + Environment.NewLine;
            Console.WriteLine(indicaciones);
        }

        public static void sumarArreglo() {
            Console.Clear();
            int[] arregloParaSuma = new int[5];
            double resultado = 0;
            for (int i = 0; i< arregloParaSuma.Length; i++)
            {
                Console.WriteLine("Dijite un numero al azar ");
                arregloParaSuma[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Arreglo por sumar");
            foreach (int valor in arregloParaSuma)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine(Environment.NewLine);

            for (int i = 0; i < arregloParaSuma.Length; i++)
            {                
                
                resultado += Math.Pow(arregloParaSuma[i],i);

            }
            Console.WriteLine("Suma del arreglo");
            Console.WriteLine(resultado);

        }

        public static void ordenarArreglo()
        {
            Console.Clear();
            int[] arregloOrden = new int[5];
            int vueltas = 0;
            for (int i = 0; i < arregloOrden.Length; i++)
            {
                Console.WriteLine("Dijite un numero al azar ");
                arregloOrden[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Arreglo sin ordenar");
            foreach (int value in arregloOrden)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(Environment.NewLine);
            for (int i=0; i < arregloOrden.Length - 1; i++)
            { 
                    int posicion =i;
                    for (int numero=posicion + 1; numero < arregloOrden.Length; numero++) 
                    {
                        if (arregloOrden[numero] < arregloOrden[posicion])
                        {
                            posicion = numero;
                        }
                    }

                    if (posicion != i)
                    {
                        int auxiliar = arregloOrden[i];
                        arregloOrden[i] = arregloOrden[posicion];
                        arregloOrden[posicion] = auxiliar;
                        
                    }
                   
                    vueltas ++;
            }
            Console.WriteLine("Arreglo ordenado");
            foreach (int valor in arregloOrden)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("El arreglo se tuve que recorrer: "+vueltas+" veces para ser ordenado"+Environment.NewLine);

        }

        public static void mostrarTrianguloPascal() 
        {
            int i = 0;
            int Count = 0;
            int cantidadDeLineas = 0;
            int Columna = 0;
            int Fila = 0;

            Console.Clear();
            Console.Write("De cuantas filas desea que se el triangulo de pascal : ");
            cantidadDeLineas = int.Parse(Console.ReadLine());

            int[,]  triangulo= new int[cantidadDeLineas + 1, cantidadDeLineas + 1];

            for (i = 1; i <= cantidadDeLineas; i++)
            {
                for (Count = 1; Count <= cantidadDeLineas; Count++)
                {
                    if ((Count == 1) | (i == Count))
                    {
                        triangulo[i, Count] = 1;
                    }
                    else
                    {
                        triangulo[i, Count] = triangulo[i - 1, Count] + triangulo[i - 1, Count - 1];
                    }
                }
            }

            for (i = 1; i <= cantidadDeLineas; i++)
            {
                Columna = 40 - (i * 2);
                for (Count = 1; Count <= cantidadDeLineas; Count++)
                {
                    if (triangulo[i, Count] != 0)
                    {
                        Console.SetCursorPosition(Columna, Fila);
                        Console.Write(triangulo[i, Count]);
                        Columna = Columna + 4;
                    }
                }
                Fila = Fila + 1;
                Console.WriteLine();
            }


        }
        public static void mostarFibonacii()
        {
            int tamanoSerie = 0;
            Console.WriteLine("ingrese el tamaño de la serie fibonaci que quiere ver");
            tamanoSerie = int.Parse(Console.ReadLine());
            for (int i = 0; i < tamanoSerie; i++)
            {
                Console.Write(fibonacci(i) + " ");
            }
        }
        int fibonacci(int n)
        {
            if (n > 1)
            {
                return fibonacci(n - 1) + fibonacci(n - 2);  //función recursiva
            }
            else if (n == 1)
            {  // caso base
                return 1;
            }
            else if (n == 0)
            {  // caso base
                return 0;
            }
            else
            { //error
                Console.WriteLine("Debes ingresar un tamaño mayor o igual a 1");
                return -1;
            }
        }

    }
}
