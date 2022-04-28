namespace TP1SIM.FrontEnd.Pantallas.Generar
{
    partial class GenerarNumeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.ck_Multiplicativo = new System.Windows.Forms.CheckBox();
            this.lbl_poblacion = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.lbl_semilla = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lbl_K = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(25, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(467, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Generador de Números Aleatorios";
            // 
            // ck_Multiplicativo
            // 
            this.ck_Multiplicativo.AutoSize = true;
            this.ck_Multiplicativo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_Multiplicativo.Location = new System.Drawing.Point(31, 152);
            this.ck_Multiplicativo.Name = "ck_Multiplicativo";
            this.ck_Multiplicativo.Size = new System.Drawing.Size(191, 24);
            this.ck_Multiplicativo.TabIndex = 1;
            this.ck_Multiplicativo.Text = "Método Multiplicativo";
            this.ck_Multiplicativo.UseVisualStyleBackColor = true;
            this.ck_Multiplicativo.CheckedChanged += new System.EventHandler(this.ck_Multiplicativo_CheckedChanged);
            // 
            // lbl_poblacion
            // 
            this.lbl_poblacion.AutoSize = true;
            this.lbl_poblacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poblacion.Location = new System.Drawing.Point(27, 84);
            this.lbl_poblacion.Name = "lbl_poblacion";
            this.lbl_poblacion.Size = new System.Drawing.Size(24, 20);
            this.lbl_poblacion.TabIndex = 2;
            this.lbl_poblacion.Text = "N:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(57, 81);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 3;
            // 
            // lbl_semilla
            // 
            this.lbl_semilla.AutoSize = true;
            this.lbl_semilla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semilla.Location = new System.Drawing.Point(198, 84);
            this.lbl_semilla.Name = "lbl_semilla";
            this.lbl_semilla.Size = new System.Drawing.Size(62, 20);
            this.lbl_semilla.TabIndex = 4;
            this.lbl_semilla.Text = "Semilla:";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(266, 81);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 26);
            this.txtSemilla.TabIndex = 5;
            // 
            // lbl_K
            // 
            this.lbl_K.AutoSize = true;
            this.lbl_K.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_K.Location = new System.Drawing.Point(430, 84);
            this.lbl_K.Name = "lbl_K";
            this.lbl_K.Size = new System.Drawing.Size(22, 20);
            this.lbl_K.TabIndex = 6;
            this.lbl_K.Text = "K:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(458, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblG.Location = new System.Drawing.Point(430, 120);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(26, 20);
            this.lblG.TabIndex = 8;
            this.lblG.Text = "G:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(458, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 9;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(27, 123);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(25, 20);
            this.lblC.TabIndex = 10;
            this.lblC.Text = "C:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(57, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 11;
            // 
            // GenerarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1112, 614);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_K);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.lbl_semilla);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lbl_poblacion);
            this.Controls.Add(this.ck_Multiplicativo);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarNumeros";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.CheckBox ck_Multiplicativo;
        private System.Windows.Forms.Label lbl_poblacion;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label lbl_semilla;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lbl_K;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox textBox3;
    }
}