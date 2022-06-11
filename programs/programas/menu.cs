using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Menu
    {
        public static void Inicio()
        {
            string continuar;
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Universidad Ecci");
                Console.WriteLine("Semillero de programacion en .Net y SQL sERVER");
                Console.WriteLine("Aplicaciones Tipo Consola");
                Console.WriteLine("1. Operaciones Matematicas ");
                Console.WriteLine("2. Funciones Matematicas ");
                Console.WriteLine("3. Validador de Respuestas");
                Console.WriteLine("4. Salario Semanal de un Operario");
                Console.WriteLine("5. Estacion Climatica");
                Console.WriteLine("6. Categorizador de Numeros");
                Console.WriteLine("7. Estadistica de Pesos");
                Console.WriteLine("8. Produccion Avicola");
                Console.WriteLine("9. Sistema de Calificaciones");
                Console.WriteLine("10. Nomina de Empleados");

                opcion = int.Parse(Console.ReadLine());

                //Implementacion del swich
                switch (opcion)
                {
                    case 1:
                        Program1 p1 = new Program1();
                        p1.fun();
                        break;  

                    case 4:
                        Program4 p4= new Program4();
                        p4.fun();
                        break;
                
                    case 5:
                        Program5 p5= new Program5();
                        p5.fun();
                        break;

                    case 6:
                        Program6 p6= new Program6();
                        p6.fun();
                        break;

                    case 7:
                        Program7 p7= new Program7();
                        p7.fun();
                        break;

                    case 8:
                        Program8 p8= new Program8();
                        p8.fun();
                        break;
                        

                }
                Console.WriteLine("Desea repetir el programa de operaciones Matematicas s/n");
                Console.WriteLine("En caso de seleccionar n el programa vuelve al menu porincipal");
                continuar = Console.ReadLine();
            } while (continuar == "S" || continuar == "s");

            /*if(opcion==1)
            {
                Programa1 m=new Programa1();
                m.programas();
            }
            if(opcion==2)
            {
                Programa2 n=new Programa2();
                n.programas();
            }*/
        }
    }
}
