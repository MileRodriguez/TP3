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

        private void btn_Uniforme_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = false;
            gpBx_Poisson.Visible = false;
            dgv_redux.Visible = false;
            dgv_ChiCuadrado.Width = 845;
            gpBx_ExpNeg.Visible = false;    
            gpBx_Uniforme.Visible = true;
            cmb_intervalos.Enabled = true;
            rb_ks.Enabled = true;
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            gpBx_Normal.Visible = true;
            dgv_redux.Visible = true;
            dgv_ChiCuadrado.Width = 320;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Uniforme.Visible = false;
            cmb_intervalos.Enabled = true;
            rb_ks.Enabled = true;

        }

        private void btn_ExpNeg_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            dgv_redux.Visible = true;
            dgv_ChiCuadrado.Width = 320;
            gpBx_Poisson.Visible = false;
            gpBx_ExpNeg.Visible = true;
            cmb_intervalos.Enabled = true;
            rb_ks.Enabled = true;
        }

        private void btn_Poisson_Click(object sender, EventArgs e)
        {
            gpBx_Uniforme.Visible = false;
            gpBx_Normal.Visible = false;
            gpBx_ExpNeg.Visible = false;
            gpBx_Poisson.Visible = true;
            dgv_redux.Visible = true;
            dgv_ChiCuadrado.Width = 320;
            cmb_intervalos.Enabled = false;
            cmb_intervalos.Text = "";
            rb_ks.Enabled = false;
        }

        private void btn_GenerarExp_Click(object sender, EventArgs e)
        {
            ExponencialNegativa exo = new ExponencialNegativa();

            double lambda = 0;
            double media = 0;

            if (txt_muestra.Text.Equals("") || (txt_Lambda.Text.Equals("") && txt_MediaExp.Text.Equals("")) || cmb_intervalos.SelectedIndex == -1)
            {
                MessageBox.Show("¡Complete los campos necesarios!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int N = Convert.ToInt32(txt_muestra.Text);
                double[] numeritos = generarNumeros(N);
                exo.setNumeros(N);
                if (txt_MediaExp.Text != "")
                {
                    media = Convert.ToDouble(txt_MediaExp.Text);
                    lambda = 1 / media;
                }
                else
                {
                    lambda = Convert.ToDouble(txt_Lambda.Text);
                }
                exo.setLambda(lambda);
                exo.generarNumeros(numeritos);

                dtv_nrosRnd.Rows.Clear();
                dgv_ChiCuadrado.Rows.Clear();
                dgv_redux.Rows.Clear();

                gestor.cargarTabla(exo.getNumeros(), dtv_nrosRnd);
                dtv_nrosRnd.Refresh();
                if (rb_chi.Checked)
                {
                    dgv_redux.Visible = true;
                    dgv_ChiCuadrado.Width = 320;
                    exo.chiCuadrado(Convert.ToInt32(cmb_intervalos.SelectedItem), dgv_ChiCuadrado);
                    dgv_ChiCuadrado.Refresh();
                    exo.chiCuadradoRedux(dgv_ChiCuadrado, dgv_redux);
                    dgv_redux.Refresh();
                    gestor.CalcularValorCritico(Convert.ToInt32(cmb_intervalos.SelectedItem), 1);
                }
                else
                {
                    exo.pruebaKS(Convert.ToInt32(cmb_intervalos.SelectedItem), dgv_ChiCuadrado);
                    dgv_ChiCuadrado.Width = 845;
                    dgv_redux.Visible = false;
                    dgv_ChiCuadrado.Refresh();
                    gestor.CalcularValorCritico(N);
                }
                double valorCritico = gestor.getValorCritico();
                double estadisticoPrueba = exo.getEstadisticoPrueba();

                txt_critico.Text = valorCritico.ToString();
                txt_estadistico.Text = estadisticoPrueba.ToString();

                lbl_final.Visible = true;
                label5.Visible = true;

                if (exo.ResultadoExitoso(valorCritico))
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


        private void btn_GenerarPoisson_Click(object sender, EventArgs e)
        {
            
            Poisson poisson = new Poisson();

            if (txt_muestra.Text.Equals("") || txt_LambdaPoisson.Text.Equals(""))
            {
                MessageBox.Show("¡Complete los campos necesarios!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                int N = Convert.ToInt32(txt_muestra.Text);
                poisson.setLambda(double.Parse(txt_LambdaPoisson.Text));
                poisson.setNumerosInt(N);
                poisson.generarNumeros();

                dgv_redux.Rows.Clear();
                dtv_nrosRnd.Rows.Clear();
                dgv_ChiCuadrado.Rows.Clear();

                gestor.cargarTabla(poisson.getNumerosInt(), dtv_nrosRnd);
                dtv_nrosRnd.Refresh();

                if (rb_chi.Checked)
                {
                    poisson.chiCuadradoP(Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                    dgv_ChiCuadrado.Refresh();
                    try
                    {
                        dgv_redux.Visible = true;
                        dgv_ChiCuadrado.Width = 320;
                        poisson.chiCuadradoRedux(dgv_ChiCuadrado, dgv_redux);
                        dgv_redux.Refresh();
                        gestor.CalcularValorCritico(Convert.ToInt32(dgv_redux.Rows.Count), 1);
                    }
                    catch (OverflowException)
                    {
                        dgv_ChiCuadrado.Width = 845;
                        dgv_redux.Visible = false;
                        MessageBox.Show("Algunos valores de FE dan infinito/indeterminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    dgv_redux.Visible = false;
                    poisson.pruebaKS(Convert.ToInt32(txt_muestra.Text), dgv_ChiCuadrado);
                    dgv_ChiCuadrado.Width = 720;
                    dgv_ChiCuadrado.Refresh();

                    gestor.CalcularValorCritico(N);
                }
                

                double valorCritico = gestor.getValorCritico();
                double estadisticoPrueba = poisson.getEstadisticoPrueba();

                txt_critico.Text = valorCritico.ToString();
                txt_estadistico.Text = estadisticoPrueba.ToString();
                lbl_final.Visible = true;
                label5.Visible = true;

                if (poisson.ResultadoExitoso(valorCritico))
                {
                    lbl_final.Text = "Aprobada";
                    lbl_final.BackColor = Color.Green;
                }
                else
                {
                    if(valorCritico == 0)
                    {
                        lbl_final.Text = "Dudosa";
                        lbl_final.BackColor = Color.Yellow;
                    }
                    else
                    {
                        lbl_final.Text = "Rechazada";
                        lbl_final.BackColor = Color.Red;
                    }  
                }
            }
        }

        private void btn_GenerarNormal_Click(object sender, EventArgs e)
        {
            Normal normal = new Normal();
            double[] numeritos = new double[0];

            if (!rB_Box.Checked && !rB_Convolucion.Checked)
            {
                MessageBox.Show("Eliga un método para generar los números aleatorios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txt_muestra.Text.Equals("") || txt_Varianza.Text.Equals("") || txt_Media.Text.Equals("") || cmb_intervalos.SelectedIndex == -1)
                {
                    MessageBox.Show("¡Complete los campos necesarios!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (Convert.ToDouble(txt_Varianza.Text) < 0 || Convert.ToDouble(txt_Media.Text) < 0)
                    {
                        MessageBox.Show("Ingrese un numero positivo para la varianza y la media.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int N = Convert.ToInt32(txt_muestra.Text);
                        normal.setMedia(double.Parse(txt_Media.Text));
                        normal.setVarianza(double.Parse(txt_Varianza.Text));

                        if (rB_Box.Checked)
                        {
                            numeritos = generarNumeros(N * 2);
                            normal.generarNumeros(numeritos, 0);
                        }
                        else
                        {
                            numeritos = generarNumeros(N * 12);
                            normal.generarNumeros(numeritos, 1);
                        }

                        dtv_nrosRnd.Rows.Clear();
                        dgv_ChiCuadrado.Rows.Clear();
                        dgv_redux.Rows.Clear();

                        

                        gestor.cargarTabla(normal.getNumeros(), dtv_nrosRnd);
                        dtv_nrosRnd.Refresh();
                        if (rb_chi.Checked)
                        {
                            dgv_redux.Visible = true;
                            dgv_ChiCuadrado.Width = 320;
                            normal.chiCuadrado(Convert.ToInt32(cmb_intervalos.Text), dgv_ChiCuadrado);
                            dgv_ChiCuadrado.Refresh();
                            normal.chiCuadradoRedux(dgv_ChiCuadrado, dgv_redux);
                            dgv_redux.Refresh();
                            gestor.CalcularValorCritico(Convert.ToInt32(cmb_intervalos.Text), 2);
                        }
                        else
                        {
                            dgv_redux.Visible = false;
                            dgv_ChiCuadrado.Width = 845;
                            normal.pruebaKS(Convert.ToInt32(cmb_intervalos.Text), dgv_ChiCuadrado);
                            dgv_ChiCuadrado.Refresh();
                            gestor.CalcularValorCritico(N);

                        }

                        double valorCritico = gestor.getValorCritico();
                        double estadisticoPrueba = normal.getEstadisticoPrueba();

                        txt_critico.Text = valorCritico.ToString();
                        txt_estadistico.Text = estadisticoPrueba.ToString();

                        lbl_final.Visible = true;
                        label5.Visible = true;

                        if (normal.ResultadoExitoso(valorCritico))
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

            if (txt_muestra.Text.Equals("") || txt_A.Text.Equals("") || txt_B.Text.Equals("") || cmb_intervalos.SelectedIndex == -1)
            {
                MessageBox.Show("¡Complete los campos necesarios!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(txt_A.Text) > Convert.ToInt32(txt_B.Text))
                {
                    MessageBox.Show("El limite izquierdo debe ser menor que el derecho.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int N = Convert.ToInt32(txt_muestra.Text);
                    double [] numeritos = generarNumeros(N);
                    uniforme.setNumeros(N);
                    uniforme.setA(int.Parse(txt_A.Text));
                    uniforme.setB(int.Parse(txt_B.Text));
                    uniforme.generarNumeros(numeritos);

                    dgv_redux.Rows.Clear();
                    dtv_nrosRnd.Rows.Clear();
                    dgv_ChiCuadrado.Rows.Clear();

                    gestor.cargarTabla(uniforme.getNumeros(), dtv_nrosRnd);
                    dtv_nrosRnd.Refresh();
                    if (rb_chi.Checked)
                    {
                        uniforme.chiCuadrado(Convert.ToInt32(cmb_intervalos.Text), dgv_ChiCuadrado);
                        dgv_ChiCuadrado.Refresh();
                        gestor.CalcularValorCritico(Convert.ToInt32(cmb_intervalos.Text), 0);
                    }
                    else
                    {
                        uniforme.pruebaKS(Convert.ToInt32(cmb_intervalos.Text), dgv_ChiCuadrado);
                        dgv_ChiCuadrado.Refresh();
                        gestor.CalcularValorCritico(N);
                    }
              
                    double valorCritico = gestor.getValorCritico();
                    double estadisticoPrueba = uniforme.getEstadisticoPrueba();

                    txt_critico.Text = valorCritico.ToString();
                    txt_estadistico.Text = estadisticoPrueba.ToString();

                    lbl_final.Visible = true;
                    label5.Visible = true;

                    if (uniforme.ResultadoExitoso(valorCritico))
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
            rb_chi.Checked = true;
            lbl_final.Visible = false;
            label5.Visible = false;
            lbl_distribuciones.BackColor = Color.Yellow;
            cmb_intervalos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_Lambda_TextChanged(object sender, EventArgs e)
        {
            if(txt_Lambda.Text == "")
            {
                txt_MediaExp.Enabled = true;
            }

            else
            {
                txt_MediaExp.Text = "";
                txt_MediaExp.Enabled = false;
            }
        }

        private void txt_MediaExp_TextChanged(object sender, EventArgs e)
        {
            if (txt_MediaExp.Text == "")
            {
                txt_Lambda.Enabled = true;
            }

            else
            {
                txt_Lambda.Text = "";
                txt_Lambda.Enabled = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
