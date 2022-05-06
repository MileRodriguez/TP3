using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    abstract class Dist
    {
        protected double[] numeros;

        protected int[] numerosInt;

        protected double estadisticoPrueba;
        public abstract void chiCuadrado(int cantidadIntervalos, DataGridView tabla);
        public abstract void chiCuadradoRedux(DataGridView tabla, DataGridView tabRedux);
        public void setNumeros(int N)
        {
            this.numeros = new double[N];
        }
        public void setNumerosInt(int N)
        {
            this.numerosInt = new int[N];
        }

        public double[] getNumeros()
        {
            return this.numeros;
        }

        public int[] getNumerosInt()
        {
            return this.numerosInt;
        }

        public bool ResultadoExitoso(double valor_critico)
        {
            return estadisticoPrueba <= valor_critico;
        }

    }
}
