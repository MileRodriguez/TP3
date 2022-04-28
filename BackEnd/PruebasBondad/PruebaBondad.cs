using System;
using System.Collections.Generic;

namespace TP1SIM.BackEnd.PruebasBondad
{
    public abstract class PruebaBondad
    {
        private double estadisticoPrueba, valorCritico;
        private ConteoFrecuencia[] conteos;
        private double[] frecuenciasEsperadas;
        private int tamanioMuestra;
        private double[][] procedimiento;
        private bool usarIntervalosEnteros;
        private static readonly int DECIMALES_REDONDEO = 4;

        public void Calcular(ConteoFrecuencia[] conteos, double[] frecuenciasEsperadas, int tamanioMuestra, int cantidadDatosEmpiricos, bool usarIntervalosEnteros)
        {
            this.conteos = conteos;
            this.frecuenciasEsperadas = frecuenciasEsperadas;
            this.tamanioMuestra = tamanioMuestra;
            this.usarIntervalosEnteros = usarIntervalosEnteros;

            if (AgruparFrecuenciasEsperadas())
                Agrupar();

            CalcularPrueba();
            valorCritico = CalcularValorCritico(this.conteos.Length, tamanioMuestra, cantidadDatosEmpiricos);
        }

        public string GetConclusion(string nombreDistribucion)
        {
            if (ResultadoExitoso())
                return $"No se rechaza la hipotesis nula, la distribución es {nombreDistribucion}.";

            return $"Se rechaza la hipotesis nula, la distribución no es {nombreDistribucion}.";
        }

        private void CalcularPrueba()
        {
            int k = conteos.Length;
            procedimiento = new double[k][];

            procedimiento[0] = CalcularFila(conteos[0].Desde, conteos[0].Hasta, conteos[0].Cantidad, frecuenciasEsperadas[0], tamanioMuestra, null);

            for (int i = 1; i < k; i++)
                procedimiento[i] = CalcularFila(conteos[i].Desde, conteos[i].Hasta, conteos[i].Cantidad, frecuenciasEsperadas[i], tamanioMuestra, procedimiento[i - 1]);

            estadisticoPrueba = procedimiento[k - 1][procedimiento[0].Length - 1];
        }

        public bool ResultadoExitoso()
        {
            return estadisticoPrueba <= valorCritico;
        }

        public string GetValorCritico()
        {
            return Math.Round(valorCritico, DECIMALES_REDONDEO).ToString();
        }

        private void Agrupar()
        {
            if (FrecuenciasNulas()) throw new ApplicationException("No hay suficientes muestras para realizar una prueba de bondad");

            List<ConteoFrecuencia> tempFO = new List<ConteoFrecuencia>();
            List<double> tempFE = new List<double>();
            int sumaFO, desdePos = 0;
            double fe, sumaRestante, sumaFE = 0;
            bool alcanza;

            for (int i = 0; i < conteos.Length; i++)
            {
                fe = frecuenciasEsperadas[i] + sumaFE;

                // si la frecuencia esperada actual o acumulada supera 5:
                if (fe >= 5)
                {
                    // y si no es la ultima fila
                    if (i < conteos.Length - 1)
                    {
                        sumaRestante = 0;
                        alcanza = false;

                        // se revisa si las filas que siguen alcanzan para sumar 5 en fe
                        for (int j = i + 1; j < conteos.Length; j++)
                        {
                            sumaRestante += frecuenciasEsperadas[j];

                            // en caso de que alcancen 5, se deja de recorrer
                            if (sumaRestante >= 5)
                            {
                                alcanza = true;
                                break;
                            }
                        }

                        // si las filas restantes cuentan por lo menos 5, no se las incluye
                        if (alcanza)
                        {
                            // si solo la fila actual suma 5, se usa su valor para fo
                            if (desdePos == -1)
                            {
                                sumaFO = conteos[i].Cantidad;
                                desdePos = i;
                            }

                            // o si se suma 5 contando filas previas, se suman sus fo
                            else
                            {
                                sumaFO = 0;
                                for (int k = desdePos; k <= i; k++)
                                    sumaFO += conteos[k].Cantidad;
                            }

                            tempFO.Add(new ConteoFrecuencia
                            {
                                Desde = conteos[desdePos].Desde,
                                Hasta = conteos[i].Hasta,
                                Cantidad = sumaFO
                            });
                            tempFE.Add(fe);
                            sumaFE = 0;
                            desdePos = -1;

                        }

                        // si las filas restantes no llegan a sumar 5 en fe, se las suma a la actual
                        else
                        {
                            // si la fila actual suma 5 fe, se suman las fo desde la fila actual
                            // sino se utiliza el valor desdePos ya guardado
                            if (desdePos == -1)
                                desdePos = i;
                            sumaFO = 0;
                            for (int k = desdePos; k < conteos.Length; k++)
                                sumaFO += conteos[k].Cantidad;

                            tempFO.Add(new ConteoFrecuencia
                            {
                                Desde = conteos[desdePos].Desde,
                                Hasta = conteos[conteos.Length - 1].Hasta,
                                Cantidad = sumaFO
                            });

                            tempFE.Add(fe + sumaRestante);
                            break;
                        }
                    }
                }

                // si la fila actual o la suma de las previas no suman 5 fe
                // se deben seguir sumando filas siguientes
                else
                {
                    // si la fila actual es la primera en no sumar 5
                    if (desdePos == -1)
                        desdePos = i;
                    sumaFE = fe;
                }
            }
            frecuenciasEsperadas = tempFE.ToArray();
            conteos = tempFO.ToArray();
        }

        public string[][] GetProcedimiento()
        {
            int filas, columnas;

            filas = procedimiento.Length;
            columnas = procedimiento[0].Length;

            if (usarIntervalosEnteros)
                columnas--;

            string[][] tablaProcedimiento = new string[filas][];

            for (int i = 0; i < filas; i++)
            {
                string[] fila = new string[columnas];

                for (int j = 0; j < columnas; j++)
                {
                    if (usarIntervalosEnteros)
                    {
                        if (j == 0)
                            fila[j] = CalcularValoresIntervalo((int)procedimiento[i][j], (int)procedimiento[i][j + 1]);

                        else
                            fila[j] = Math.Round(procedimiento[i][j + 1], DECIMALES_REDONDEO).ToString();
                    }
                    else
                        fila[j] = Math.Round(procedimiento[i][j], DECIMALES_REDONDEO).ToString();
                }

                tablaProcedimiento[i] = fila;
            }
            return tablaProcedimiento;
        }

        private bool FrecuenciasNulas()
        {
            foreach (double d in frecuenciasEsperadas)
                if (d != 0)
                    return false;
            return true;
        }

        public string GetEstadisticoPrueba()
        {
            return Math.Round(estadisticoPrueba, DECIMALES_REDONDEO).ToString();
        }

        private string CalcularValoresIntervalo(int desde, int hasta)
        {
            string valores = "";

            for (int i = desde; i <= hasta; i++)
            {
                valores += i.ToString();

                if (i < hasta)
                    valores += ";";
            }
            return valores;
        }

        protected abstract double[] CalcularFila(double desde, double hasta, double fo, double fe, int tamanioMuestra, double[] anterior);
        public abstract string[] GetColumnasProcedimiento(bool intervalosEnteros);
        protected abstract double CalcularValorCritico(int cantidadIntervalos, int tamanioMuestra, int datosEmpiricos);
        public abstract string GetNombre();
        protected abstract bool AgruparFrecuenciasEsperadas();
    }
}
