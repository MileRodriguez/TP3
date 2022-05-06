using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class Poisson : Dist
    {
        private double lambda;

        public void setLambda(double lambda)
        {
            this.lambda = lambda;
        }

        public override void chiCuadradoRedux(DataGridView tabla, DataGridView tabRedux)
        {
            long fe = 0;
            int fo = 0;
            double chi;
            double chiA = 0;
            bool reiniciarLista = false;
            long previous_fe = 0;
            int previous_fo = 0;
            double previous_chi = 0;
            List<int> previousList = new List<int>();
            string valores;

            tabRedux.ColumnCount = 5;

            tabRedux.Columns[0].Name = "Evento";
            tabRedux.Columns[1].Name = "Frecuencia Observada";
            tabRedux.Columns[2].Name = "Frecuencia Esperada";
            tabRedux.Columns[3].Name = "Chi";
            tabRedux.Columns[4].Name = "Chi Acumulado";

            List<int> conjunto = new List<int>();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (reiniciarLista)
                {
                    previousList = conjunto;
                    conjunto.Clear();
                    reiniciarLista = false;
                }
                conjunto.Add(int.Parse(tabla.Rows[i].Cells[0].Value.ToString()));
                fe += Convert.ToInt64(tabla.Rows[i].Cells[2].Value);
                fo += int.Parse(tabla.Rows[i].Cells[1].Value.ToString());
                if (fe >= 5 || i == tabla.Rows.Count - 1)
                {
                    if (i == tabla.Rows.Count - 1 && fe < 5)
                    {
                        previousList.AddRange(conjunto);
                        valores = string.Join(", ", previousList.ToArray());
                        fe += previous_fe;
                        fo += previous_fo;
                        chiA -= previous_chi;
                        chi = Math.Round((Math.Pow((fe - fo), 2)) / fe, 4);
                        chiA += chi;
                        tabRedux.Rows[tabRedux.Rows.Count - 1].SetValues(valores, fo, fe, chi, chiA);
                    }
                    else
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        chi = Math.Round((Math.Pow((fe - fo), 2)) / fe, 4);
                        chiA += chi;
                        valores = string.Join(", ", conjunto.ToArray());
                        Object[] cells = { valores, fo, fe, chi, chiA };
                        previous_fe = fe;
                        previous_fo = fo;
                        previous_chi = chi;
                        fo = 0;
                        fe = 0;
                        reiniciarLista = true;
                        row.CreateCells(tabRedux, cells);
                        tabRedux.Rows.Add(row);
                    }

                }

            }

            estadisticoPrueba = chiA;


        }

        public void pruebaKS(int cantidadIntervalos, DataGridView tabla)
        {
            double min = numerosInt.Min();
            double max = numerosInt.Max();
            double paso = ((max - min) / cantidadIntervalos);
            double foAC, feAC, maximo, count;
            foAC = feAC = maximo = count = 0;


            tabla.ColumnCount = 9;
            tabla.Columns[0].Name = "Evento";
            tabla.Columns[1].Name = "Frecuencia Observada";
            tabla.Columns[2].Name = "Frecuencia Esperada";
            tabla.Columns[3].Name = "P.Observada";
            tabla.Columns[4].Name = "P.Esperada";
            tabla.Columns[5].Name = "P.Acumulada Observada";
            tabla.Columns[6].Name = "P.Acumulada Esperada";
            tabla.Columns[7].Name = "Diferencia";
            tabla.Columns[8].Name = "Maximo";

            int[] eventosArray = getEventos(numerosInt);
            Array.Sort(numerosInt);

            for (int i = 0; i < eventosArray.Length; i++)
            {
                foreach (int numero in numerosInt)
                {
                    if (numero == eventosArray[i] && numero != 0)
                    {
                        count++;
                    }
                }
                double fo = count;
                double prob = (Math.Pow(Math.E, -this.lambda) * Math.Pow(this.lambda, eventosArray[i])) / factorial(eventosArray[i]);
                double fe = Math.Round(prob * numerosInt.Length);
                double foP = Math.Round(fo / numerosInt.Length, 4);
                double feP = Math.Round(fe / numerosInt.Length, 4);
                foAC += foP;
                feAC += feP;
                double diferencia = Math.Round(foAC - feAC, 4);
                if (i == 0)
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
                tabla.Rows.Add(eventosArray[i], fo, fe, foP, feP, foAC, feAC, Math.Abs(diferencia), maximo);
            }
            estadisticoPrueba = maximo;
        }

        public int[] getEventos(int[] numeritos)
        {
            int[] distintos = numeritos.Distinct().ToArray();
            Array.Sort(distintos);

            return distintos;
        }

        public void chiCuadradoP(int muestra, DataGridView tabla)
        {


            tabla.ColumnCount = 3;
            int[] eventosArray = getEventos(numerosInt);
            Array.Sort(numerosInt);
            int count = 0;

            tabla.Columns[0].Name = "Evento";
            tabla.Columns[1].Name = "Frecuencia Observada";
            tabla.Columns[2].Name = "Frecuencia Esperada";

            for (int i = 0; i < eventosArray.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                foreach (int numero in numerosInt)
                {
                    if (numero == eventosArray[i] && numero != 0)
                    {
                        count++;
                    }
                }
                double fo = count;
                double prob = (Math.Pow(Math.E, -this.lambda) * Math.Pow(this.lambda, eventosArray[i])) / factorial(eventosArray[i]);
                double fe = Math.Round(prob * muestra);
                Object[] cells = { eventosArray[i], fo, fe };
                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);
                count = 0;
            }
        }

        private double factorial(double number)
        {
            if (number == 0)
                return 1;
            else
            {
                return number * factorial(number - 1);
            }
        }

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }

        private int numeroPoisson(double lambda, Random rnd)
        {
            double p = 1;
            int x = -1;
            double a = Math.Pow(Math.E, -lambda);
            do
            {
                double u = rnd.NextDouble();
                p *= u;
                x++;
            }
            while (p >= a);
            return x;
        }

        public void generarNumeros()
        {
            Random rnd = new Random();
            for (int i = 0; i < numerosInt.Length; i++)
            {
                numerosInt[i] = numeroPoisson(lambda, rnd);
            }
        }

        public override void chiCuadrado(int cantidadIntervalos, DataGridView tabla)
        {
            throw new NotImplementedException();
        }
    }
}
