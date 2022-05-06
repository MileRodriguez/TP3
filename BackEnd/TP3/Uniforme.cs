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
        private int a;
        private int b;

        public void setA(int a)
        {
            this.a = a; 
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public override void chiCuadradoRedux(DataGridView tabla, DataGridView tabRedux)
        {

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

                limInf = Math.Round(min + (paso * i), 4);
                limSup = Math.Round(min + (paso * (i + 1)), 4);
                fo = numeros.Count(numerito => limInf <= numerito && numerito < limSup);
                fe = numeros.Length / cantidadIntervalos;
                chi = Math.Round(Math.Pow((fe - fo), 2) / fe, 4);
                chiA = chiA + chi;

                Object[] cells = { i, limInf, limSup, fo, fe, chi, chiA };

                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);

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
                double fe = numeros.Length / cantidadIntervalos;
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

        public void generarNumeros(double[] nums)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Math.Round(a + nums[i] * (b - a), 4);
            }
        }
        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }

    }

    
}
