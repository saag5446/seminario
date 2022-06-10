using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program1
    {
        public void fun()
        {
            string continuar;
            int opcion=1;
            int numero1, numero2=0, operacion = 0;
            do
            {


                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Semillero de programacion en .Net y SQL sERVER");
                Console.WriteLine("Aplicacion1. Operaciones Matematicas");
                Console.WriteLine("Dijite el Primer Numero");
                numero1 = int.Parse(Console.ReadLine());
                while (numero2 == 0)
                {
                    Console.WriteLine("Dijite el Segundo Numero");
                    Console.WriteLine("Dijite nuevamente el Numero2");
                    numero2 = int.Parse(Console.ReadLine());
                }
                while (opcion <= 0 || opcion >= 6)
                {
                    Console.WriteLine("Operaciones");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Producto");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Residuo");
                    Console.WriteLine("Seleccione la operacion");
                    opcion = int.Parse(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        operacion = numero1 + numero2;
                        break;
                    case 2:
                        operacion = numero1 - numero2;
                        break;
                    case 3:
                        operacion = numero1 * numero2;
                        break;
                    case 4:
                        operacion = numero1 / numero2;
                        break;
                    case 5:
                        operacion = numero1 % numero2;
                        break;
                    default:
                        Console.WriteLine("No Selecciono una operacion valida");
                        break;
                }

                Console.WriteLine("*******************************");
                Console.WriteLine("*****Numero 1 =" + numero1 + "*****");
                Console.WriteLine("*****Numero 2 =" + numero2 + "*****");
                Console.WriteLine("*****Resultado =" + operacion + "*****");

                Console.WriteLine("Desea repetir el programa de operaciones Matematicas s/n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu porincipal");
                continuar = Console.ReadLine();
            } while (continuar == "S" || continuar == "s");
        }

    }
}





