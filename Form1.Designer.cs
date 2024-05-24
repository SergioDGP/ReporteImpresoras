namespace ReporteImpresoras
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            txtRutaBN = new TextBox();
            btnSelecBN = new Button();
            btnGenerarRepor = new Button();
            cmbMeses = new ComboBox();
            lblMes = new Label();
            lblAnio = new Label();
            cmbAnios = new ComboBox();
            btnSalir = new Button();
            btnSlcColorAnt = new Button();
            textBox1 = new TextBox();
            lblByN = new Label();
            lblColor = new Label();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            label2 = new Label();
            btnSelecColor = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            panelRegistro = new Panel();
            comboAreas = new ComboBox();
            btnRegistro = new Button();
            txtIDArea = new TextBox();
            txtPuesto = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            lblIDArea = new Label();
            lblPuesto = new Label();
            lblNombre = new Label();
            lblCorreo = new Label();
            lblRegistroTitle = new Label();
            tabPage3 = new TabPage();
            picBusqueda = new PictureBox();
            txtBusqueda = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRegistro.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBusqueda).BeginInit();
            SuspendLayout();
            // 
            // txtRutaBN
            // 
            txtRutaBN.Location = new Point(24, 105);
            txtRutaBN.Name = "txtRutaBN";
            txtRutaBN.ReadOnly = true;
            txtRutaBN.Size = new Size(625, 31);
            txtRutaBN.TabIndex = 0;
            // 
            // btnSelecBN
            // 
            btnSelecBN.Location = new Point(690, 100);
            btnSelecBN.Name = "btnSelecBN";
            btnSelecBN.Size = new Size(187, 42);
            btnSelecBN.TabIndex = 2;
            btnSelecBN.Text = "Seleccionar Archivo";
            btnSelecBN.UseVisualStyleBackColor = true;
            btnSelecBN.Click += btnSelecBN_Click;
            // 
            // btnGenerarRepor
            // 
            btnGenerarRepor.Location = new Point(491, 722);
            btnGenerarRepor.Name = "btnGenerarRepor";
            btnGenerarRepor.Size = new Size(196, 45);
            btnGenerarRepor.TabIndex = 3;
            btnGenerarRepor.Text = "Generar Reporte(s)";
            btnGenerarRepor.UseVisualStyleBackColor = true;
            btnGenerarRepor.Click += btnGenerarRepor_Click;
            // 
            // cmbMeses
            // 
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio ", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbMeses.Location = new Point(154, 47);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(153, 33);
            cmbMeses.TabIndex = 4;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(100, 51);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(49, 25);
            lblMes.TabIndex = 5;
            lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(360, 51);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "Año";
            // 
            // cmbAnios
            // 
            cmbAnios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnios.FormattingEnabled = true;
            cmbAnios.Location = new Point(412, 47);
            cmbAnios.Name = "cmbAnios";
            cmbAnios.Size = new Size(133, 33);
            cmbAnios.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(900, 783);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 33);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSlcColorAnt
            // 
            btnSlcColorAnt.Location = new Point(691, 132);
            btnSlcColorAnt.Name = "btnSlcColorAnt";
            btnSlcColorAnt.Size = new Size(187, 42);
            btnSlcColorAnt.TabIndex = 10;
            btnSlcColorAnt.Text = "Seleccionar Archivo";
            btnSlcColorAnt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 137);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(625, 31);
            textBox1.TabIndex = 9;
            // 
            // lblByN
            // 
            lblByN.AutoSize = true;
            lblByN.Font = new Font("Segoe UI", 12F);
            lblByN.Location = new Point(27, 35);
            lblByN.Name = "lblByN";
            lblByN.Size = new Size(268, 32);
            lblByN.TabIndex = 12;
            lblByN.Text = "Reporte Blanco y Negro";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 12F);
            lblColor.Location = new Point(29, 35);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(161, 32);
            lblColor.TabIndex = 13;
            lblColor.Text = "Reporte Color";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 212);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 14;
            label1.Text = "Mes Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 15;
            label2.Text = "Mes Anterior:";
            // 
            // btnSelecColor
            // 
            btnSelecColor.Location = new Point(694, 247);
            btnSelecColor.Name = "btnSelecColor";
            btnSelecColor.Size = new Size(187, 42);
            btnSelecColor.TabIndex = 17;
            btnSelecColor.Text = "Seleccionar Archivo";
            btnSelecColor.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 252);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(625, 31);
            textBox2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSelecBN);
            panel1.Controls.Add(txtRutaBN);
            panel1.Controls.Add(lblByN);
            panel1.Location = new Point(103, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 174);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnSlcColorAnt);
            panel3.Controls.Add(btnSelecColor);
            panel3.Controls.Add(lblColor);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(103, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 319);
            panel3.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(856, 714);
            dataGridView1.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-4, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1113, 902);
            tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(cmbAnios);
            tabPage1.Controls.Add(btnGenerarRepor);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(cmbMeses);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(lblMes);
            tabPage1.Controls.Add(lblAnio);
            tabPage1.Controls.Add(btnSalir);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1105, 864);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reportes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Moore_large;
            pictureBox1.Location = new Point(885, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientInactiveCaption;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(panelRegistro);
            tabPage2.Controls.Add(lblRegistroTitle);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1105, 864);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Moore_large;
            pictureBox2.Location = new Point(885, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // panelRegistro
            // 
            panelRegistro.BorderStyle = BorderStyle.Fixed3D;
            panelRegistro.Controls.Add(comboAreas);
            panelRegistro.Controls.Add(btnRegistro);
            panelRegistro.Controls.Add(txtIDArea);
            panelRegistro.Controls.Add(txtPuesto);
            panelRegistro.Controls.Add(txtNombre);
            panelRegistro.Controls.Add(txtCorreo);
            panelRegistro.Controls.Add(lblIDArea);
            panelRegistro.Controls.Add(lblPuesto);
            panelRegistro.Controls.Add(lblNombre);
            panelRegistro.Controls.Add(lblCorreo);
            panelRegistro.Location = new Point(81, 170);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(950, 630);
            panelRegistro.TabIndex = 0;
            // 
            // comboAreas
            // 
            comboAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAreas.FormattingEnabled = true;
            comboAreas.Items.AddRange(new object[] { "1 (DN1)", "2 (DN2)", "3 (TI)", "4 (RH)", "5 (AUDITORIA)", "6 (COMERCIO)", "7 (CONTRALORIA)", "8 (DIR. GRAL.)", "10 (LEGAL)", "11 (PLANEACION)", "12 (SOX)" });
            comboAreas.Location = new Point(258, 421);
            comboAreas.Name = "comboAreas";
            comboAreas.Size = new Size(261, 33);
            comboAreas.TabIndex = 10;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(443, 533);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(111, 33);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtIDArea
            // 
            txtIDArea.Location = new Point(554, 423);
            txtIDArea.Name = "txtIDArea";
            txtIDArea.Size = new Size(150, 31);
            txtIDArea.TabIndex = 7;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(258, 304);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(563, 31);
            txtPuesto.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(258, 189);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(563, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(258, 69);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(563, 31);
            txtCorreo.TabIndex = 4;
            // 
            // lblIDArea
            // 
            lblIDArea.AutoSize = true;
            lblIDArea.Location = new Point(113, 424);
            lblIDArea.Name = "lblIDArea";
            lblIDArea.Size = new Size(100, 25);
            lblIDArea.TabIndex = 3;
            lblIDArea.Text = "ID de Área:";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(113, 304);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(70, 25);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(113, 189);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(113, 69);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo:";
            // 
            // lblRegistroTitle
            // 
            lblRegistroTitle.AutoSize = true;
            lblRegistroTitle.Font = new Font("Segoe UI", 13F);
            lblRegistroTitle.Location = new Point(81, 48);
            lblRegistroTitle.Name = "lblRegistroTitle";
            lblRegistroTitle.Size = new Size(184, 36);
            lblRegistroTitle.TabIndex = 9;
            lblRegistroTitle.Text = "Nuevo Usuario";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.GradientInactiveCaption;
            tabPage3.Controls.Add(picBusqueda);
            tabPage3.Controls.Add(txtBusqueda);
            tabPage3.Controls.Add(btnEliminar);
            tabPage3.Controls.Add(btnEditar);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1105, 864);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            // 
            // picBusqueda
            // 
            picBusqueda.BackColor = SystemColors.Window;
            picBusqueda.Image = Properties.Resources.busqueda;
            picBusqueda.Location = new Point(570, 55);
            picBusqueda.Name = "picBusqueda";
            picBusqueda.Size = new Size(25, 27);
            picBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            picBusqueda.TabIndex = 24;
            picBusqueda.TabStop = false;
            picBusqueda.Click += picBusqueda_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(127, 52);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(473, 31);
            txtBusqueda.TabIndex = 23;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(871, 55);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 33);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(739, 55);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 33);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1107, 913);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes de Impresoras";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBusqueda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtRutaBN;
        private Button btnSelecBN;
        private Button btnGenerarRepor;
        private ComboBox cmbMeses;
        private Label lblMes;
        private Label lblAnio;
        private ComboBox cmbAnios;
        private Button btnSalir;
        private Button btnSlcColorAnt;
        private TextBox textBox1;
        private Label lblByN;
        private Label lblColor;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private Button btnSelecColor;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panelRegistro;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblIDArea;
        private Label lblPuesto;
        private Button btnRegistro;
        private TextBox txtIDArea;
        private TextBox txtPuesto;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label lblRegistroTitle;
        private Button btnEliminar;
        private Button btnEditar;
        private TextBox txtBusqueda;
        private PictureBox picBusqueda;
        private ComboBox comboAreas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
