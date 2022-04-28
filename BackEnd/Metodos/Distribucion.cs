using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1SIM.BackEnd.PruebasBondad;

namespace TP1SIM.BackEnd.Metodos
{
    public abstract class Distribucion
    {
        public abstract double[] CalcularFrecuenciasEsperadas(double[] serie, ConteoFrecuencia[] conteos);
        public abstract string GetNombre();
        public abstract int CantidadDatosEmpiricos();

        public virtual bool IntervalosEnteros()
        {
            return false;
        }
        public virtual PruebaBondad ElegirPruebaBondad(int tamanioMuestra)
        {
            if (tamanioMuestra >= 30)
                return new PruebaChiCuadrado();

            return new PruebaKS();
        }
    }
}
