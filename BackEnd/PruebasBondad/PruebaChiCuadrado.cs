using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd.PruebasBondad
{
    public class PruebaChiCuadrado : PruebaBondad
    {
        private static readonly double[] valoresCriticos = {
            3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7,
            21.0, 22.4, 23.7 , 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9,
            35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8
        };

        private static readonly double[] valoresCriticosGrandes = {
            0, 0, 0, 43.8, 55.8, 67.5, 79.1, 90.5, 101.9, 113.1, 124.3
        };

        protected override bool AgruparFrecuenciasEsperadas()
        {
            return true;
        }

        protected override double[] CalcularFila(double desde, double hasta, double frecuenciaObservada, double frecuenciaEsperada, int tamanioMuestra, double[] filaAnterior)
        {
            double[] fila = new double[6];

            fila[0] = desde;
            fila[1] = hasta;
            fila[2] = frecuenciaObservada;
            fila[3] = frecuenciaEsperada;
            fila[4] = Math.Pow(fila[3] - fila[2], 2) / fila[3];
            fila[5] = fila[4];

            if (filaAnterior != null)
                fila[5] += filaAnterior[5];

            return fila;
        }

        protected override double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
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

        public override string[] GetColumnasProcedimiento(bool intervalosEnteros)
        {
            if (intervalosEnteros)
                return new string[] {
                    "Valores",
                    "Frecuencia Observada",
                    "Frecuencia Esperada",
                    "C",
                    "C Acumulado"
                };
            return new string[] {
                "Desde",
                "Hasta",
                "Frecuencia Observada",
                "Frecuencia Esperada",
                "C",
                "C Acumulado"
            };
        }

        public override string GetNombre()
        {
            return "Chi Cuadrado";
        }
    }
}
