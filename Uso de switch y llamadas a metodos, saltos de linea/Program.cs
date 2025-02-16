﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Uso_de_switch_y_llamadas_a_metodos__saltos_de_linea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Promedio Notas");
                Console.WriteLine("2. Promedio Serie Numeros");
                Console.WriteLine("3. Clasificacion edad");
                Console.WriteLine("4. salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        promedio();
                        break;
                    case 2:
                        promedioSerie();
                        break;
                    case 3:
                        clasificacionEdad();
                        break;
                    case 4:
                        continuar = "n";
                        break;
                    default: //else
                        Console.WriteLine("Opcion Incorrecta \n\n");
                        break;
                }
            }
        }
        

        static void promedio()
        {
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine());//8
            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine());//9
            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine());//7

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.Write("La nota de C1 es: {0}", c1);

            Console.Write("Lab1: ");
            lab1 = double.Parse(Console.ReadLine());//8

            Console.Write("Lab2: ");
            lab2 = double.Parse(Console.ReadLine());//9

            Console.Write("Parcial1: ");
            parcial1 = double.Parse(Console.ReadLine());//7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de C2 es: {0} ", c2);
        }
        static void promedioSerie()
        { // prioridad de los operadores aritmeticos
            // ejercicio de obtener el promedio de una serie de numeros

            int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
            int suma = 0;
            foreach (int num in serie)
            {
                suma += num;

            }
            decimal prom = suma / serie.Length; //6
            Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);
        }
        static void clasificacionEdad()
        {
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un Bebe");
                }
                else if (edad < 12)
                {
                    Console.WriteLine("Eres un Niño");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un Adolecente");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las responsabilidades");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Larga Vida");
                }
                Console.Write("Desea continuar presione s, sino cualquier tecla.");
                continuar = Console.ReadLine();
            }
        }
    }
    
    

    }



    

