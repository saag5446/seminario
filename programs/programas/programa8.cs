using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program8
    {
        private double n, x, produccion_gallinas;

        private double[] expon;

        private void exponente()
        {
            expon = new double[(int)(this.n + 1)];
            for (int i = 1; i <= this.n; i++)
                expon[i] = Math.Pow(x, i);
        }

        private double[] resultFacts;

        private void factorial()
        {
            resultFacts = new double[(int)(n + 1)];
            resultFacts[0] = 1;
            for (int i = 1; i <= this.n; i++)
                resultFacts[i] = resultFacts[i - 1] * i;
        }

        public void operaciones()
        {
            exponente();
            factorial();
            this.produccion_gallinas = 1 + this.x;
            for (int i = 2; i <= this.n; i++)
                this.produccion_gallinas += expon[i] / resultFacts[i];
        }

        public void fun()
        {
            Console.WriteLine("Ingrese el numero de gallinas:");
            this.x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de dias:");
            this.n = Double.Parse(Console.ReadLine());
            operaciones();
            int var;

            Console.WriteLine("*********************************");
            Console.WriteLine("*****Resultado Final: " + this.produccion_gallinas + "*****");

        }

    }

}
