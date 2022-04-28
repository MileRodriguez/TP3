using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class Uniforme : Dist
    {
        private double[] numeritos;
        private int intervalos;

        public void set(double[] numeritos, int intervalos)
        {
            this.numeritos = numeritos;
            this.intervalos = intervalos;
        }

        public double[] getNumeritos()
        {
            return this.numeritos;
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
                tabla.ColumnCount = 7;

                tabla.Columns[0].Name = "Iteracion";
                tabla.Columns[1].Name = "Limite Inferior";
                tabla.Columns[2].Name = "Limite Superior";
                tabla.Columns[3].Name = "Frecuencia Observada";
                tabla.Columns[4].Name = "Frecuencia Esperada";
                tabla.Columns[5].Name = "Chi";
                tabla.Columns[6].Name = "Chi Acumulado";

                limInf = min + (paso * i);
                limSup = min + (paso * (i + 1));
                fo = numeritos.Count(numerito => limInf <= numerito && numerito < limSup);
                fe = numeritos.Length / intervalos;
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
