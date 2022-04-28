using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.FrontEnd.Pantallas
{
    public partial class FrmPruebaBondad : Form
    {
        public FrmPruebaBondad()
        {
            InitializeComponent();
        }

        public void SetColumnasProcedimiento(string[] columnas)
        {
            for (int i = 0; i < columnas.Length; i++)
                tablaProcedimiento.Columns.Add($"col{i}", columnas[i]);
        }

        public void MostrarProcedimiento(string[][] procedimiento)
        {
            foreach (string[] fila in procedimiento)
                tablaProcedimiento.Rows.Add(fila);
        }

        public void MostrarConclusion(string conclusion)
        {
            lblConclusion.Text = conclusion;
        }

        public void MostrarEstadisticoPrueba(string v)
        {
            lblEstadistico.Text = v;
        }

        public void MostrarValorCritico(string v)
        {
            lblValorCritico.Text = v;
        }

        public void MostrarNombrePrueba(string v)
        {
            lblPruebaBondad.Text = v;
        }

        public void MostrarImagenResultado(bool exito)
        {   //para que se muestre la imagen de que se acepta o no la prueba
            //if (exito)
                //pbResultado.Image = Resources.cheque;

            //else
                //pbResultado.Image = Resources.cancelar;
        }
    }
}

