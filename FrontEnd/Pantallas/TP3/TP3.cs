using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1SIM.BackEnd.TP3;
using TP1SIM.BackEnd.Metodos;

namespace TP1SIM.FrontEnd.Pantallas.TP3
{
    public partial class TP3 : Form
    {
        public TP3()
        {
            InitializeComponent();
        }
        GestorTP3 gestor = new GestorTP3();
        Metodos metodos = new Metodos();

        //double[] numeritos;

        private void btn_Uniforme_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = false;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = false;    
            gpBx_Uniforme.Visible = true;

        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = true;     
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Uniforme.Visible = false;

        }

        private void btn_ExpNeg_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = true;
        }

        private void btn_Poisson_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Poisson.Visible = true;
        }

        private void btn_GenerarExp_Click(object sender, EventArgs e)
        {
            ExponencialNegativa exo = new ExponencialNegativa();

            int N = Convert.ToInt32(num_Muestra.Text);
            double[] numeritos = generarNumeros(N);
            double[] nros = new double[N];
            double media = 0;

            if (num_Muestra.Text.Equals("") || txt_Lambda.Text.Equals("") && txt_MediaExp.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }

            else
            {
                if (txt_Media != null)
                {
                    media = Convert.ToDouble(txt_MediaExp.Text);
                    exo.set(1/media, metodos.ExpNegativa(numeritos, media));
                }
                else
                {
                    double lambda = Convert.ToDouble(txt_Lambda.Text);
                    media = 1 / lambda;
                    exo.set(lambda, metodos.ExpNegativa(numeritos, media));
                }
                gestor.getSHITdone(generarNumeros(N), exo, Convert.ToInt32(num_Intervalos.Text), N);
                
            }
        }


        private void btn_GenerarPoisson_Click(object sender, EventArgs e)
        {
            /*Metodos metodos = new Metodos();
            Random rnd = new Random();
            */
            int N = Convert.ToInt32(num_Muestra.Text);
            double[] nros = new double[N];/*
            double media = Convert.ToDouble(txt_LambdaPoisson);

            for (int j = N; j == 0; j--)
            {
                nros.Append(rnd.NextDouble());
            }
            //return metodos.Poisson(nros, media)*/
        }

        private void btn_GenerarNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            int N = Convert.ToInt32(num_Muestra.Text);
            double[] nros = new double[N];

            if (!rB_Box.Checked && !rB_Convolucion.Checked)
            {
                MessageBox.Show("Eliga un método para generar los números aleatorios.");
            }
            else
            {
                if(num_Muestra.Text.Equals("") || txt_Varianza.Text.Equals("") || txt_Media.Text.Equals(""))
                {
                    MessageBox.Show("Complete los campos necesarios.");
                }

                else
                {
                    if (Convert.ToDouble(txt_Varianza.Text) < 0 || Convert.ToDouble(txt_Media.Text) < 0)
                    {
                        MessageBox.Show("Ingrese un numero positivo para la varianza y la media");
                    }
                    else
                    {
                        double[] num2 = new double[N];
                        if (rB_Box.Checked)
                        {
                            num2 = metodos.Normal_conv(generarNumeros(N), Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text));
                            normal.set(Convert.ToDouble(txt_Varianza.Text), Convert.ToDouble(txt_Media.Text), metodos.Normal_box(generarNumeros(N), Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text)));
                        }
                        else
                        {
                            num2 = metodos.Normal_conv(generarNumeros(N), Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text));
                            normal.set(Convert.ToDouble(txt_Varianza.Text), Convert.ToDouble(txt_Media.Text), metodos.Normal_conv(generarNumeros(N), Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text)));
                        }
                        gestor.cargarTabla(num2, dtv_nrosRnd);
                        gestor.getSHITdone(generarNumeros(N), normal, Convert.ToInt32(num_Intervalos.Text), N);
                    }
                }
            }
        }


        private void btn_GenerarUniforme_Click(object sender, EventArgs e)
        {
            Uniforme uniforme = new Uniforme();
            int N = Convert.ToInt32(num_Muestra.Text);
            if (num_Muestra.Text.Equals("") || txt_A.Text.Equals("") || txt_B.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }
            else
            {
                if (Convert.ToDouble(txt_A.Text) < 0 || Convert.ToDouble(txt_B.Text) < 0)
                {
                    MessageBox.Show("Ingrese un numero positivo para el limite derecho e izquierdo");
                }
                else
                {
                    double[] numeritos = generarNumeros(N);
                    uniforme.set(metodos.Uniforme(numeritos, Convert.ToInt32(txt_A.Text), Convert.ToInt32(txt_B.Text)), Convert.ToInt32(num_Intervalos.Text));

                    dtv_nrosRnd.Rows.Clear();
                    dgv_ChiCuadrado.Rows.Clear();
                    gestor.getSHITdone(numeritos, uniforme, Convert.ToInt32(num_Intervalos.Text), N);
                    gestor.cargarTabla(uniforme.getNumeritos(), dtv_nrosRnd);
                    gestor.cargarTablaHistograma(uniforme.getNumeritos(), Convert.ToInt32(num_Intervalos.Text), Convert.ToInt32(num_Muestra.Text), dgv_ChiCuadrado);
                    dtv_nrosRnd.Refresh();
                    dgv_ChiCuadrado.Refresh();
                }
            }
        }

        private void mostrarResultados(DataGridView tabla)
        {
            //dtv_nrosRnd = cargarTabla(numeritos);

        }

        private double[] generarNumeros(int N)
        {
            Random rnd = new Random();
            double[] nros = new double[N];
            for (int j = 0; j < N; j++)
            {
                nros[j] = (rnd.NextDouble());
            }

            return nros;
        }

    }
}
