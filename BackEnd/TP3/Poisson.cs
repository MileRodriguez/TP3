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


        public void set(double lambda)
        {
            this.lambda = lambda;
        }

        public override void chiCuadrado(int muestra, double[] numeritos, int eventos, DataGridView tabla)
        {

            double chi = 0;
            double chiA = 0;


            for (int i = 0; i < eventos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

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
