
namespace TP1SIM.FrontEnd.Pantallas
{
    partial class Chi_CuadradoCM_Generador
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTamañoMuestra = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.btn_volverMenu = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_resHipotesis = new System.Windows.Forms.Label();
            this.gdrSerieAleatoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_Multiplicativo = new System.Windows.Forms.CheckBox();
            this.checkGyK = new System.Windows.Forms.CheckBox();
            this.checkIncluir1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtG = new System.Windows.Forms.TextBox();
            this.TxtK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtXo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formula_rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.next_rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tamaño de Muestra (N)";
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTamañoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(267, 30);
            this.TxtTamañoMuestra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(62, 29);
            this.TxtTamañoMuestra.TabIndex = 0;
            // 
            // btn_generar
            // 
            this.btn_generar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_generar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_generar.Location = new System.Drawing.Point(142, 656);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(111, 50);
            this.btn_generar.TabIndex = 14;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = false;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // btn_volverMenu
            // 
            this.btn_volverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volverMenu.Location = new System.Drawing.Point(27, 656);
            this.btn_volverMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volverMenu.Name = "btn_volverMenu";
            this.btn_volverMenu.Size = new System.Drawing.Size(107, 50);
            this.btn_volverMenu.TabIndex = 16;
            this.btn_volverMenu.Text = "Volver al Menu";
            this.btn_volverMenu.UseVisualStyleBackColor = true;
            this.btn_volverMenu.Click += new System.EventHandler(this.btn_volverMenu_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(261, 656);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(117, 50);
            this.btn_limpiar.TabIndex = 17;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_resHipotesis
            // 
            this.lbl_resHipotesis.AutoSize = true;
            this.lbl_resHipotesis.BackColor = System.Drawing.Color.Black;
            this.lbl_resHipotesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resHipotesis.ForeColor = System.Drawing.Color.Gold;
            this.lbl_resHipotesis.Location = new System.Drawing.Point(324, 713);
            this.lbl_resHipotesis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resHipotesis.Name = "lbl_resHipotesis";
            this.lbl_resHipotesis.Size = new System.Drawing.Size(0, 29);
            this.lbl_resHipotesis.TabIndex = 24;
            // 
            // gdrSerieAleatoria
            // 
            this.gdrSerieAleatoria.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdrSerieAleatoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gdrSerieAleatoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gdrSerieAleatoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gdrSerieAleatoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSerieAleatoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.formula_rnd,
            this.next_rnd,
            this.rnd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdrSerieAleatoria.DefaultCellStyle = dataGridViewCellStyle5;
            this.gdrSerieAleatoria.Location = new System.Drawing.Point(21, 26);
            this.gdrSerieAleatoria.Margin = new System.Windows.Forms.Padding(4);
            this.gdrSerieAleatoria.Name = "gdrSerieAleatoria";
            this.gdrSerieAleatoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdrSerieAleatoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdrSerieAleatoria.RowHeadersVisible = false;
            this.gdrSerieAleatoria.RowHeadersWidth = 51;
            this.gdrSerieAleatoria.Size = new System.Drawing.Size(1000, 686);
            this.gdrSerieAleatoria.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.ck_Multiplicativo);
            this.groupBox1.Controls.Add(this.checkGyK);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_volverMenu);
            this.groupBox1.Controls.Add(this.checkIncluir1);
            this.groupBox1.Controls.Add(this.TxtTamañoMuestra);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(408, 728);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // ck_Multiplicativo
            // 
            this.ck_Multiplicativo.AutoSize = true;
            this.ck_Multiplicativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_Multiplicativo.Location = new System.Drawing.Point(27, 188);
            this.ck_Multiplicativo.Margin = new System.Windows.Forms.Padding(4);
            this.ck_Multiplicativo.Name = "ck_Multiplicativo";
            this.ck_Multiplicativo.Size = new System.Drawing.Size(207, 28);
            this.ck_Multiplicativo.TabIndex = 27;
            this.ck_Multiplicativo.Text = "Método Multiplicativo";
            this.ck_Multiplicativo.UseVisualStyleBackColor = true;
            this.ck_Multiplicativo.CheckedChanged += new System.EventHandler(this.ck_Multiplicativo_CheckedChanged);
            // 
            // checkGyK
            // 
            this.checkGyK.AutoSize = true;
            this.checkGyK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGyK.Location = new System.Drawing.Point(27, 135);
            this.checkGyK.Margin = new System.Windows.Forms.Padding(4);
            this.checkGyK.Name = "checkGyK";
            this.checkGyK.Size = new System.Drawing.Size(308, 28);
            this.checkGyK.TabIndex = 20;
            this.checkGyK.Text = "¿Utilizar G y K para calculo ideal?";
            this.checkGyK.UseVisualStyleBackColor = true;
            this.checkGyK.CheckedChanged += new System.EventHandler(this.checkGyK_CheckedChanged);
            // 
            // checkIncluir1
            // 
            this.checkIncluir1.AutoSize = true;
            this.checkIncluir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIncluir1.Location = new System.Drawing.Point(27, 84);
            this.checkIncluir1.Margin = new System.Windows.Forms.Padding(4);
            this.checkIncluir1.Name = "checkIncluir1";
            this.checkIncluir1.Size = new System.Drawing.Size(127, 28);
            this.checkIncluir1.TabIndex = 19;
            this.checkIncluir1.Text = "No incluir 1";
            this.checkIncluir1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtG);
            this.groupBox3.Controls.Add(this.TxtK);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtM);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtA);
            this.groupBox3.Controls.Add(this.TxtXo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 241);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(351, 396);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // TxtG
            // 
            this.TxtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtG.Location = new System.Drawing.Point(65, 325);
            this.TxtG.Margin = new System.Windows.Forms.Padding(4);
            this.TxtG.Name = "TxtG";
            this.TxtG.Size = new System.Drawing.Size(260, 29);
            this.TxtG.TabIndex = 19;
            // 
            // TxtK
            // 
            this.TxtK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtK.Location = new System.Drawing.Point(65, 272);
            this.TxtK.Margin = new System.Windows.Forms.Padding(4);
            this.TxtK.Name = "TxtK";
            this.TxtK.Size = new System.Drawing.Size(260, 29);
            this.TxtK.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "g";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Variables";
            // 
            // TxtM
            // 
            this.TxtM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtM.Location = new System.Drawing.Point(65, 219);
            this.TxtM.Margin = new System.Windows.Forms.Padding(4);
            this.TxtM.Name = "TxtM";
            this.TxtM.Size = new System.Drawing.Size(260, 29);
            this.TxtM.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "m";
            // 
            // TxtC
            // 
            this.TxtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtC.Location = new System.Drawing.Point(65, 165);
            this.TxtC.Margin = new System.Windows.Forms.Padding(4);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(260, 29);
            this.TxtC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Xo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "c";
            // 
            // TxtA
            // 
            this.TxtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtA.Location = new System.Drawing.Point(65, 108);
            this.TxtA.Margin = new System.Windows.Forms.Padding(4);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(260, 29);
            this.TxtA.TabIndex = 6;
            // 
            // TxtXo
            // 
            this.TxtXo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtXo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtXo.Location = new System.Drawing.Point(65, 52);
            this.TxtXo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtXo.Name = "TxtXo";
            this.TxtXo.Size = new System.Drawing.Size(260, 29);
            this.TxtXo.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_resHipotesis);
            this.groupBox2.Controls.Add(this.gdrSerieAleatoria);
            this.groupBox2.Location = new System.Drawing.Point(429, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1041, 728);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteracion";
            this.iteracion.MinimumWidth = 6;
            this.iteracion.Name = "iteracion";
            this.iteracion.Width = 250;
            // 
            // formula_rnd
            // 
            this.formula_rnd.HeaderText = "a*xi+c";
            this.formula_rnd.MinimumWidth = 6;
            this.formula_rnd.Name = "formula_rnd";
            this.formula_rnd.Width = 250;
            // 
            // next_rnd
            // 
            this.next_rnd.HeaderText = "Siguiente";
            this.next_rnd.MinimumWidth = 6;
            this.next_rnd.Name = "next_rnd";
            this.next_rnd.Width = 250;
            // 
            // rnd
            // 
            this.rnd.HeaderText = "RND";
            this.rnd.MinimumWidth = 6;
            this.rnd.Name = "rnd";
            this.rnd.Width = 250;
            // 
            // Chi_CuadradoCM_Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1483, 756);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chi_CuadradoCM_Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador";
            this.Load += new System.EventHandler(this.Chi_CuadradoCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrSerieAleatoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTamañoMuestra;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Button btn_volverMenu;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_resHipotesis;
        private System.Windows.Forms.DataGridView gdrSerieAleatoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtM;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtXo;
        private System.Windows.Forms.TextBox TxtG;
        private System.Windows.Forms.TextBox TxtK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkGyK;
        private System.Windows.Forms.CheckBox checkIncluir1;
        private System.Windows.Forms.CheckBox ck_Multiplicativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn formula_rnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn next_rnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd;
        private System.Windows.Forms.Timer timer1;
    }
}