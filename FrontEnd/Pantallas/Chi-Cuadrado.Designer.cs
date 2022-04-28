
namespace TP1SIM.FrontEnd.Pantallas
{
    partial class Chi_Cuadrado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.TxtTamañoMuestra = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_volverMenu = new System.Windows.Forms.Button();
            this.tabla_serie = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chrt_graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_resHipotesis = new System.Windows.Forms.Label();
            this.txtValorTabulado = new System.Windows.Forms.TextBox();
            this.txtNivelSignificancia = new System.Windows.Forms.TextBox();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            this.lblNivelSignificancia = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_serie)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño de Muestra (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de Intervalos";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(180, 75);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(32, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(218, 75);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(32, 19);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(256, 75);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(39, 19);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(301, 75);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(39, 19);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTamañoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(198, 30);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(47, 24);
            this.TxtTamañoMuestra.TabIndex = 0;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar.Location = new System.Drawing.Point(133, 122);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(83, 31);
            this.btn_generar.TabIndex = 6;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(255, 632);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(88, 41);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_volverMenu
            // 
            this.btn_volverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volverMenu.Location = new System.Drawing.Point(63, 632);
            this.btn_volverMenu.Name = "btn_volverMenu";
            this.btn_volverMenu.Size = new System.Drawing.Size(80, 41);
            this.btn_volverMenu.TabIndex = 8;
            this.btn_volverMenu.Text = "Volver al Menu";
            this.btn_volverMenu.UseVisualStyleBackColor = true;
            this.btn_volverMenu.Click += new System.EventHandler(this.btn_volverMenu_Click);
            // 
            // tabla_serie
            // 
            this.tabla_serie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla_serie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_serie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla_serie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_serie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tabla_serie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_serie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.serie});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_serie.DefaultCellStyle = dataGridViewCellStyle14;
            this.tabla_serie.Location = new System.Drawing.Point(106, 204);
            this.tabla_serie.Name = "tabla_serie";
            this.tabla_serie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_serie.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabla_serie.RowHeadersVisible = false;
            this.tabla_serie.Size = new System.Drawing.Size(200, 411);
            this.tabla_serie.TabIndex = 9;
            // 
            // n
            // 
            this.n.HeaderText = "N";
            this.n.Name = "n";
            this.n.Width = 80;
            // 
            // serie
            // 
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtTamañoMuestra);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 168);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chrt_graf);
            this.groupBox2.Controls.Add(this.lbl_resHipotesis);
            this.groupBox2.Controls.Add(this.txtValorTabulado);
            this.groupBox2.Controls.Add(this.txtNivelSignificancia);
            this.groupBox2.Controls.Add(this.lblValorTabulado);
            this.groupBox2.Controls.Add(this.lblNivelSignificancia);
            this.groupBox2.Controls.Add(this.tabla);
            this.groupBox2.Location = new System.Drawing.Point(404, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 652);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // chrt_graf
            // 
            chartArea3.Name = "ChartArea1";
            this.chrt_graf.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chrt_graf.Legends.Add(legend3);
            this.chrt_graf.Location = new System.Drawing.Point(315, 336);
            this.chrt_graf.Name = "chrt_graf";
            this.chrt_graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Frecuencia Observada";
            this.chrt_graf.Series.Add(series3);
            this.chrt_graf.Size = new System.Drawing.Size(479, 300);
            this.chrt_graf.TabIndex = 18;
            this.chrt_graf.Text = "Histograma";
            // 
            // lbl_resHipotesis
            // 
            this.lbl_resHipotesis.AutoSize = true;
            this.lbl_resHipotesis.BackColor = System.Drawing.Color.Black;
            this.lbl_resHipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resHipotesis.ForeColor = System.Drawing.Color.Gold;
            this.lbl_resHipotesis.Location = new System.Drawing.Point(18, 574);
            this.lbl_resHipotesis.Name = "lbl_resHipotesis";
            this.lbl_resHipotesis.Size = new System.Drawing.Size(0, 25);
            this.lbl_resHipotesis.TabIndex = 17;
            // 
            // txtValorTabulado
            // 
            this.txtValorTabulado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTabulado.Location = new System.Drawing.Point(134, 495);
            this.txtValorTabulado.Name = "txtValorTabulado";
            this.txtValorTabulado.Size = new System.Drawing.Size(88, 22);
            this.txtValorTabulado.TabIndex = 16;
            // 
            // txtNivelSignificancia
            // 
            this.txtNivelSignificancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivelSignificancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelSignificancia.Location = new System.Drawing.Point(134, 404);
            this.txtNivelSignificancia.Name = "txtNivelSignificancia";
            this.txtNivelSignificancia.Size = new System.Drawing.Size(88, 22);
            this.txtNivelSignificancia.TabIndex = 15;
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTabulado.Location = new System.Drawing.Point(83, 454);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(139, 24);
            this.lblValorTabulado.TabIndex = 14;
            this.lblValorTabulado.Text = "Valor Tabulado";
            // 
            // lblNivelSignificancia
            // 
            this.lblNivelSignificancia.AutoSize = true;
            this.lblNivelSignificancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelSignificancia.Location = new System.Drawing.Point(61, 361);
            this.lblNivelSignificancia.Name = "lblNivelSignificancia";
            this.lblNivelSignificancia.Size = new System.Drawing.Size(189, 24);
            this.lblNivelSignificancia.TabIndex = 13;
            this.lblNivelSignificancia.Text = "Nivel de Significancia";
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desde,
            this.hasta,
            this.mc,
            this.fo,
            this.fe,
            this.c,
            this.cac});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle17;
            this.tabla.Location = new System.Drawing.Point(24, 19);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(770, 292);
            this.tabla.TabIndex = 12;
            // 
            // desde
            // 
            this.desde.HeaderText = "Lim Inferior";
            this.desde.Name = "desde";
            this.desde.Width = 115;
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Lim Superior";
            this.hasta.Name = "hasta";
            this.hasta.Width = 125;
            // 
            // mc
            // 
            this.mc.HeaderText = "MC";
            this.mc.Name = "mc";
            // 
            // fo
            // 
            this.fo.HeaderText = "FO";
            this.fo.Name = "fo";
            this.fo.Width = 95;
            // 
            // fe
            // 
            this.fe.HeaderText = "FE";
            this.fe.Name = "fe";
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            // 
            // cac
            // 
            this.cac.HeaderText = "C(Acumulado)";
            this.cac.Name = "cac";
            this.cac.Width = 130;
            // 
            // Chi_Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 690);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabla_serie);
            this.Controls.Add(this.btn_volverMenu);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chi_Cuadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi_Cuadrado";
            this.Load += new System.EventHandler(this.Chi_Cuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_serie)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_graf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.TextBox TxtTamañoMuestra;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_volverMenu;
        private System.Windows.Forms.DataGridView tabla_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.TextBox txtValorTabulado;
        private System.Windows.Forms.TextBox txtNivelSignificancia;
        private System.Windows.Forms.Label lblValorTabulado;
        private System.Windows.Forms.Label lblNivelSignificancia;
        private System.Windows.Forms.Label lbl_resHipotesis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_graf;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
    }
}