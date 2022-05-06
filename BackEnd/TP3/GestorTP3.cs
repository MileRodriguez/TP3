using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1SIM.BackEnd.PruebasBondad;

namespace TP1SIM.BackEnd.TP3
{
    class GestorTP3
    {
        private double estadisticoPrueba, valorCritico;

        public void cargarTabla(double[] numeritos, DataGridView tabla)
        {
            tabla.ColumnCount = 2;

            tabla.Columns[0].Name = "Iteracion";
            tabla.Columns[1].Name = "RND";

            for (int i = 0; i < (numeritos.Length); i++)
            {
                int indice = i + 1;
                tabla.Rows.Add(indice.ToString(), numeritos[i].ToString());
            }
        }

        public void cargarTabla(int[] numeritos, DataGridView tabla)
        {
            tabla.ColumnCount = 2;

            tabla.Columns[0].Name = "Iteracion";
            tabla.Columns[1].Name = "RND";

            for (int i = 0; i < (numeritos.Length); i++)
            {
                int indice = i + 1;
                tabla.Rows.Add(indice.ToString(), numeritos[i].ToString());
            }
        }

        public void CalcularValorCritico(int cantidadIntervalos, int datosEmpiricos)
        {
            double[] valoresCriticos = { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8 };
            double[] vc_grandes = { 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3 };
            int grados_libertad = cantidadIntervalos - 1 - datosEmpiricos;

            if (cantidadIntervalos <= 30)
            {
                valorCritico = valoresCriticos[grados_libertad - 1];
            }
            else
            {
                switch (grados_libertad)
                {
                    case 40:
                        valorCritico = vc_grandes[0];
                        break;
                    case 50:
                        valorCritico = vc_grandes[1];
                        break;
                    case 60:
                        valorCritico = vc_grandes[2];
                        break;
                    case 70:
                        valorCritico = vc_grandes[3];
                        break;
                    case 80:
                        valorCritico = vc_grandes[4];
                        break;
                    case 90:
                        valorCritico = vc_grandes[5];
                        break;
                    case 100:
                        valorCritico = vc_grandes[6];
                        break;
                    default:
                        valorCritico = 0;
                        break;

                }
            }
        }

        public void CalcularValorCritico(int muestra)
        {
            double[] valoresCriticos = {0.975, 0.84189, 0.7076, 0.62394, 0.56328,
                0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543, 0.36143,
                0.34890, 0.33750, 0,32733, 0.31796, 0.30936, 0.30143, 0.29408, 0.28724,
                0.28087, 0.27491, 0.26931, 0.26404, 0.25908, 0.25438, 0.24993, 0.24571,
                0.24170, 0.23778, 0.23424, 0.23076, 0.22743, 0.22425};
            if (muestra <= 35)
            {
                valorCritico = valoresCriticos[muestra - 1];
            }
            else
            {
                valorCritico = Math.Round(1.36 / Math.Sqrt(muestra), 4);
            }

        }

        public void setEstadisticoPrueba(double estadistico)
        {
            this.estadisticoPrueba = estadistico;
        }
        public double getEstadisticoPrueba()
        {
            return this.estadisticoPrueba;
        }
        public double getValorCritico() 
        { 
            return this.valorCritico; 
        }
        public void setValorCritico(double valorCritico)
        {
            this.valorCritico=valorCritico;
        }

        public bool ResultadoExitoso()
        {
            return estadisticoPrueba <= valorCritico;
        }


    }
}
