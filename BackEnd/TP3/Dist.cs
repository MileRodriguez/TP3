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
        protected double estadisticoPrueba;

        public abstract void chiCuadrado(int muestra, int cantidadIntervalos, DataGridView tabla);

    }
}
