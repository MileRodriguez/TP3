using System;
using System.Linq;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class ExponencialNegativa : Dist
    {
        private double lambda;

        public void setLambda(double lambda)
        {
            this.lambda = lambda;
        }

        public double getLambda()
        {
            return lambda;
        }

        public override void chiCuadrado(int cantidadIntervalos, DataGridView tabla)
        {

            double min = numeros.Min();
            double max = numeros.Max();

            double paso = ((max - min) / cantidadIntervalos);
            double fe = 0;
            double fo = 0;
            double limInf = 0;
            double limSup = 0;

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                tabla.ColumnCount = 5;

                tabla.Columns[0].Name = "Intervalo";
                tabla.Columns[1].Name = "Limite Inferior";
                tabla.Columns[2].Name = "Limite Superior";
                tabla.Columns[3].Name = "Frecuencia Observada";
                tabla.Columns[4].Name = "Frecuencia Esperada";

                limInf = Math.Round(min + (paso * i), 4);
                limSup = Math.Round(min + (paso * (i + 1)), 4);
                fo = numeros.Count(numerito => limInf <= numerito && numerito < limSup);
                fe = Math.Round(((1 - Math.Pow(Math.E, (-lambda * limSup))) - (1 - Math.Pow(Math.E, (-lambda * limInf)))) * numeros.Length);

                Object[] cells = { i+1, limInf, limSup, fo, fe };

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
                        chi = Math.Round((Math.Pow((fe - fo), 2)) / fe, 4);
                        chiA += chi;
                        tablaRedux.Rows[tablaRedux.Rows.Count - 1].SetValues(count - 1, limInf, limSup, fo, fe, chi, chiA);
                    }
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        limSup = double.Parse(tabla.Rows[i].Cells[2].Value.ToString());
                        chi = Math.Round((Math.Pow((fe - fo), 2)) / fe, 4);
                        chiA += chi;
                        Object[] cells = { count, limInf, limSup, fo, fe, chi, Math.Round(chiA, 4) };
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

        public void pruebaKS(int cantidadIntervalos, DataGridView tabla)
        {
            double min = numeros.Min();
            double max = numeros.Max();
            double paso = ((max - min) / cantidadIntervalos);
            double foAC, feAC, maximo;
            foAC = feAC = maximo = 0;


            tabla.ColumnCount = 11;
            tabla.Columns[0].Name = "Intervalo";
            tabla.Columns[1].Name = "Limite Inferior";
            tabla.Columns[2].Name = "Limite Superior";
            tabla.Columns[3].Name = "Frecuencia Observada";
            tabla.Columns[4].Name = "Frecuencia Esperada";
            tabla.Columns[5].Name = "P.Observada";
            tabla.Columns[6].Name = "P.Esperada";
            tabla.Columns[7].Name = "P.Acumulada Observada";
            tabla.Columns[8].Name = "P.Acumulada Esperada";
            tabla.Columns[9].Name = "Diferencia";
            tabla.Columns[10].Name = "Maximo";

            for (int i = 0; i < cantidadIntervalos; i++)
            {
                
                double limInf = Math.Round(min + (paso * i), 4);
                double limSup = Math.Round(min + (paso * (i + 1)), 4);
                double fo = numeros.Count(numerito => limInf <= numerito && numerito < limSup);
                double fe = Math.Round(((1 - Math.Pow(Math.E, (-lambda * limSup))) - (1 - Math.Pow(Math.E, (-lambda * limInf)))) * numeros.Length);
                double foP = Math.Round(fo / numeros.Length, 4);
                double feP = Math.Round(fe / numeros.Length, 4);
                foAC += foP;
                feAC += feP;
                double diferencia = Math.Round(foAC - feAC, 4);
                if(i == 0)
                {
                    maximo = Math.Abs(diferencia);
                }
                else
                {
                    if (Math.Abs(diferencia) > maximo)
                    {
                        maximo = Math.Abs(diferencia);
                    }
                }
                tabla.Rows.Add(i, limInf, limSup, fo, fe, foP, feP, foAC, feAC, Math.Abs(diferencia), maximo);
            }
            estadisticoPrueba = maximo;
        }

        public void generarNumeros(double[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                numeros[i] = Math.Round(-(1 / lambda) * Math.Log(1 - nums[i]), 4);

            }
        }

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }

    }
}
