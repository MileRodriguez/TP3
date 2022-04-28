using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd.PruebasBondad
{
    public class PruebaKS : PruebaBondad
    {
        private static readonly double[] valCriticos = {
            0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300,
            0.4092, 0.3912, 0.3754, 0.3614, 0.3489 , 0.3375, 0.3273, 0.3179, 0.3093,
            0.3014, 0.2940, 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543,
            0.2499, 0.2457, 0.2417, 0.2378, 0.2342, 0.2307, 0.2274, 0.2242
        };

        protected override bool AgruparFrecuenciasEsperadas()
        {
            return false;
        }

        protected override double[] CalcularFila(double desde, double hasta, double frecuenciaObservada, double frecuenciaEsperada, int tamanioMuestra, double[] filaAnterior)
        {
            double[] fila = new double[10];

            fila[0] = desde;
            fila[1] = hasta;
            fila[2] = frecuenciaObservada;
            fila[3] = frecuenciaEsperada;
            fila[4] = fila[2] / tamanioMuestra;
            fila[5] = frecuenciaEsperada / tamanioMuestra;
            fila[6] = fila[4];
            fila[7] = fila[5];

            if (filaAnterior != null)
            {
                fila[6] += filaAnterior[6];
                fila[7] += filaAnterior[7];
            }

            fila[8] = Math.Abs(fila[6] - fila[7]);
            fila[9] = fila[8];

            if (filaAnterior != null && fila[9] < filaAnterior[9])
                fila[9] = filaAnterior[9];

            return fila;
        }

        protected override double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos)
        {
            if (tamanioMuestra > 35)
                return Math.Round(1.36 / Math.Sqrt(tamanioMuestra), 4);

            return valCriticos[tamanioMuestra - 1];
        }

        public override string[] GetColumnasProcedimiento(bool intervalosEnteros)
        {
            return new string[] {
                "Desde",
                "Hasta",
                "F. Observada",
                "F. Esperada",
                "P. Observada",
                "P. Esperada",
                "P.O. Acumulada",
                "P.E. Acumulada",
                "|POAc - PEAc|",
                "max |POAc - PEAc|"
            };
        }

        public override string GetNombre()
        {
            return "Kolmogorov - Smirnov";
        }
    }
}
