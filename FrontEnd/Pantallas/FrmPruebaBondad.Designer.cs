namespace TP1SIM.FrontEnd.Pantallas
{
    partial class FrmPruebaBondad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblEstadistico = new System.Windows.Forms.Label();
            this.lblValorCritico = new System.Windows.Forms.Label();
            this.lblPruebaBondad = new System.Windows.Forms.Label();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(29, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(184, 20);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "ESTADÍSTICO DE PRUEBA:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(29, 41);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(184, 20);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "VALOR CRÍTICO (5% sign):";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(29, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(180, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "NOMBRE DE LA PRUEBA:";
            // 
            // lblEstadistico
            // 
            this.lblEstadistico.AutoSize = true;
            this.lblEstadistico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistico.ForeColor = System.Drawing.Color.Black;
            this.lblEstadistico.Location = new System.Drawing.Point(231, 13);
            this.lblEstadistico.Name = "lblEstadistico";
            this.lblEstadistico.Size = new System.Drawing.Size(154, 20);
            this.lblEstadistico.TabIndex = 6;
            this.lblEstadistico.Text = "estadistico de prueba";
            // 
            // lblValorCritico
            // 
            this.lblValorCritico.AutoSize = true;
            this.lblValorCritico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCritico.ForeColor = System.Drawing.Color.Black;
            this.lblValorCritico.Location = new System.Drawing.Point(231, 41);
            this.lblValorCritico.Name = "lblValorCritico";
            this.lblValorCritico.Size = new System.Drawing.Size(90, 20);
            this.lblValorCritico.TabIndex = 7;
            this.lblValorCritico.Text = "valor critico";
            // 
            // lblPruebaBondad
            // 
            this.lblPruebaBondad.AutoSize = true;
            this.lblPruebaBondad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPruebaBondad.ForeColor = System.Drawing.Color.Black;
            this.lblPruebaBondad.Location = new System.Drawing.Point(231, 71);
            this.lblPruebaBondad.Name = "lblPruebaBondad";
            this.lblPruebaBondad.Size = new System.Drawing.Size(115, 20);
            this.lblPruebaBondad.TabIndex = 8;
            this.lblPruebaBondad.Text = "prueba bondad";
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.BackColor = System.Drawing.Color.Black;
            this.lblConclusion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblConclusion.ForeColor = System.Drawing.Color.Yellow;
            this.lblConclusion.Location = new System.Drawing.Point(33, 114);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(88, 21);
            this.lblConclusion.TabIndex = 9;
            this.lblConclusion.Text = "conclusión";
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.AllowUserToAddRows = false;
            this.tablaProcedimiento.AllowUserToDeleteRows = false;
            this.tablaProcedimiento.AllowUserToOrderColumns = true;
            this.tablaProcedimiento.AllowUserToResizeColumns = false;
            this.tablaProcedimiento.AllowUserToResizeRows = false;
            this.tablaProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProcedimiento.BackgroundColor = System.Drawing.Color.Silver;
            this.tablaProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProcedimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProcedimiento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaProcedimiento.EnableHeadersVisualStyles = false;
            this.tablaProcedimiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tablaProcedimiento.Location = new System.Drawing.Point(37, 160);
            this.tablaProcedimiento.MultiSelect = false;
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.ReadOnly = true;
            this.tablaProcedimiento.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.tablaProcedimiento.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProcedimiento.Size = new System.Drawing.Size(909, 375);
            this.tablaProcedimiento.TabIndex = 18;
            // 
            // pbResultado
            // 
            this.pbResultado.Location = new System.Drawing.Point(876, 21);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(70, 70);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultado.TabIndex = 19;
            this.pbResultado.TabStop = false;
            // 
            // FrmPruebaBondad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 547);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.tablaProcedimiento);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.lblPruebaBondad);
            this.Controls.Add(this.lblValorCritico);
            this.Controls.Add(this.lblEstadistico);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "FrmPruebaBondad";
            this.Text = "FrmPruebaBondad";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblEstadistico;
        private System.Windows.Forms.Label lblValorCritico;
        private System.Windows.Forms.Label lblPruebaBondad;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.DataGridView tablaProcedimiento;
        private System.Windows.Forms.PictureBox pbResultado;
    }
}