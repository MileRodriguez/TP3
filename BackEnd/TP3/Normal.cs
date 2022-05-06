using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class Normal : Dist
    {
        private double media;
        private double varianza;

        public void setVarianza(double varianza)
        {
            this.varianza= varianza;
        }

        public void setMedia(double media)
        {
            this.media = media;
        }

        public double getMedia()
        {
            return this.media;
        }

        public double getVarianza()
        {
            return this.varianza;
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
                double fe = Math.Round(CalculoFe(numeros.Length, this.media, this.varianza, limSup, limInf));
                double foP = Math.Round(fo / numeros.Length, 4);
                double feP = Math.Round(fe / numeros.Length, 4);
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
                tabla.Rows.Add(i, limInf, limSup, fo, fe, foP, feP, foAC, feAC, Math.Abs(diferencia), maximo);
            }
            estadisticoPrueba = maximo;
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
                fe = Math.Round(CalculoFe(numeros.Length, this.media, this.varianza, limSup, limInf));
                fo = numeros.Count(numerito => limInf <= numerito && numerito < limSup);

                Object[] cells = {i+1, limInf, limSup, fo, fe};

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

            limInf = Math.Round(double.Parse(tabla.Rows[0].Cells[1].Value.ToString()), 4);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (cambiarLim)
                {
                    previous_limInf = limInf;
                    limInf = Math.Round(double.Parse(tabla.Rows[i].Cells[1].Value.ToString()), 4);
                    cambiarLim = false;
                }
                fe += Math.Round(double.Parse(tabla.Rows[i].Cells[4].Value.ToString()), 4);
                fo += int.Parse(tabla.Rows[i].Cells[3].Value.ToString());
                if(fe > 5 || i == tabla.Rows.Count-1)
                {
                    if(i == tabla.Rows.Count-1 && fe < 5)
                    {
                        limInf = previous_limInf;
                        limSup = Math.Round(double.Parse(tabla.Rows[i].Cells[2].Value.ToString()), 4);
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

        public double CalculoFe(int N, double avg, double varianza, double limSup, double limInf)
        {
            double mc = (limSup + limInf)/2;
            double sd = Math.Sqrt(varianza);
            double part1 = Math.Pow((mc-avg)/sd, 2);
            double part2 = -0.5 * part1;
            double part3 = Math.Pow(Math.E, part2);
            double part4 = sd * Math.Sqrt(2 * Math.PI);
            double fe = (part3 / part4) * (limSup-limInf) * N;

            return fe;

        }


        public void generarNumeros(double[] nums, int choice)
        {
            switch (choice)
            {
                case 0:
                    numeros = new double[nums.Length / 2];
                    bool flag_cos = true;
                    if (flag_cos)
                        for (int i = 2; i < nums.Length + 2; i += 2)
                        {
                            if (flag_cos)
                            {
                                numeros[(i / 2) - 1] = Math.Round(Math.Sqrt(-2 * Math.Log(nums[i - 2])) * Math.Cos(2 * Math.PI * nums[i - 1]) * Math.Sqrt(varianza) + media, 4);
                                flag_cos = false;
                            }
                            else
                            {
                                numeros[(i / 2) - 1] = Math.Round(Math.Sqrt(-2 * Math.Log(nums[i - 2])) * Math.Sin(2 * Math.PI * nums[i - 1]) * Math.Sqrt(varianza) + media, 4);
                                flag_cos = true;
                            }
                        }
                    break;
                case 1:
                    numeros = new double[nums.Length / 12];
                    int count = 0;
                    double sum = 0;
                    int ciclo = 0;


                    for (int i = 0; i < nums.Length; i++)
                    {
                        sum += nums[i];
                        count++;
                        if (count == 12)
                        {
                            numeros[ciclo] = Math.Round((sum - 6) * Math.Sqrt(varianza) + media, 4);
                            count = 0;
                            sum = 0;
                            ciclo++;
                        }
                    }
                    break;
                default:
                    break;

            }
        }

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }



       
    }
}
