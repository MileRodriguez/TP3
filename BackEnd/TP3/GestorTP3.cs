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
            double[] valoresCriticosNormal = { 11.1, 14.1, 21.0, 27.6 };
            double[] valoresCriticosPoissonExp = { 12.6, 15.5, 22.4, 28.9 };
            double[] valoresCriticosUniforme = { 14.1, 16.9, 23.7, 30.1 };

            if(datosEmpiricos == 2)
            {
                switch (cantidadIntervalos)
                {
                    case 8:
                        valorCritico = valoresCriticosNormal[0];
                        break;
                    case 10:
                        valorCritico = valoresCriticosNormal[1];
                        break;
                    case 15:
                        valorCritico = valoresCriticosNormal[2];
                        break;
                    case 20:
                        valorCritico = valoresCriticosNormal[3];
                        break;
                }
            }

            if (datosEmpiricos == 1)
            {
                switch (cantidadIntervalos)
                {
                    case 8:
                        valorCritico = valoresCriticosPoissonExp[0];
                        break;
                    case 10:
                        valorCritico = valoresCriticosPoissonExp[1];
                        break;
                    case 15:
                        valorCritico = valoresCriticosPoissonExp[2];
                        break;
                    case 20:
                        valorCritico = valoresCriticosPoissonExp[3];
                        break;
                }
            }

            if (datosEmpiricos == 0)
            {
                switch (cantidadIntervalos)
                {
                    case 8:
                        valorCritico = valoresCriticosUniforme[0];
                        break;
                    case 10:
                        valorCritico = valoresCriticosUniforme[1];
                        break;
                    case 15:
                        valorCritico = valoresCriticosUniforme[2];
                        break;
                    case 20:
                        valorCritico = valoresCriticosUniforme[3];
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
