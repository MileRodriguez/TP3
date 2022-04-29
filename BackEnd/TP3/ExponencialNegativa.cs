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

        public double[] getNumeritos()
        {
            return this.numeritos;
        }

        public override void chiCuadrado(int muestra, int cantidadIntervalos, DataGridView tabla)
        {

            double min = numeritos.Min();
            double max = numeritos.Max();

            double paso = ((max - min) / cantidadIntervalos);
            double fe = 0;
            double fo = 0;
            double limInf = 0;
            double limSup = 0;
      


            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                tabla.ColumnCount = 5;

                tabla.Columns[0].Name = "Iteracion";
                tabla.Columns[1].Name = "Limite Inferior";
                tabla.Columns[2].Name = "Limite Superior";
                tabla.Columns[3].Name = "Frecuencia Observada";
                tabla.Columns[4].Name = "Frecuencia Esperada";

                limInf = min + (paso * i);
                limSup = min + (paso * (i + 1));
                fo = numeritos.Count(numerito => limInf <= numerito && numerito < limSup);
                fe = Math.Round(((1 - Math.Pow(Math.E, (-lambda * limSup))) - (1 - Math.Pow(Math.E, (-lambda*limInf))))*numeritos.Length, 4);

                Object[] cells = { i, limInf, limSup, fo, fe};

                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);

            }
        }

        public override void chiCuadradoRedux(DataGridView tabla, DataGridView tablaRedux)
        {
            double fe = 0;
            double fo = 0;
            double limInf = 0;
            double limSup = 0;
            double chi = 0;
            double chiA = 0;
            int count = 1;
            bool cambiarLim = false;
            double previous_fe = 0;
            double previous_fo = 0;
            double previous_chi = 0;
            double previous_limInf = 0;

            tablaRedux.ColumnCount = 7;

            tablaRedux.Columns[0].Name = "Intervalo";
            tablaRedux.Columns[1].Name = "Limite Inferior";
            tablaRedux.Columns[2].Name = "Limite Superior";
            tablaRedux.Columns[3].Name = "Frecuencia Observada";
            tablaRedux.Columns[4].Name = "Frecuencia Esperada";
            tablaRedux.Columns[5].Name = "Chi";
            tablaRedux.Columns[6].Name = "Chi Acumulado";

            limInf = double.Parse(tabla.Rows[0].Cells[1].Value.ToString());

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (cambiarLim)
                {
                    previous_limInf = limInf;
                    limInf = double.Parse(tabla.Rows[i].Cells[1].Value.ToString());
                    cambiarLim = false;
                }
                fe += double.Parse(tabla.Rows[i].Cells[4].Value.ToString());
                fo += int.Parse(tabla.Rows[i].Cells[3].Value.ToString());
                if (fe > 5 || i == tabla.Rows.Count - 1)
                {
                    if (i == tabla.Rows.Count - 1 && fe < 5)
                    {
                        limInf = previous_limInf;
                        limSup = double.Parse(tabla.Rows[i].Cells[2].Value.ToString());
                        fe += previous_fe;
                        fo += previous_fo;
                        chiA -= previous_chi;
                        chi = (Math.Pow((fe - fo), 2)) / fe;
                        chiA += chi;
                        tablaRedux.Rows[tablaRedux.Rows.Count - 1].SetValues(count - 1, limInf, limSup, fo, fe, chi, chiA);
                    }
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        limSup = double.Parse(tabla.Rows[i].Cells[2].Value.ToString());
                        chi = (Math.Pow((fe - fo), 2)) / fe;
                        chiA += chi;
                        Object[] cells = { count, limInf, limSup, fo, fe, chi, chiA };
                        count++;
                        previous_fe = fe;
                        previous_fo = fo;
                        previous_chi = chi;
                        fo = fe = 0;
                        cambiarLim = true;
                        row.CreateCells(tablaRedux, cells);
                        tablaRedux.Rows.Add(row);
                    }
                }
            }
            estadisticoPrueba = chiA;
        }

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }

    }
}
