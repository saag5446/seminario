using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programs
{
    public class Program5
    {
        public void fun()
        {
            int cantDias, dia;
            double maxima, minima;


            Console.WriteLine("¿De cuántos días desea ingresar temperaturas?: ");
            cantDias = int.Parse(Console.ReadLine());

            Temperatura[] listaTemp = new Temperatura[cantDias];
            Temperatura t = new Temperatura();

            for (int i = 0; i < cantDias; i++)
            {

                dia = i + 1;
                Console.WriteLine("\n\nIngrese las temperaturas del día " + (i + 1));
                Console.WriteLine("Máxima: ");
                maxima = double.Parse(Console.ReadLine());
                Console.WriteLine("Mínima: ");
                minima = double.Parse(Console.ReadLine());

                listaTemp[i] = new Temperatura(dia, maxima, minima);
            }

            t.setListaTemp(listaTemp);

            Console.WriteLine("\n\n============================ Registro de temperaturas ============================");

            for (int i = 0; i < cantDias; i++)
            {
                Console.WriteLine("" + t.getListaTemp()[i]);
            }

            t.mostrarResultados();

        }

        public class Temperatura
        {

            private double minimo, maximo;
            private int dia;

            Temperatura[] listaTemp;

            public Temperatura()
            {
            }

            public Temperatura(int dia, double maximo, double minimo)
            {
                this.dia = dia;
                this.minimo = minimo;
                this.maximo = maximo;
            }

            public double getMinimo()
            {
                return minimo;
            }

            public void setMinimo(double minimo)
            {
                this.minimo = minimo;
            }

            public double getMaximo()
            {
                return maximo;
            }

            public void setMaximo(double maximo)
            {
                this.maximo = maximo;
            }

            public int getDia()
            {
                return dia;
            }

            public void setDia(int dia)
            {
                this.dia = dia;
            }

            public Temperatura[] getListaTemp()
            {
                return listaTemp;
            }

            public void setListaTemp(Temperatura[] listaTemp)
            {
                this.listaTemp = listaTemp;
            }


            public override string ToString()
            {
                return "Temperatura{" + "dia=" + dia + ", minimo=" + minimo + ", maximo=" + maximo + '}';
            }

            public void mostrarResultados()
            {
                int contSinInfo = 0, contMax = 0, contMin = 0, contError = 0, c;
                double sumMax = 0.0, sumMin = 0.0, porcentajeErrores = 0.0, promMax = 0.0, promMin = 0.0;

                foreach (Temperatura T in listaTemp)
                {
                    if (T.getMaximo() == 0 & T.getMinimo() == 0)
                    {
                        contSinInfo++;
                    }

                    if (T.getMaximo() == 9 || T.getMinimo() == 9)
                    {
                        contError++;
                    }

                    sumMax += T.getMaximo();
                    sumMin += T.getMinimo();
                    contMax++;
                    contMin++;
                }

                promMax = sumMax / (contMax - contSinInfo);
                promMin = sumMin / (contMin - contSinInfo);

                Console.WriteLine("\nCantidad de días sin registro: " + contSinInfo);
                Console.WriteLine("Promedio temperaturas máximas: " + promMax);
                Console.WriteLine("Promedio temperaturas mínimas: " + promMin);
                Console.WriteLine("Cantidad de errores: " + contError);
                Console.WriteLine("Porcentaje de error: " + (contError * 1.00 / listaTemp.Length) * 100 + "%");

            }

        }

    }
}
