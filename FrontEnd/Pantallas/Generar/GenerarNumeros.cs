using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1SIM.BackEnd.Congruencial;

namespace TP1SIM.FrontEnd.Pantallas.Generar
{
    public partial class GenerarNumeros : Form
    {
        public GenerarNumeros()
        {
            InitializeComponent();
        }

        private void ck_Multiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Multiplicativo.Checked)
            {
                metodoCongruencial metodoCong = new metodoCongruencial();
                //metodoCong(int n, double semilla, int k, int g, int c)
            }
        }
    }
}
