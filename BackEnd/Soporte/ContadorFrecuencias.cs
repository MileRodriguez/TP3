using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd.Soporte
{
    public class ContadorFrecuencias
    {
        /* 
        * Realiza el conteo de frecuencias con dos pasadas sobre la serie de números aleatorios,
        * organizándolos en un array de ConteoFrecuencia.
        * 
        * En la primera pasada se identifican el mayor y menor valor.
        * En la segunda se identifica el intervalo a incrementar, contando en los objetos ConteoFrecuencia.
        * Para determinar el intervalo (posición en el array) se utiliza las siguientes fórmulas:
        * 
        * posicion (p): 0, 1, 2, 3 ...
        * serie { d [double] / min <= d <= max }
        * anchoIntervalo (t) = (max - min) / 2
        * 
        * d = min + t * p     se despeja la posición
        * p = d/t - min/t
        * 
        * p = Truncar( A * d + B )       donde: A = 1/t   B = -min/t
        * 
        */
        public static ConteoFrecuencia[] Contar(double[] serie, int intervalos, bool intervalosEnteros)
        {
            int posicion, cantidad;
            double anchoIntervalo, mayor, menor, inicioIntervalo, A, B;
            ConteoFrecuencia[] conteos;

            mayor = menor = serie[0];

            foreach (double d in serie)
            {
                if (d < menor) menor = d;
                if (d > mayor) mayor = d;
            }

            if (intervalosEnteros)
            {
                cantidad = (int)(mayor - menor) + 1;
                conteos = new ConteoFrecuencia[cantidad];

                for (int i = 0; i < cantidad; i++)
                {
                    inicioIntervalo = menor + i;

                    conteos[i] = new ConteoFrecuencia
                    {
                        Desde = inicioIntervalo,
                        Hasta = inicioIntervalo,
                        Cantidad = 0
                    };
                }

                A = 1;
                B = -menor;
                intervalos = (int)cantidad;
            }
            else
            {
                anchoIntervalo = (mayor - menor) / intervalos;
                if (anchoIntervalo == 0) anchoIntervalo = 1;  // por si se generan solo 2 números y son iguales

                conteos = new ConteoFrecuencia[intervalos];

                for (int i = 0; i < intervalos; i++)
                {
                    inicioIntervalo = menor + i * anchoIntervalo;

                    conteos[i] = new ConteoFrecuencia
                    {
                        Desde = inicioIntervalo,
                        Hasta = inicioIntervalo + anchoIntervalo,
                        Cantidad = 0
                    };
                }

                A = 1 / anchoIntervalo;
                B = -menor / anchoIntervalo;
            }

            foreach (double d in serie)
            {
                posicion = (int)(A * d + B);

                // para incluir el valor mayor y evitar errores
                if (d == mayor)
                    posicion = intervalos - 1;

                conteos[posicion].Contar();
            }
            return conteos;
        }
    }
}
