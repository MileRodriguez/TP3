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

namespace TP1SIM.FrontEnd.Pantallas
{
    public partial class Chi_CuadradoCM_Generador : Form
    {
        public Menu ventana { get; set; }

        public Chi_CuadradoCM_Generador(Menu ven)
        {
            InitializeComponent();
            ventana = ven;
        }

        private void btn_volverMenu_Click(object sender, EventArgs e)
        {
            ventana.Show();
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Chi_CuadradoCM_Generador ven = new Chi_CuadradoCM_Generador(ventana);
            ven.Show();
            this.Close();
        }

        int tam_n;
        private Tuple<int, int, int, double> ObtenerValores()
        {
            //Tomamos todos los valores de los TextBox y los pasamos a variables y esos valores los retornamos en una tupla
            int Xo = Convert.ToInt32(TxtXo.Text);
            int c = Convert.ToInt32(TxtC.Text);

            if (checkGyK.Checked)
            {
                int a = 1 + (4 * (Convert.ToInt32(TxtK.Text)));
                double m = Math.Pow(2, Convert.ToDouble(TxtG.Text));

                return Tuple.Create(Xo, a, c, m);
            }

            if (checkGyK.Checked == false)
            {
                int a = Convert.ToInt32(TxtA.Text);
                double m = Convert.ToDouble(TxtM.Text);

                return Tuple.Create(Xo, a, c, m);
            }


            return Tuple.Create(0, 0, 0, 0.0);
        }

        public void cargadorDeGrilla(int N)
        {
            // La variable "var" va a contener la tupla de valores
            var valores = ObtenerValores();

            int X0 = valores.Item1;
            int A = valores.Item2;
            int C = valores.Item3;
            double M = valores.Item4;

            // Con el evento "generar" debemos verificar cual ejecutar en base a si tenemos filas en la grilla o no
            double Xo = 0;
            if(checkIncluir1.Checked == false)
            {
                Xo = Convert.ToDouble((A * X0 + C) % (M)) / (M - 1);
            }
            else
            {
                Xo = Convert.ToDouble((A * X0 + C) % (M)) / (M);
            }
            double formula = A * X0 + C;
            double resto = Convert.ToDouble(formula % M);
            //Con el ciclo for vamos generando cada valor y agregandolos a la grilla al mismo tiempo. utilizamos la variable "resto" para poder calcular el siguiente valor al final del ciclo.
            for (int i = 0; i < N; i++)
            {
                gdrSerieAleatoria.Rows.Add(i + 1, formula, resto, (Math.Truncate(Xo * 10000) / 10000));
                formula = A * resto + C;
                double X1 = Convert.ToDouble(formula % M);
                if(checkIncluir1.Checked == false)
                {
                    Xo = X1 / (M - 1);
                }
                else
                {
                    Xo = X1 / M;
                }
                resto = X1;
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int validarEntero;

            if (!int.TryParse(TxtTamañoMuestra.Text, out validarEntero) || !int.TryParse(TxtXo.Text, out validarEntero) || !int.TryParse(TxtC.Text, out validarEntero))
            {
                MessageBox.Show("¡Error! Hay campos que no se ingresaron o no son números enteros");
            }

            else
            {
                tam_n = Int32.Parse(TxtTamañoMuestra.Text);
                if (tam_n <= 0)
                {
                        MessageBox.Show("¡Error! La muestra debe ser un numero entero positivo");
                }
                else
                {
                        int N = Convert.ToInt32(TxtTamañoMuestra.Text);
                        gdrSerieAleatoria.Rows.Clear();
                        cargadorDeGrilla(N);
                }
                
            }
        }

        private void checkGyK_CheckedChanged(object sender, EventArgs e)
        {
            //Estan son validaciones para que si el usuario selecciona periodo maximo no pueda ingresar
            //valores de "a" y "m" manuales ya que se calculan en base a "k" y "g"
            if (checkGyK.Checked == true)
            {
                TxtA.Text = "";
                TxtM.Text = "";
                TxtA.Enabled = false;
                TxtM.Enabled = false;
                TxtG.Enabled = true;
                TxtK.Enabled = true;
            }
            else
            {
                TxtA.Enabled = true;
                TxtM.Enabled = true;
                TxtG.Enabled = false;
                TxtK.Enabled = false;
                TxtK.Text = "";
                TxtG.Text = "";
            }
        }

        private void Chi_CuadradoCM_Load(object sender, EventArgs e)
        {
            TxtG.Enabled = false;
            TxtK.Enabled = false;
        }

        private void ck_Multiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Multiplicativo.Checked)
            {
                TxtC.Enabled = false;
                TxtC.Text = "0";
            }
        }
    }
}
