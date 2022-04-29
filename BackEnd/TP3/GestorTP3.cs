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
        Dist distribucion;

        PruebaChiCuadrado chiC = new PruebaChiCuadrado();

        private double estadisticoPrueba, valorCritico;

        public double decidirDistribución(double[] numeritos, Dist distr, int cantidadIntervalos, int Muestra)
        {
            
            if (distr is Normal)
            {
                valorCritico = CalcularValorCritico(cantidadIntervalos, Muestra, 2);
            }
            if (distr is ExponencialNegativa || distr is Poisson)
            {
                valorCritico = CalcularValorCritico(cantidadIntervalos, Muestra, 1);
            }
            if (distr is Uniforme)
            {
                valorCritico = CalcularValorCritico(cantidadIntervalos, Muestra, 0);
            }

            return valorCritico;
        }



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

        public void cargarTablaHistograma(double[] numeritos, int cantidadIntervalosOEventos, int muestra, DataGridView tabla)
        {
            distribucion.chiCuadrado(muestra, cantidadIntervalosOEventos, tabla);
        }

        public void cargarTablaHistograma(int[] numeritos, int cantidadIntervalosOEventos, int muestra, DataGridView tabla)
        {
            distribucion.chiCuadrado(muestra, cantidadIntervalosOEventos, tabla);
        }

        public void cargarTablaRedux(DataGridView tabla, DataGridView tablaRedux)
        {
            distribucion.chiCuadradoRedux(tabla, tablaRedux);
        }

        protected double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
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
                        valorCritico = vc_grandes[1];
                        break;
                    case 70:
                        valorCritico = vc_grandes[1];
                        break;
                    case 80:
                        valorCritico = vc_grandes[1];
                        break;
                    case 90:
                        valorCritico = vc_grandes[1];
                        break;
                    case 100:
                        valorCritico = vc_grandes[1];
                        break;
                    default:
                        valorCritico = 0;
                        break;

                }
            }
            return valorCritico;
        }


        public void setEstadisticoPrueba(double estadistico)
        {
            this.estadisticoPrueba = estadistico;
        }

        public void setDistribucion(Dist distribucion)
        {
            this.distribucion = distribucion;
        }
        public bool ResultadoExitoso()
        {
            return estadisticoPrueba <= valorCritico;
        }


    }
}
