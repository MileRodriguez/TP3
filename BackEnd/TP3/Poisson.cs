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
            int fe = 0;
            int fo = 0;
            double chi = 0;
            double chiA = 0;
            bool reiniciarLista = false;
            int previous_fe = 0;
            int previous_fo = 0;
            double previous_chi = 0;
            List<int> previousList = new List <int>();
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
                fe += int.Parse(tabla.Rows[i].Cells[2].Value.ToString());
                fo += int.Parse(tabla.Rows[i].Cells[1].Value.ToString());
                if(fe > 5 || i == tabla.Rows.Count - 1)
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
                        Object[] cells = {valores, fo, fe, chi, chiA };
                        previous_fe = fe;
                        previous_fo = fo;
                        previous_chi = chi;
                        fo = fe = 0;
                        reiniciarLista = true;
                        row.CreateCells(tabRedux, cells);
                        tabRedux.Rows.Add(row);
                    }

                }

            }

           
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
                double fe = Math.Round(prob * muestra);
                Object[] cells = { eventosArray[i], fo, fe};
                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);
                count = 0;
            }
        }

        private double factorial(double number)
        {
            if (number == 0)
                return 1;
            return number * factorial(number - 1);
        }

        public double getEstadisticoPrueba()
        {
            return estadisticoPrueba;
        }


    }
}
