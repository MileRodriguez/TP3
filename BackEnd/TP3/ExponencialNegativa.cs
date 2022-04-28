using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class ExponencialNegativa : Dist
    {
        private double lambda;
        private double[] numeritos;

        public void set(double lambda, double[] numeritos)
        {
            this.lambda = lambda;
            this.numeritos = numeritos;
        }

        public override void chiCuadrado(int muestra, double[] numeritos, int cantidadIntervalos, DataGridView tabla)
        {

            double min = numeritos.Min();
            double max = numeritos.Max();

            double paso = ((max - min) / cantidadIntervalos);
            double fe = 0;
            double fo = 0;
            double limInf = 0;
            double limSup = 0;
            double chi = 0;
            double chiA = 0;


            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();


                limInf = min + (paso * i);
                limSup = min + (paso * i + 1);
                fo = numeritos.Count(numerito => limInf <= numerito && numerito < limSup);
                fe = ((1 - Math.Pow(Math.E, (-lambda * limSup))) - (1 - Math.Pow(Math.E, (-lambda*limInf))))*numeritos.Length;
                chi = Math.Pow((fe - fo), 2) / fe;
                chiA = chiA + chi;

                Object[] cells = { i, limInf, limSup, fo, fe, chi, chiA };

                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);

            }

            estadisticoPrueba = chiA;
        }

    }
}
