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

        private static readonly double[] valoresCriticos = {
            3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7,
            21.0, 22.4, 23.7 , 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9,
            35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8
        };

        private static readonly double[] valoresCriticosGrandes = {
            0, 0, 0, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3
        };

        public void getSHITdone(double[] numeritos, Dist distr, int cantidadIntervalos, int Muestra)
        {
            //DataGridView tabla = cargarTabla(numeritos);
            distribucion = distr;
            
            if (distr is Normal){
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

                //mostrar las tablas
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

        protected double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
        {
            int gradosLibertad = cantidadIntervalos - 1 - datosEmpiricos;

            if (gradosLibertad < 1) gradosLibertad = 1; // para evitar errores con algunas muestras muy pequeñas 

            if (gradosLibertad <= 30)
                return valoresCriticos[gradosLibertad - 1];

            gradosLibertad /= 10;

            if (gradosLibertad >= 11)
                return valoresCriticos[11];
            return valoresCriticosGrandes[gradosLibertad];
        }

        public bool ResultadoExitoso()
        {
            return estadisticoPrueba <= valorCritico;
        }


    }
}
