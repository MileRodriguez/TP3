using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class Poisson : Dist
    {
        private double lambda;
        private int[] numeritos;


        public void set(int[] numeritos, double lambda)
        {
            this.numeritos = numeritos;
            this.lambda = lambda;
        }
        public int[] getNumeritos()
        {
            return this.numeritos;
        }
        public override void chiCuadrado(int muestra, int eventos, DataGridView tabla)
        {

            double chi = 0;
            double chiA = 0;


            for (int i = 0; i < eventos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                tabla.ColumnCount = 4;

                tabla.Columns[0].Name = "Evento";
                tabla.Columns[1].Name = "Frecuencia Esperada";
                tabla.Columns[2].Name = "Chi";
                tabla.Columns[3].Name = "Chi Acumulado";

                double prob = (Math.Pow(Math.E, -lambda) * Math.Pow(lambda, i)) / factorial(i);
                double fe = prob * muestra;
                chi = Math.Pow((fe - numeritos.Length), 2) / fe;
                chiA = chiA + chi;

                Object[] cells = {i, fe, chi, chiA };

                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);

            }
            estadisticoPrueba = chiA;

        }

        private double factorial(double number)
        {
            int i, fact = 1;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
