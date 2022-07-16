using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int modelo_a = 5, modelo_b = 8, modelo_c = 6, horas, minutos, total_minutos;
            string modelo;
            do
            {
                Console.WriteLine("Duración representado en minutos.");
                Console.WriteLine("Modelo salón a = 5, Modelo salón b = 8, Modelo salón c = 6.");
                Console.WriteLine("Ingrese el modelo del salón (a,b,c) x para salir:");
                modelo = Console.ReadLine();
                switch (modelo)
                {
                    case "a":
                        Console.WriteLine("Ingrese la cantidad de examenes a revisar:");
                        total_minutos = int.Parse(Console.ReadLine()) * modelo_a;
                        horas = total_minutos / 60;
                        minutos = total_minutos % 60;
                        Tiempo_total(horas, minutos);
                        break;
                    case "b":
                        Console.WriteLine("Ingrese la cantidad de examenes a revisar:");
                        total_minutos = int.Parse(Console.ReadLine()) * modelo_b;
                        horas = total_minutos / 60;
                        minutos = total_minutos % 60;
                        Tiempo_total(horas, minutos);
                        break;
                    case "c":
                        Console.WriteLine("Ingrese la cantidad de examenes a revisar:");
                        total_minutos = int.Parse(Console.ReadLine()) * modelo_c;
                        horas = total_minutos / 60;
                        minutos = total_minutos % 60;
                        Tiempo_total(horas, minutos);
                        break;
                    default:
                        Console.WriteLine("Elección incorrecta.");
                        Console.WriteLine();
                        break;
                }
            } while (modelo != "x");
        }
        public static void Tiempo_total(int horas, int minutos)
        {
            Console.WriteLine("El tiempo total sería: " + horas + " hora(s) : " + minutos + " minuto(s).");
            Console.WriteLine();
        }
    }
}