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



        public override void chiCuadradoRedux(DataGridView tabla, DataGridView tabRedux)
        {

        }

        public int[] getEventos(int[] numeritos)
        {
            int[] distintos = numeritos.Distinct().ToArray();
            Array.Sort(distintos);

            return distintos;
        }

        public override void chiCuadrado(int muestra, int eventos, DataGridView tabla)
        {

            
            tabla.ColumnCount = 3;
            int[] eventosArray = getEventos(numeritos);
            int[] countArray = new int[eventosArray.Length];
            Array.Sort(numeritos);
            int count = 0;

            tabla.Columns[0].Name = "Evento";
            tabla.Columns[1].Name = "Frecuencia Observada";
            tabla.Columns[2].Name = "Frecuencia Esperada";

            for(int i = 0; i < eventosArray.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                foreach(int numero in numeritos)
                {
                    if(numero == eventosArray[i] && numero!= 0)
                    {
                        count++;
                    }
                }
                double fo = count;
                double prob = (Math.Pow(Math.E, -lambda) * Math.Pow(lambda, eventosArray[i])) / factorial(eventosArray[i]);
                double fe = Math.Truncate(prob * muestra);
                Object[] cells = { eventosArray[i], fo, fe};
                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);
                count = 0;
            }


            

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

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }


    }
}
