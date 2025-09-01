using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do 
            {
                Console.WriteLine("Menu de opciones:"+ "\n1.EjPRACTICA"+ "\n2.Ejercicio1" + "\n3.Ejercicio2" + "\n4.Ejercicio3" + "\n5.Ejercicio4" + "\n6.Ejercicio5" + "\n7.Ejercicio6" + "\n8.Ejercicio7");
                Console.WriteLine("0.Salir");
                    opcion =int.Parse(Console.ReadLine());
                switch (opcion) 
                {
                    case 1:EjPRACTICA();break; case 2:Ej1();break;
                    case 3: Ej2(); break;case 4:Ej3();break;
                    case 5: Ej4(); break;case 6:Ej5();break;
                    case 7: Ej6(); break; case 8:Ej7();break;
                        default: Console.WriteLine("Opcion no valida , SALIENDO......"); break;
                }
                if (opcion != 0)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion!=0);

        }
        static void EjPRACTICA() 
        {

            Console.WriteLine("Ingrese lado A");
            double ladoA = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado B");
            double ladoB = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado C");
            double ladoC = double.Parse(Console.ReadLine());
            double S=(ladoA + ladoB + ladoC) / 2;
            double Area=Math.Sqrt(S*(S-ladoA)*(S-ladoB)*(S-ladoC));
            Console.WriteLine("El area del triangulo es: " + Area);
            Console.ReadKey();
        }
        static void Ej1()
        { 
            Console.WriteLine("Ingrese un numero1");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero2");
            int numero2 = int.Parse(Console.ReadLine());
            int suma = numero1 + numero2;
            Console.WriteLine("La suma es: " + suma);
            Console.ReadKey();
        }
        static void Ej2() { }
        static void Ej3() { }
        static void Ej4() { }
        static void Ej5() { }
        static void Ej6() { }
        static void Ej7() { }


    }
}
