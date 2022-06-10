using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program8
    {

        private double expoN[];

        private void exponente()
        {
            expoN = new double[(int)(n + 1)];
            for (int i = 1; i <= n; i++)
                expoN[i] = Math.pow(x, i);
        }

        private double resFacs[];

        private void factorial()
        {
            resFacs = new double[(int)(n + 1)];
            resFacs[0] = 1;
            for (int i = 1; i <= n; i++)
                resFacs[i] = resFacs[i - 1] * i;
        }

        public void operaciones()
        {
            exponente();
            factorial();
            setProduccion_gallinas(1 + x);
            for (int i = 2; i <= n; i++)
                produccion_gallinas += expoN[i] / resFacs[i];
        }

        public void fun()
        {
            Console.WriteLine("Ingrese el numero de gallinas:");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de dias:");
            double n = Double.Parse(Console.ReadLine());
        }
    }
}
