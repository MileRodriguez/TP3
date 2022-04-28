using System;
using System.Windows.Forms;

namespace TP1SIM.FrontEnd.Pantallas
{
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            panelPrincipal.Visible = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.2;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chi_CuadradoCM_Generador Punto1 = new Chi_CuadradoCM_Generador(this);
            Punto1.Show();
        }

        private void AbrirFormEnPanel(object Subform)
        {
            panelPrincipal.Visible = true;
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = Subform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void button_chi_mu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chi_Cuadrado Punto2 = new Chi_Cuadrado(this);
            Punto2.Show();
        }

        private void button_chi_mi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chi_CuadradoCM Punto3 = new Chi_CuadradoCM(this);
            Punto3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
