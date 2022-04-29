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

        private void btn_Uniforme_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = false;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = false;    
            gpBx_Uniforme.Visible = true;
            cmb_intervalos.Enabled = true;

        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = true;     
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Uniforme.Visible = false;
            cmb_intervalos.Enabled = true;

        }

        private void btn_ExpNeg_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = true;
            cmb_intervalos.Enabled = true;
        }

        private void btn_Poisson_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Poisson.Visible = true;
            cmb_intervalos.Enabled = false;
        }

        private void btn_GenerarExp_Click(object sender, EventArgs e)
        {
            ExponencialNegativa exo = new ExponencialNegativa();

            int N = Convert.ToInt32(txt_muestra.Text);
            double[] numeritos = generarNumeros(N);
            double media = 0;
            gestor.setDistribucion(exo);
            double valorCritico;

            if (txt_muestra.Text.Equals("") || txt_Lambda.Text.Equals("") && txt_MediaExp.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }

            else
            {
                if (txt_MediaExp.Text != null)
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
                dgv_redux.Rows.Clear();

                gestor.cargarTabla(exo.getNumeritos(), dtv_nrosRnd);
                gestor.cargarTablaHistograma(exo.getNumeritos(), Convert.ToInt32(cmb_intervalos.Text), Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                dtv_nrosRnd.Refresh();
                dgv_ChiCuadrado.Refresh();
                gestor.cargarTablaRedux(dgv_ChiCuadrado, dgv_redux);
                dgv_redux.Refresh();

            }
            valorCritico = gestor.decidirDistribución(numeritos, exo, Convert.ToInt32(cmb_intervalos.Text), N);

            gestor.setEstadisticoPrueba(exo.getEstadisticoPrueba());


            txt_critico.Text = valorCritico.ToString();
            txt_estadistico.Text = exo.getEstadisticoPrueba().ToString();

            lbl_final.Visible = true;
            label5.Visible = true;

            if (gestor.ResultadoExitoso())
            {
                lbl_final.Text = "Aprobada";
                lbl_final.BackColor = Color.Green;
            }
            else
            {
                lbl_final.Text = "Rechazada";
                lbl_final.BackColor = Color.Red;
            }
        }


        private void btn_GenerarPoisson_Click(object sender, EventArgs e)
        {
            
            Poisson poisson = new Poisson();
            int N = Convert.ToInt32(txt_muestra.Text);
            double[] numeritos = generarNumeros(N);

            gestor.setDistribucion(poisson);

            if (txt_muestra.Text.Equals("") || txt_LambdaPoisson.Text.Equals(""))
            {
                MessageBox.Show("Complete los campos necesarios.");
            }

            else
            {

                poisson.set(metodos.Poisson(numeritos, Convert.ToInt32(txt_LambdaPoisson.Text)), Convert.ToInt32(txt_LambdaPoisson.Text));
                dgv_redux.Rows.Clear();
                dtv_nrosRnd.Rows.Clear();
                dgv_ChiCuadrado.Rows.Clear();
                
                gestor.cargarTabla(poisson.getNumeritos(), dtv_nrosRnd);
                gestor.cargarTablaHistograma(poisson.getNumeritos(), 0, Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                dtv_nrosRnd.Refresh();
                dgv_ChiCuadrado.Refresh();
                //gestor.cargarTablaRedux(dgv_ChiCuadrado, dgv_redux);
                //dgv_redux.Refresh();


            }
            double valorCritico = gestor.decidirDistribución(numeritos, poisson, Convert.ToInt32(dgv_redux.Rows.Count), N);
            gestor.setEstadisticoPrueba(poisson.getEstadisticoPrueba());


            txt_critico.Text = valorCritico.ToString();
            txt_estadistico.Text = poisson.getEstadisticoPrueba().ToString();

            lbl_final.Visible = true;
            label5.Visible = true;

            if (gestor.ResultadoExitoso())
            {
                lbl_final.Text = "Aprobada";
                lbl_final.BackColor = Color.Green;
            }
            else
            {
                lbl_final.Text = "Rechazada";
                lbl_final.BackColor = Color.Red;
            }
        }

        private void btn_GenerarNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            int N = Convert.ToInt32(txt_muestra.Text);
            double[] numeritos = new double[0];
            gestor.setDistribucion(normal);

            if (!rB_Box.Checked && !rB_Convolucion.Checked)
            {
                MessageBox.Show("Eliga un método para generar los números aleatorios.");
            }
            else
            {
                if(txt_muestra.Text.Equals("") || txt_Varianza.Text.Equals("") || txt_Media.Text.Equals(""))
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
                        dgv_redux.Rows.Clear();

                        double valorCritico = gestor.decidirDistribución(numeritos, normal, Convert.ToInt32(cmb_intervalos.Text), N);

                        gestor.cargarTabla(normal.getNumeritos(), dtv_nrosRnd);
                        gestor.cargarTablaHistograma(normal.getNumeritos(), Convert.ToInt32(cmb_intervalos.Text), Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                        dtv_nrosRnd.Refresh();
                        dgv_ChiCuadrado.Refresh();
                        gestor.cargarTablaRedux(dgv_ChiCuadrado, dgv_redux);
                        dgv_redux.Refresh();

                        gestor.setEstadisticoPrueba(normal.getchiAcu());

                        
                        txt_critico.Text = valorCritico.ToString();
                        txt_estadistico.Text = normal.getchiAcu().ToString();

                        lbl_final.Visible = true;
                        label5.Visible = true;

                        if (gestor.ResultadoExitoso())
                        {
                            lbl_final.Text = "Aprobada";
                            lbl_final.BackColor = Color.Green;
                        }
                        else
                        {
                            lbl_final.Text = "Rechazada";
                            lbl_final.BackColor = Color.Red;
                        }

                        



                       
                    }
                }
            }
        }


        private void btn_GenerarUniforme_Click(object sender, EventArgs e)
        {
            Uniforme uniforme = new Uniforme();
            int N = Convert.ToInt32(txt_muestra.Text);
            gestor.setDistribucion(uniforme);
            double[] numeritos = new double[0];

            if (txt_muestra.Text.Equals("") || txt_A.Text.Equals("") || txt_B.Text.Equals(""))
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
                    numeritos = generarNumeros(N);
                    uniforme.set(metodos.Uniforme(numeritos, Convert.ToInt32(txt_A.Text), Convert.ToInt32(txt_B.Text)), Convert.ToInt32(cmb_intervalos.Text));

                    dgv_redux.Rows.Clear();
                    dtv_nrosRnd.Rows.Clear();
                    dgv_ChiCuadrado.Rows.Clear();
                    gestor.cargarTabla(uniforme.getNumeritos(), dtv_nrosRnd);
                    gestor.cargarTablaHistograma(uniforme.getNumeritos(), Convert.ToInt32(cmb_intervalos.Text), Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                    dtv_nrosRnd.Refresh();
                    dgv_ChiCuadrado.Refresh();
                }
            }
            double valorCritico = gestor.decidirDistribución(numeritos, uniforme, Convert.ToInt32(cmb_intervalos.Text), N);

            gestor.setEstadisticoPrueba(uniforme.getEstadisticoPrueba());
            txt_critico.Text = valorCritico.ToString();
            txt_estadistico.Text = uniforme.getEstadisticoPrueba().ToString();

            lbl_final.Visible = true;
            label5.Visible = true;

            if (gestor.ResultadoExitoso())
            {
                lbl_final.Text = "Aprobada";
                lbl_final.BackColor = Color.Green;
            }
            else
            {
                lbl_final.Text = "Rechazada";
                lbl_final.BackColor = Color.Red;
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

        private void TP3_Load(object sender, EventArgs e)
        {
            lbl_final.Visible = false;
            label5.Visible = false;
        }
    }
}
