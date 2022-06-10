using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program6
    {
        private int positivos, negativos, neutros;
        private int[] sumatoria = { 0, 0 };
        private int[] numeros;

        public int[] getSumatoria()
        {
            return sumatoria;
        }

        public void setSumatoria(int[] sumatoria)
        {
            this.sumatoria = sumatoria;
        }

        public int getPositivos()
        {
            return positivos;
        }

        public void setPositivos(int positivos)
        {
            this.positivos = positivos;
        }

        public int getNegativos()
        {
            return negativos;
        }

        public void setNegativos(int negativos)
        {
            this.negativos = negativos;
        }

        public int getNeutros()
        {
            return neutros;
        }

        public void setNeutros(int neutros)
        {
            this.neutros = neutros;
        }

        public int[] getNumeros()
        {
            return numeros;
        }

        public void setNumeros(int[] numeros)
        {
            this.numeros = numeros;
        }

        public void operaciones()
        {

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= 1)
                {
                    positivos++;
                    sumatoria[0] += numeros[i];
                }
                else if (numeros[i] <= -1)
                {
                    negativos++;
                    sumatoria[1] += numeros[i];
                }
                else if (numeros[i] == 0)
                {
                    neutros++;
                }
            }
        }

        public void operar(int[] arr)
        {
            setNumeros(arr);
            operaciones();
            getPositivos();
            getNegativos();
            getNeutros();

            int[] a = { getPositivos(), getNegativos(), getNeutros(), getSumatoria()[0], getSumatoria()[1] };
            printAnswer(a);

        }

        public static void printAnswer(int[] res)
        {
            Console.WriteLine("<<<<<<<<<>>>>>>>>>>>>>");
            Console.WriteLine("positivos: " + res[0]);
            Console.WriteLine("negativos: " + res[1]);
            Console.WriteLine("neutros: " + res[2]);
            Console.WriteLine("Sumatoria de numeros positivos: " + res[3]);
            Console.WriteLine("Sumatoria de numeros negativos: " + res[4]);
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>");
        }

        public void fun()
        {

            Console.WriteLine("cuantos numeros quiere introducir ");
            int n = int.Parse(Console.ReadLine()); ;
            int[] numeros = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Format("Introduzca el numero[{0}]:", (i + 1)));
                numeros[i] = int.Parse(Console.ReadLine()); ;
            }
            operar(numeros);

        }

    }

}
