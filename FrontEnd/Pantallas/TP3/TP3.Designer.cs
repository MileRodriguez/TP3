namespace TP1SIM.FrontEnd.Pantallas.TP3
{
    partial class TP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TP3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Uniforme = new System.Windows.Forms.Button();
            this.btn_Poisson = new System.Windows.Forms.Button();
            this.btn_Normal = new System.Windows.Forms.Button();
            this.btn_ExpNeg = new System.Windows.Forms.Button();
            this.gpBx_Uniforme = new System.Windows.Forms.GroupBox();
            this.btn_GenerarUniforme = new System.Windows.Forms.Button();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_A = new System.Windows.Forms.Label();
            this.gpBx_Normal = new System.Windows.Forms.GroupBox();
            this.rB_Convolucion = new System.Windows.Forms.RadioButton();
            this.rB_Box = new System.Windows.Forms.RadioButton();
            this.btn_GenerarNormal = new System.Windows.Forms.Button();
            this.txt_Varianza = new System.Windows.Forms.TextBox();
            this.txt_Media = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.gpBx_ExpNeg = new System.Windows.Forms.GroupBox();
            this.btn_GenerarExp = new System.Windows.Forms.Button();
            this.txt_MediaExp = new System.Windows.Forms.TextBox();
            this.txt_Lambda = new System.Windows.Forms.TextBox();
            this.lbl_MediaExp = new System.Windows.Forms.Label();
            this.lbl_Lambda = new System.Windows.Forms.Label();
            this.gpBx_Poisson = new System.Windows.Forms.GroupBox();
            this.txt_LambdaPoisson = new System.Windows.Forms.TextBox();
            this.btn_GenerarPoisson = new System.Windows.Forms.Button();
            this.lbl_LambdaPoisson = new System.Windows.Forms.Label();
            this.lbl_Muestra = new System.Windows.Forms.Label();
            this.dtv_nrosRnd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_Muestra = new System.Windows.Forms.NumericUpDown();
            this.num_Intervalos = new System.Windows.Forms.NumericUpDown();
            this.dgv_ChiCuadrado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpBx_Uniforme.SuspendLayout();
            this.gpBx_Normal.SuspendLayout();
            this.gpBx_ExpNeg.SuspendLayout();
            this.gpBx_Poisson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nrosRnd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Muestra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Intervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiCuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Uniforme);
            this.panel1.Controls.Add(this.btn_Poisson);
            this.panel1.Controls.Add(this.btn_Normal);
            this.panel1.Controls.Add(this.btn_ExpNeg);
            this.panel1.Location = new System.Drawing.Point(733, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 51);
            this.panel1.TabIndex = 2;
            // 
            // btn_Uniforme
            // 
            this.btn_Uniforme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Uniforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Uniforme.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Uniforme.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Uniforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Uniforme.Location = new System.Drawing.Point(0, 3);
            this.btn_Uniforme.Name = "btn_Uniforme";
            this.btn_Uniforme.Size = new System.Drawing.Size(98, 45);
            this.btn_Uniforme.TabIndex = 3;
            this.btn_Uniforme.Text = "Uniforme";
            this.btn_Uniforme.UseVisualStyleBackColor = false;
            this.btn_Uniforme.Click += new System.EventHandler(this.btn_Uniforme_Click);
            // 
            // btn_Poisson
            // 
            this.btn_Poisson.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Poisson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Poisson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Poisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Poisson.Location = new System.Drawing.Point(290, 3);
            this.btn_Poisson.Name = "btn_Poisson";
            this.btn_Poisson.Size = new System.Drawing.Size(98, 45);
            this.btn_Poisson.TabIndex = 6;
            this.btn_Poisson.Text = "Poisson";
            this.btn_Poisson.UseVisualStyleBackColor = false;
            this.btn_Poisson.Click += new System.EventHandler(this.btn_Poisson_Click);
            // 
            // btn_Normal
            // 
            this.btn_Normal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Normal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Normal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Normal.Location = new System.Drawing.Point(97, 3);
            this.btn_Normal.Name = "btn_Normal";
            this.btn_Normal.Size = new System.Drawing.Size(98, 45);
            this.btn_Normal.TabIndex = 4;
            this.btn_Normal.Text = "Normal";
            this.btn_Normal.UseVisualStyleBackColor = false;
            this.btn_Normal.Click += new System.EventHandler(this.btn_Normal_Click);
            // 
            // btn_ExpNeg
            // 
            this.btn_ExpNeg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ExpNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExpNeg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ExpNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExpNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExpNeg.Location = new System.Drawing.Point(194, 3);
            this.btn_ExpNeg.Name = "btn_ExpNeg";
            this.btn_ExpNeg.Size = new System.Drawing.Size(98, 45);
            this.btn_ExpNeg.TabIndex = 5;
            this.btn_ExpNeg.Text = "Exponencial Negativa";
            this.btn_ExpNeg.UseVisualStyleBackColor = false;
            this.btn_ExpNeg.Click += new System.EventHandler(this.btn_ExpNeg_Click);
            // 
            // gpBx_Uniforme
            // 
            this.gpBx_Uniforme.Controls.Add(this.btn_GenerarUniforme);
            this.gpBx_Uniforme.Controls.Add(this.txt_B);
            this.gpBx_Uniforme.Controls.Add(this.txt_A);
            this.gpBx_Uniforme.Controls.Add(this.lbl_B);
            this.gpBx_Uniforme.Controls.Add(this.lbl_A);
            this.gpBx_Uniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBx_Uniforme.Location = new System.Drawing.Point(231, 100);
            this.gpBx_Uniforme.Name = "gpBx_Uniforme";
            this.gpBx_Uniforme.Size = new System.Drawing.Size(890, 68);
            this.gpBx_Uniforme.TabIndex = 3;
            this.gpBx_Uniforme.TabStop = false;
            this.gpBx_Uniforme.Text = "Parámetros";
            this.gpBx_Uniforme.Visible = false;
            // 
            // btn_GenerarUniforme
            // 
            this.btn_GenerarUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarUniforme.Location = new System.Drawing.Point(767, 38);
            this.btn_GenerarUniforme.Name = "btn_GenerarUniforme";
            this.btn_GenerarUniforme.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerarUniforme.TabIndex = 4;
            this.btn_GenerarUniforme.Text = "Generar";
            this.btn_GenerarUniforme.UseVisualStyleBackColor = true;
            this.btn_GenerarUniforme.Click += new System.EventHandler(this.btn_GenerarUniforme_Click);
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(460, 27);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(100, 22);
            this.txt_B.TabIndex = 3;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(144, 27);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(100, 22);
            this.txt_A.TabIndex = 2;
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(353, 30);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(101, 16);
            this.lbl_B.TabIndex = 1;
            this.lbl_B.Text = "Límite Derecho:";
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(34, 30);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(104, 16);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "Límite izquierdo:";
            // 
            // gpBx_Normal
            // 
            this.gpBx_Normal.Controls.Add(this.rB_Convolucion);
            this.gpBx_Normal.Controls.Add(this.rB_Box);
            this.gpBx_Normal.Controls.Add(this.btn_GenerarNormal);
            this.gpBx_Normal.Controls.Add(this.txt_Varianza);
            this.gpBx_Normal.Controls.Add(this.txt_Media);
            this.gpBx_Normal.Controls.Add(this.label1);
            this.gpBx_Normal.Controls.Add(this.lbl_Media);
            this.gpBx_Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBx_Normal.Location = new System.Drawing.Point(231, 100);
            this.gpBx_Normal.Name = "gpBx_Normal";
            this.gpBx_Normal.Size = new System.Drawing.Size(890, 67);
            this.gpBx_Normal.TabIndex = 4;
            this.gpBx_Normal.TabStop = false;
            this.gpBx_Normal.Text = "Parámetros";
            this.gpBx_Normal.Visible = false;
            // 
            // rB_Convolucion
            // 
            this.rB_Convolucion.AutoSize = true;
            this.rB_Convolucion.Location = new System.Drawing.Point(509, 29);
            this.rB_Convolucion.Name = "rB_Convolucion";
            this.rB_Convolucion.Size = new System.Drawing.Size(100, 20);
            this.rB_Convolucion.TabIndex = 10;
            this.rB_Convolucion.TabStop = true;
            this.rB_Convolucion.Text = "Convolución";
            this.rB_Convolucion.UseVisualStyleBackColor = true;
            // 
            // rB_Box
            // 
            this.rB_Box.AutoSize = true;
            this.rB_Box.Location = new System.Drawing.Point(391, 28);
            this.rB_Box.Name = "rB_Box";
            this.rB_Box.Size = new System.Drawing.Size(89, 20);
            this.rB_Box.TabIndex = 9;
            this.rB_Box.TabStop = true;
            this.rB_Box.Text = "Box-Muller";
            this.rB_Box.UseVisualStyleBackColor = true;
            // 
            // btn_GenerarNormal
            // 
            this.btn_GenerarNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarNormal.Location = new System.Drawing.Point(767, 38);
            this.btn_GenerarNormal.Name = "btn_GenerarNormal";
            this.btn_GenerarNormal.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerarNormal.TabIndex = 4;
            this.btn_GenerarNormal.Text = "Generar";
            this.btn_GenerarNormal.UseVisualStyleBackColor = true;
            // 
            // txt_Varianza
            // 
            this.txt_Varianza.Location = new System.Drawing.Point(262, 27);
            this.txt_Varianza.Name = "txt_Varianza";
            this.txt_Varianza.Size = new System.Drawing.Size(100, 22);
            this.txt_Varianza.TabIndex = 3;
            // 
            // txt_Media
            // 
            this.txt_Media.Location = new System.Drawing.Point(81, 27);
            this.txt_Media.Name = "txt_Media";
            this.txt_Media.Size = new System.Drawing.Size(100, 22);
            this.txt_Media.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varianza:";
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.Location = new System.Drawing.Point(26, 30);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(49, 16);
            this.lbl_Media.TabIndex = 0;
            this.lbl_Media.Text = "Media:";
            // 
            // gpBx_ExpNeg
            // 
            this.gpBx_ExpNeg.Controls.Add(this.btn_GenerarExp);
            this.gpBx_ExpNeg.Controls.Add(this.txt_MediaExp);
            this.gpBx_ExpNeg.Controls.Add(this.txt_Lambda);
            this.gpBx_ExpNeg.Controls.Add(this.lbl_MediaExp);
            this.gpBx_ExpNeg.Controls.Add(this.lbl_Lambda);
            this.gpBx_ExpNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBx_ExpNeg.Location = new System.Drawing.Point(231, 100);
            this.gpBx_ExpNeg.Name = "gpBx_ExpNeg";
            this.gpBx_ExpNeg.Size = new System.Drawing.Size(890, 68);
            this.gpBx_ExpNeg.TabIndex = 6;
            this.gpBx_ExpNeg.TabStop = false;
            this.gpBx_ExpNeg.Text = "Parámetros";
            this.gpBx_ExpNeg.Visible = false;
            // 
            // btn_GenerarExp
            // 
            this.btn_GenerarExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarExp.Location = new System.Drawing.Point(767, 40);
            this.btn_GenerarExp.Name = "btn_GenerarExp";
            this.btn_GenerarExp.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerarExp.TabIndex = 4;
            this.btn_GenerarExp.Text = "Generar";
            this.btn_GenerarExp.UseVisualStyleBackColor = true;
            // 
            // txt_MediaExp
            // 
            this.txt_MediaExp.Location = new System.Drawing.Point(258, 27);
            this.txt_MediaExp.Name = "txt_MediaExp";
            this.txt_MediaExp.Size = new System.Drawing.Size(100, 22);
            this.txt_MediaExp.TabIndex = 3;
            // 
            // txt_Lambda
            // 
            this.txt_Lambda.Location = new System.Drawing.Point(86, 27);
            this.txt_Lambda.Name = "txt_Lambda";
            this.txt_Lambda.Size = new System.Drawing.Size(100, 22);
            this.txt_Lambda.TabIndex = 2;
            // 
            // lbl_MediaExp
            // 
            this.lbl_MediaExp.AutoSize = true;
            this.lbl_MediaExp.Location = new System.Drawing.Point(207, 30);
            this.lbl_MediaExp.Name = "lbl_MediaExp";
            this.lbl_MediaExp.Size = new System.Drawing.Size(49, 16);
            this.lbl_MediaExp.TabIndex = 1;
            this.lbl_MediaExp.Text = "Media:";
            // 
            // lbl_Lambda
            // 
            this.lbl_Lambda.AutoSize = true;
            this.lbl_Lambda.Location = new System.Drawing.Point(26, 30);
            this.lbl_Lambda.Name = "lbl_Lambda";
            this.lbl_Lambda.Size = new System.Drawing.Size(61, 16);
            this.lbl_Lambda.TabIndex = 0;
            this.lbl_Lambda.Text = "Lambda:";
            // 
            // gpBx_Poisson
            // 
            this.gpBx_Poisson.Controls.Add(this.txt_LambdaPoisson);
            this.gpBx_Poisson.Controls.Add(this.btn_GenerarPoisson);
            this.gpBx_Poisson.Controls.Add(this.lbl_LambdaPoisson);
            this.gpBx_Poisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBx_Poisson.Location = new System.Drawing.Point(231, 100);
            this.gpBx_Poisson.Name = "gpBx_Poisson";
            this.gpBx_Poisson.Size = new System.Drawing.Size(890, 66);
            this.gpBx_Poisson.TabIndex = 7;
            this.gpBx_Poisson.TabStop = false;
            this.gpBx_Poisson.Text = "Parámetros";
            this.gpBx_Poisson.Visible = false;
            this.gpBx_Poisson.Click += new System.EventHandler(this.btn_Poisson_Click);
            // 
            // txt_LambdaPoisson
            // 
            this.txt_LambdaPoisson.Location = new System.Drawing.Point(86, 27);
            this.txt_LambdaPoisson.Name = "txt_LambdaPoisson";
            this.txt_LambdaPoisson.Size = new System.Drawing.Size(100, 22);
            this.txt_LambdaPoisson.TabIndex = 2;
            // 
            // btn_GenerarPoisson
            // 
            this.btn_GenerarPoisson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarPoisson.Location = new System.Drawing.Point(771, 37);
            this.btn_GenerarPoisson.Name = "btn_GenerarPoisson";
            this.btn_GenerarPoisson.Size = new System.Drawing.Size(75, 23);
            this.btn_GenerarPoisson.TabIndex = 3;
            this.btn_GenerarPoisson.Text = "Generar";
            this.btn_GenerarPoisson.UseVisualStyleBackColor = true;
            // 
            // lbl_LambdaPoisson
            // 
            this.lbl_LambdaPoisson.AutoSize = true;
            this.lbl_LambdaPoisson.Location = new System.Drawing.Point(26, 30);
            this.lbl_LambdaPoisson.Name = "lbl_LambdaPoisson";
            this.lbl_LambdaPoisson.Size = new System.Drawing.Size(61, 16);
            this.lbl_LambdaPoisson.TabIndex = 0;
            this.lbl_LambdaPoisson.Text = "Lambda:";
            // 
            // lbl_Muestra
            // 
            this.lbl_Muestra.AutoSize = true;
            this.lbl_Muestra.Location = new System.Drawing.Point(261, 15);
            this.lbl_Muestra.Name = "lbl_Muestra";
            this.lbl_Muestra.Size = new System.Drawing.Size(59, 16);
            this.lbl_Muestra.TabIndex = 12;
            this.lbl_Muestra.Text = "Muestra:";
            // 
            // dtv_nrosRnd
            // 
            this.dtv_nrosRnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_nrosRnd.Location = new System.Drawing.Point(25, 185);
            this.dtv_nrosRnd.Name = "dtv_nrosRnd";
            this.dtv_nrosRnd.Size = new System.Drawing.Size(190, 402);
            this.dtv_nrosRnd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de Intervalos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.num_Muestra);
            this.panel2.Controls.Add(this.num_Intervalos);
            this.panel2.Controls.Add(this.lbl_Muestra);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(231, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 48);
            this.panel2.TabIndex = 14;
            // 
            // num_Muestra
            // 
            this.num_Muestra.Location = new System.Drawing.Point(329, 11);
            this.num_Muestra.Name = "num_Muestra";
            this.num_Muestra.Size = new System.Drawing.Size(91, 22);
            this.num_Muestra.TabIndex = 14;
            // 
            // num_Intervalos
            // 
            this.num_Intervalos.Location = new System.Drawing.Point(151, 11);
            this.num_Intervalos.Name = "num_Intervalos";
            this.num_Intervalos.Size = new System.Drawing.Size(91, 22);
            this.num_Intervalos.TabIndex = 13;
            // 
            // dgv_ChiCuadrado
            // 
            this.dgv_ChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiCuadrado.Location = new System.Drawing.Point(237, 185);
            this.dgv_ChiCuadrado.Name = "dgv_ChiCuadrado";
            this.dgv_ChiCuadrado.Size = new System.Drawing.Size(563, 402);
            this.dgv_ChiCuadrado.TabIndex = 15;
            // 
            // TP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 606);
            this.Controls.Add(this.dgv_ChiCuadrado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gpBx_ExpNeg);
            this.Controls.Add(this.dtv_nrosRnd);
            this.Controls.Add(this.gpBx_Normal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpBx_Poisson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBx_Uniforme);
            this.Name = "TP3";
            this.Text = "Trabajo Práctico 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gpBx_Uniforme.ResumeLayout(false);
            this.gpBx_Uniforme.PerformLayout();
            this.gpBx_Normal.ResumeLayout(false);
            this.gpBx_Normal.PerformLayout();
            this.gpBx_ExpNeg.ResumeLayout(false);
            this.gpBx_ExpNeg.PerformLayout();
            this.gpBx_Poisson.ResumeLayout(false);
            this.gpBx_Poisson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nrosRnd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Muestra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Intervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiCuadrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Uniforme;
        private System.Windows.Forms.Button btn_Poisson;
        private System.Windows.Forms.Button btn_Normal;
        private System.Windows.Forms.Button btn_ExpNeg;
        private System.Windows.Forms.GroupBox gpBx_Uniforme;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.GroupBox gpBx_Normal;
        private System.Windows.Forms.TextBox txt_Varianza;
        private System.Windows.Forms.TextBox txt_Media;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Media;
        private System.Windows.Forms.GroupBox gpBx_ExpNeg;
        private System.Windows.Forms.TextBox txt_MediaExp;
        private System.Windows.Forms.TextBox txt_Lambda;
        private System.Windows.Forms.Label lbl_MediaExp;
        private System.Windows.Forms.Label lbl_Lambda;
        private System.Windows.Forms.GroupBox gpBx_Poisson;
        private System.Windows.Forms.TextBox txt_LambdaPoisson;
        private System.Windows.Forms.Label lbl_LambdaPoisson;
        private System.Windows.Forms.Button btn_GenerarPoisson;
        private System.Windows.Forms.Button btn_GenerarExp;
        private System.Windows.Forms.Button btn_GenerarUniforme;
        private System.Windows.Forms.Button btn_GenerarNormal;
        private System.Windows.Forms.DataGridView dtv_nrosRnd;
        private System.Windows.Forms.Label lbl_Muestra;
        private System.Windows.Forms.RadioButton rB_Convolucion;
        private System.Windows.Forms.RadioButton rB_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown num_Muestra;
        private System.Windows.Forms.NumericUpDown num_Intervalos;
        private System.Windows.Forms.DataGridView dgv_ChiCuadrado;
    }
}