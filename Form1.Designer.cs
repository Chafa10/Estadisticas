namespace TP1ProbabilidadYEstadistica
{
    partial class Estadistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadistica));
            this.txt_Datos = new System.Windows.Forms.TextBox();
            this.btn_AgregarDato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TotalFrecuencia = new System.Windows.Forms.Label();
            this.lbl_TotalXPorF = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl_Variancia = new System.Windows.Forms.Label();
            this.txt_Frecuencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_frecuenciaSimple = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CoeficienteVariacion = new System.Windows.Forms.Label();
            this.lbl_Promedio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_CV = new System.Windows.Forms.Label();
            this.lbl_Mediana = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Moda = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl_DesvioStandard = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.groupBox_Agrupados = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_Agrupados = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_Desagrupados = new System.Windows.Forms.RadioButton();
            this.groupBoxAgrupados = new System.Windows.Forms.GroupBox();
            this.btn_HacerGrafico = new System.Windows.Forms.Button();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).BeginInit();
            this.groupBox_Agrupados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxAgrupados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Datos
            // 
            this.txt_Datos.Location = new System.Drawing.Point(46, 66);
            this.txt_Datos.MaxLength = 4;
            this.txt_Datos.Name = "txt_Datos";
            this.txt_Datos.ShortcutsEnabled = false;
            this.txt_Datos.Size = new System.Drawing.Size(129, 22);
            this.txt_Datos.TabIndex = 0;
            this.txt_Datos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDatos);
            // 
            // btn_AgregarDato
            // 
            this.btn_AgregarDato.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarDato.Location = new System.Drawing.Point(46, 195);
            this.btn_AgregarDato.Name = "btn_AgregarDato";
            this.btn_AgregarDato.Size = new System.Drawing.Size(123, 30);
            this.btn_AgregarDato.TabIndex = 2;
            this.btn_AgregarDato.Text = "&Agregar";
            this.btn_AgregarDato.UseVisualStyleBackColor = true;
            this.btn_AgregarDato.Click += new System.EventHandler(this.btn_AgregarDato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese dato";
            // 
            // lbl_TotalFrecuencia
            // 
            this.lbl_TotalFrecuencia.AutoSize = true;
            this.lbl_TotalFrecuencia.Location = new System.Drawing.Point(176, 28);
            this.lbl_TotalFrecuencia.Name = "lbl_TotalFrecuencia";
            this.lbl_TotalFrecuencia.Size = new System.Drawing.Size(0, 16);
            this.lbl_TotalFrecuencia.TabIndex = 5;
            // 
            // lbl_TotalXPorF
            // 
            this.lbl_TotalXPorF.AutoSize = true;
            this.lbl_TotalXPorF.Location = new System.Drawing.Point(176, 63);
            this.lbl_TotalXPorF.Name = "lbl_TotalXPorF";
            this.lbl_TotalXPorF.Size = new System.Drawing.Size(0, 16);
            this.lbl_TotalXPorF.TabIndex = 11;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(253, 28);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(117, 16);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Total Variancia:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(458, 29);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(167, 16);
            this.lbl4.TabIndex = 14;
            this.lbl4.Text = "Total Desvio Standard:";
            // 
            // lbl_Variancia
            // 
            this.lbl_Variancia.AutoSize = true;
            this.lbl_Variancia.Location = new System.Drawing.Point(366, 28);
            this.lbl_Variancia.Name = "lbl_Variancia";
            this.lbl_Variancia.Size = new System.Drawing.Size(0, 16);
            this.lbl_Variancia.TabIndex = 13;
            // 
            // txt_Frecuencia
            // 
            this.txt_Frecuencia.Location = new System.Drawing.Point(46, 150);
            this.txt_Frecuencia.MaxLength = 4;
            this.txt_Frecuencia.Name = "txt_Frecuencia";
            this.txt_Frecuencia.ShortcutsEnabled = false;
            this.txt_Frecuencia.Size = new System.Drawing.Size(129, 22);
            this.txt_Frecuencia.TabIndex = 1;
            this.txt_Frecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarDato2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ingrese su frecuencia";
            // 
            // lbl_frecuenciaSimple
            // 
            this.lbl_frecuenciaSimple.AutoSize = true;
            this.lbl_frecuenciaSimple.Location = new System.Drawing.Point(6, 28);
            this.lbl_frecuenciaSimple.Name = "lbl_frecuenciaSimple";
            this.lbl_frecuenciaSimple.Size = new System.Drawing.Size(180, 16);
            this.lbl_frecuenciaSimple.TabIndex = 17;
            this.lbl_frecuenciaSimple.Text = "Total Frecuencia Simple:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Enabled = false;
            this.btn_Calcular.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(47, 231);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(122, 34);
            this.btn_Calcular.TabIndex = 18;
            this.btn_Calcular.Text = "&Finalizar";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 63);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 16);
            this.lbl2.TabIndex = 19;
            this.lbl2.Text = "Total De X Por F:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_CoeficienteVariacion);
            this.groupBox1.Controls.Add(this.lbl_Promedio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_CV);
            this.groupBox1.Controls.Add(this.lbl_Mediana);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_Moda);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl_DesvioStandard);
            this.groupBox1.Controls.Add(this.lbl_frecuenciaSimple);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl_TotalFrecuencia);
            this.groupBox1.Controls.Add(this.lbl_TotalXPorF);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl_Variancia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables";
            // 
            // lbl_CoeficienteVariacion
            // 
            this.lbl_CoeficienteVariacion.AutoSize = true;
            this.lbl_CoeficienteVariacion.Location = new System.Drawing.Point(764, 28);
            this.lbl_CoeficienteVariacion.Name = "lbl_CoeficienteVariacion";
            this.lbl_CoeficienteVariacion.Size = new System.Drawing.Size(0, 16);
            this.lbl_CoeficienteVariacion.TabIndex = 28;
            // 
            // lbl_Promedio
            // 
            this.lbl_Promedio.AutoSize = true;
            this.lbl_Promedio.Location = new System.Drawing.Point(363, 64);
            this.lbl_Promedio.Name = "lbl_Promedio";
            this.lbl_Promedio.Size = new System.Drawing.Size(0, 16);
            this.lbl_Promedio.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Promedio";
            // 
            // lbl_CV
            // 
            this.lbl_CV.AutoSize = true;
            this.lbl_CV.Location = new System.Drawing.Point(676, 28);
            this.lbl_CV.Name = "lbl_CV";
            this.lbl_CV.Size = new System.Drawing.Size(31, 16);
            this.lbl_CV.TabIndex = 27;
            this.lbl_CV.Text = "CV:";
            // 
            // lbl_Mediana
            // 
            this.lbl_Mediana.AutoSize = true;
            this.lbl_Mediana.Location = new System.Drawing.Point(620, 63);
            this.lbl_Mediana.Name = "lbl_Mediana";
            this.lbl_Mediana.Size = new System.Drawing.Size(0, 16);
            this.lbl_Mediana.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mediana";
            // 
            // lbl_Moda
            // 
            this.lbl_Moda.AutoSize = true;
            this.lbl_Moda.Location = new System.Drawing.Point(764, 63);
            this.lbl_Moda.Name = "lbl_Moda";
            this.lbl_Moda.Size = new System.Drawing.Size(0, 16);
            this.lbl_Moda.TabIndex = 22;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(676, 63);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(50, 16);
            this.lbl5.TabIndex = 21;
            this.lbl5.Text = "Moda:";
            // 
            // lbl_DesvioStandard
            // 
            this.lbl_DesvioStandard.AutoSize = true;
            this.lbl_DesvioStandard.Location = new System.Drawing.Point(617, 29);
            this.lbl_DesvioStandard.Name = "lbl_DesvioStandard";
            this.lbl_DesvioStandard.Size = new System.Drawing.Size(0, 16);
            this.lbl_DesvioStandard.TabIndex = 20;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(1247, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(34, 36);
            this.btn_Cerrar.TabIndex = 20;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panelSuperior.Controls.Add(this.pictureBox2);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.label2);
            this.panelSuperior.Controls.Add(this.btn_Minimizar);
            this.panelSuperior.Controls.Add(this.btn_Cerrar);
            this.panelSuperior.Location = new System.Drawing.Point(2, 1);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1286, 42);
            this.panelSuperior.TabIndex = 21;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            this.panelSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseMove);
            this.panelSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(757, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(536, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Calculos Estadisticos";
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimizar.Image")));
            this.btn_Minimizar.Location = new System.Drawing.Point(1207, 3);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(34, 36);
            this.btn_Minimizar.TabIndex = 21;
            this.btn_Minimizar.TabStop = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // groupBox_Agrupados
            // 
            this.groupBox_Agrupados.Controls.Add(this.label1);
            this.groupBox_Agrupados.Controls.Add(this.txt_Datos);
            this.groupBox_Agrupados.Controls.Add(this.label3);
            this.groupBox_Agrupados.Controls.Add(this.btn_Calcular);
            this.groupBox_Agrupados.Controls.Add(this.txt_Frecuencia);
            this.groupBox_Agrupados.Controls.Add(this.btn_AgregarDato);
            this.groupBox_Agrupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Agrupados.Location = new System.Drawing.Point(3, 141);
            this.groupBox_Agrupados.Name = "groupBox_Agrupados";
            this.groupBox_Agrupados.Size = new System.Drawing.Size(220, 300);
            this.groupBox_Agrupados.TabIndex = 22;
            this.groupBox_Agrupados.TabStop = false;
            this.groupBox_Agrupados.Text = "Ingreso de datos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(231, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 111);
            this.panel1.TabIndex = 23;
            // 
            // rdb_Agrupados
            // 
            this.rdb_Agrupados.AutoSize = true;
            this.rdb_Agrupados.Checked = true;
            this.rdb_Agrupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Agrupados.Location = new System.Drawing.Point(6, 29);
            this.rdb_Agrupados.Name = "rdb_Agrupados";
            this.rdb_Agrupados.Size = new System.Drawing.Size(101, 20);
            this.rdb_Agrupados.TabIndex = 1;
            this.rdb_Agrupados.TabStop = true;
            this.rdb_Agrupados.Text = "Agrupados";
            this.rdb_Agrupados.UseVisualStyleBackColor = true;
            this.rdb_Agrupados.CheckedChanged += new System.EventHandler(this.rdb_Agrupados_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox_Agrupados);
            this.panel2.Location = new System.Drawing.Point(2, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 444);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(169)))));
            this.panel3.Controls.Add(this.rdb_Desagrupados);
            this.panel3.Controls.Add(this.rdb_Agrupados);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 81);
            this.panel3.TabIndex = 25;
            // 
            // rdb_Desagrupados
            // 
            this.rdb_Desagrupados.AutoSize = true;
            this.rdb_Desagrupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Desagrupados.Location = new System.Drawing.Point(104, 29);
            this.rdb_Desagrupados.Name = "rdb_Desagrupados";
            this.rdb_Desagrupados.Size = new System.Drawing.Size(128, 20);
            this.rdb_Desagrupados.TabIndex = 2;
            this.rdb_Desagrupados.Text = "Desagrupados";
            this.rdb_Desagrupados.UseVisualStyleBackColor = true;
            this.rdb_Desagrupados.CheckedChanged += new System.EventHandler(this.rdb_Desagrupados_CheckedChanged);
            // 
            // groupBoxAgrupados
            // 
            this.groupBoxAgrupados.Controls.Add(this.btn_HacerGrafico);
            this.groupBoxAgrupados.Controls.Add(this.dgv_Datos);
            this.groupBoxAgrupados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAgrupados.Location = new System.Drawing.Point(231, 44);
            this.groupBoxAgrupados.Name = "groupBoxAgrupados";
            this.groupBoxAgrupados.Size = new System.Drawing.Size(1052, 330);
            this.groupBoxAgrupados.TabIndex = 27;
            this.groupBoxAgrupados.TabStop = false;
            this.groupBoxAgrupados.Text = "Tabla Datos";
            // 
            // btn_HacerGrafico
            // 
            this.btn_HacerGrafico.Enabled = false;
            this.btn_HacerGrafico.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HacerGrafico.Location = new System.Drawing.Point(837, 103);
            this.btn_HacerGrafico.Name = "btn_HacerGrafico";
            this.btn_HacerGrafico.Size = new System.Drawing.Size(116, 23);
            this.btn_HacerGrafico.TabIndex = 26;
            this.btn_HacerGrafico.Text = "Graficar";
            this.btn_HacerGrafico.UseVisualStyleBackColor = true;
            this.btn_HacerGrafico.Click += new System.EventHandler(this.btn_HacerGrafico_Click);
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.AllowUserToAddRows = false;
            this.dgv_Datos.AllowUserToDeleteRows = false;
            this.dgv_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column2});
            this.dgv_Datos.Location = new System.Drawing.Point(196, 22);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.ReadOnly = true;
            this.dgv_Datos.RowHeadersVisible = false;
            this.dgv_Datos.Size = new System.Drawing.Size(589, 263);
            this.dgv_Datos.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "x";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "f";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "x.f";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Calculo Variancia";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(173)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(1286, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.groupBoxAgrupados);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstadistica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimizar)).EndInit();
            this.groupBox_Agrupados.ResumeLayout(false);
            this.groupBox_Agrupados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxAgrupados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Datos;
        private System.Windows.Forms.Button btn_AgregarDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TotalFrecuencia;
        private System.Windows.Forms.Label lbl_TotalXPorF;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl_Variancia;
        private System.Windows.Forms.TextBox txt_Frecuencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_frecuenciaSimple;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_DesvioStandard;
        private System.Windows.Forms.Label lbl_Moda;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl_Mediana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox btn_Minimizar;
        private System.Windows.Forms.GroupBox groupBox_Agrupados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_Agrupados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Promedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxAgrupados;
        private System.Windows.Forms.Button btn_HacerGrafico;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RadioButton rdb_Desagrupados;
        private System.Windows.Forms.Label lbl_CoeficienteVariacion;
        private System.Windows.Forms.Label lbl_CV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

