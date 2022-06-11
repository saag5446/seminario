using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program4
    {
        public void fun() 
        {
            int promedio, lunes, martes, miercoles, jueves, viernes, sabado, domingo;
            float sueldo = 0, incentivo = 0, sueld = 0;

            Console.WriteLine("Cuanto Fue La produccion Para El Lunes");
            lunes = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Martes");
            martes = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Miercoles");
            miercoles = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Jueves");
            jueves = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Viernes");
            viernes = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Sabado");
            sabado = int.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto Fue La produccion Para El Domingo");
            domingo = int.Parse(Console.ReadLine());

            promedio = (lunes + martes + miercoles + jueves + viernes + sabado + domingo) / 7;

            if (promedio >= 0 && promedio < 100)
            {
                sueldo = promedio * 2;
                Console.WriteLine("El sueldo Seria = " + sueldo);

            }


            if (promedio >= 100 && promedio < 200)
            {
                sueldo = promedio * 2;
                incentivo = sueldo * 10 / 100;
                sueld = sueldo + incentivo;
                Console.WriteLine("El sueldo Seria = " + sueld);
            }


            if (promedio >= 200 && promedio < 300)
            {
                sueldo = (float)(promedio * 2.5);
                incentivo = sueldo * 12 / 100;
                sueld = sueldo + incentivo;
                Console.WriteLine("El sueldo Seria = " + sueld);

            }

            if (promedio >= 300 && promedio < 400)
            {
                sueldo = promedio * 3;
                incentivo = sueldo * 14 / 100;
                sueld = sueldo + incentivo;
                Console.WriteLine("El sueldo Seria = " + sueld);
            }

            if (promedio >= 400)
            {
                sueldo = (float)(promedio * 3.5);
                incentivo = sueldo * 16 / 100;
                sueld = sueldo + incentivo;
                Console.WriteLine("El sueldo Seria = " + sueld);
            }

        }
    }
}