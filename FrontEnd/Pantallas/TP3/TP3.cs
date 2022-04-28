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
            double media = 0;

            if (num_Muestra.Text.Equals("") || txt_Lambda.Text.Equals("") && txt_MediaExp.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }

            else
            {
                if (txt_Media.Text != null)
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

                dtv_nrosRnd.Rows.Clear();
                dgv_ChiCuadrado.Rows.Clear();
                gestor.getSHITdone(numeritos, exo, Convert.ToInt32(num_Intervalos.Text), N);
                gestor.cargarTabla(exo.getNumeritos(), dtv_nrosRnd);
                gestor.cargarTablaHistograma(exo.getNumeritos(), Convert.ToInt32(num_Intervalos.Text), Convert.ToInt32(num_Muestra.Text), dgv_ChiCuadrado);
                dtv_nrosRnd.Refresh();
                dgv_ChiCuadrado.Refresh();

            }
        }


        private void btn_GenerarPoisson_Click(object sender, EventArgs e)
        {
            Poisson poisson = new Poisson();
            int N = Convert.ToInt32(num_Muestra.Text);
            double[] numeritos = generarNumeros(N);
            if (num_Muestra.Text.Equals("") || txt_LambdaPoisson.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }

            else
            {

                poisson.set(metodos.Poisson(numeritos, Convert.ToInt32(txt_LambdaPoisson.Text)), Convert.ToInt32(txt_LambdaPoisson.Text));
                dtv_nrosRnd.Rows.Clear();
                dgv_ChiCuadrado.Rows.Clear();
                gestor.getSHITdone(numeritos, poisson, Convert.ToInt32(num_Intervalos.Text), N);
                gestor.cargarTabla(poisson.getNumeritos(), dtv_nrosRnd);
                gestor.cargarTablaHistograma(poisson.getNumeritos(), Convert.ToInt32(num_Intervalos.Text), Convert.ToInt32(num_Muestra.Text), dgv_ChiCuadrado);
                dtv_nrosRnd.Refresh();
                dgv_ChiCuadrado.Refresh();
            }
            }

        private void btn_GenerarNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            int N = Convert.ToInt32(num_Muestra.Text);
            double[] numeritos = new double[0];

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
                        
                        if (rB_Box.Checked)
                        {
                            numeritos = generarNumeros(N * 2);
                            double[] num2 = new double[numeritos.Length];
                            num2 = metodos.Normal_box(numeritos, Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text));
                            normal.set(Convert.ToDouble(txt_Varianza.Text), Convert.ToDouble(txt_Media.Text), num2);
                        }
                        else
                        {
                            numeritos = generarNumeros(N * 12);
                            double[] num2 = new double[numeritos.Length];
                            num2 = metodos.Normal_conv(numeritos, Convert.ToDouble(txt_Media.Text), Convert.ToDouble(txt_Varianza.Text));
                            normal.set(Convert.ToDouble(txt_Varianza.Text), Convert.ToDouble(txt_Media.Text), num2);
                        }

                        dtv_nrosRnd.Rows.Clear();
                        dgv_ChiCuadrado.Rows.Clear();
                        gestor.getSHITdone(numeritos, normal, Convert.ToInt32(num_Intervalos.Text), N);
                        gestor.cargarTabla(normal.getNumeritos(), dtv_nrosRnd);
                        gestor.cargarTablaHistograma(normal.getNumeritos(), Convert.ToInt32(num_Intervalos.Text), Convert.ToInt32(num_Muestra.Text), dgv_ChiCuadrado);
                        dtv_nrosRnd.Refresh();
                        dgv_ChiCuadrado.Refresh();
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
