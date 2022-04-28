using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd
{
    public class ConteoFrecuencia
    {
        public double Desde { get; set; }
        public double Hasta { get; set; }
        public int Cantidad { get; set; }

        public void Contar()
        {
            Cantidad++;
        }
    }
}
