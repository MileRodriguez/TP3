using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1SIM.BackEnd.PruebasBondad;
using TP1SIM.BackEnd.Metodos;
using TP1SIM.FrontEnd.Pantallas;

namespace TP1SIM.BackEnd.Soporte
{
    public class GestorPruebaBondad
    {
        private readonly ConteoFrecuencia[] conteos;
        private readonly double[] serie;
        private PruebaBondad pruebaBondad;
        private readonly Distribucion distribucion;

        public GestorPruebaBondad(double[] serie, ConteoFrecuencia[] conteos, Distribucion distribucion)
        {
            this.serie = serie;
            this.distribucion = distribucion;
            this.conteos = conteos;
        }

        public void CalcularPrueba()
        {
            double[] fe = distribucion.CalcularFrecuenciasEsperadas(serie, conteos);

            pruebaBondad = distribucion.ElegirPruebaBondad(serie.Length);

            pruebaBondad.Calcular(conteos, fe, serie.Length, distribucion.CantidadDatosEmpiricos(), distribucion.IntervalosEnteros());

            MostrarResultado();
        }

        private void MostrarResultado()
        {
            FrmPruebaBondad form = new FrmPruebaBondad();
            form.SetColumnasProcedimiento(pruebaBondad.GetColumnasProcedimiento(distribucion.IntervalosEnteros()));
            form.MostrarProcedimiento(pruebaBondad.GetProcedimiento());
            form.MostrarEstadisticoPrueba(pruebaBondad.GetEstadisticoPrueba());
            form.MostrarValorCritico(pruebaBondad.GetValorCritico());
            form.MostrarNombrePrueba(pruebaBondad.GetNombre());
            form.MostrarConclusion(pruebaBondad.GetConclusion(distribucion.GetNombre()));
            form.MostrarImagenResultado(pruebaBondad.ResultadoExitoso());
            form.ShowDialog();
        }
    }
}