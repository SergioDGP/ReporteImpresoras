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
            notifyIcon1 = new NotifyIcon(components);
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtBusqueda = new TextBox();
            picBusqueda = new PictureBox();
            tabPage2 = new TabPage();
            lblRegistroTitle = new Label();
            panelRegistro = new Panel();
            lblCorreo = new Label();
            lblNombre = new Label();
            lblPuesto = new Label();
            lblIDArea = new Label();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtPuesto = new TextBox();
            btnRegistro = new Button();
            comboAreas = new ComboBox();
            pictureBox2 = new PictureBox();
            tabPage1 = new TabPage();
            picMute = new PictureBox();
            btnSalir = new Button();
            lblAnio = new Label();
            lblMes = new Label();
            panel1 = new Panel();
            lblByN = new Label();
            txtRutaBN = new TextBox();
            btnSelecBN = new Button();
            btnEliminarBN = new Button();
            cmbMeses = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtColorActual = new TextBox();
            lblColor = new Label();
            btnSelecColor = new Button();
            btnSlcColorAnt = new Button();
            txtColorAnterior = new TextBox();
            btnEliminarColAct = new Button();
            btnEliminarColAnt = new Button();
            btnGenerarRepor = new Button();
            cmbAnios = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtRH = new TextBox();
            txtDirGral = new TextBox();
            txtContraloria = new TextBox();
            picUnMute = new PictureBox();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBusqueda).BeginInit();
            tabPage2.SuspendLayout();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMute).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUnMute).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
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
            tabPage3.Size = new Size(1109, 971);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(856, 790);
            dataGridView1.TabIndex = 20;
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
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(127, 52);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(473, 31);
            txtBusqueda.TabIndex = 23;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // picBusqueda
            // 
            picBusqueda.BackColor = SystemColors.Window;
            picBusqueda.Image = Properties.Resources.busqueda;
            picBusqueda.Location = new Point(570, 53);
            picBusqueda.Name = "picBusqueda";
            picBusqueda.Size = new Size(26, 27);
            picBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            picBusqueda.TabIndex = 24;
            picBusqueda.TabStop = false;
            picBusqueda.Click += picBusqueda_Click;
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
            tabPage2.Size = new Size(1109, 971);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro";
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
            // panelRegistro
            // 
            panelRegistro.BorderStyle = BorderStyle.Fixed3D;
            panelRegistro.Controls.Add(comboAreas);
            panelRegistro.Controls.Add(btnRegistro);
            panelRegistro.Controls.Add(txtPuesto);
            panelRegistro.Controls.Add(txtNombre);
            panelRegistro.Controls.Add(txtCorreo);
            panelRegistro.Controls.Add(lblIDArea);
            panelRegistro.Controls.Add(lblPuesto);
            panelRegistro.Controls.Add(lblNombre);
            panelRegistro.Controls.Add(lblCorreo);
            panelRegistro.Location = new Point(81, 170);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(943, 535);
            panelRegistro.TabIndex = 0;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(113, 68);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(113, 149);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(113, 235);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(70, 25);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto:";
            // 
            // lblIDArea
            // 
            lblIDArea.AutoSize = true;
            lblIDArea.Location = new Point(113, 327);
            lblIDArea.Name = "lblIDArea";
            lblIDArea.Size = new Size(100, 25);
            lblIDArea.TabIndex = 3;
            lblIDArea.Text = "ID de Área:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(259, 68);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(563, 31);
            txtCorreo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(259, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(563, 31);
            txtNombre.TabIndex = 5;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(259, 235);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(563, 31);
            txtPuesto.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(437, 420);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(111, 33);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // comboAreas
            // 
            comboAreas.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAreas.FormattingEnabled = true;
            comboAreas.Items.AddRange(new object[] { "1 (DN1)", "2 (DN2)", "3 (TI)", "4 (RH)", "5 (AUDITORIA)", "6 (COMERCIO)", "7 (CONTRALORIA)", "8 (DIR. GRAL.)", "10 (LEGAL)", "11 (PLANEACION)", "12 (SOX)" });
            comboAreas.Location = new Point(259, 326);
            comboAreas.Name = "comboAreas";
            comboAreas.Size = new Size(261, 33);
            comboAreas.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Moore_large;
            pictureBox2.Location = new Point(895, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientInactiveCaption;
            tabPage1.Controls.Add(picUnMute);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(cmbAnios);
            tabPage1.Controls.Add(btnGenerarRepor);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(cmbMeses);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(lblMes);
            tabPage1.Controls.Add(lblAnio);
            tabPage1.Controls.Add(btnSalir);
            tabPage1.Controls.Add(picMute);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1109, 971);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reportes";
            // 
            // picMute
            // 
            picMute.Image = Properties.Resources.mute;
            picMute.Location = new Point(83, 829);
            picMute.Name = "picMute";
            picMute.Size = new Size(35, 35);
            picMute.SizeMode = PictureBoxSizeMode.StretchImage;
            picMute.TabIndex = 22;
            picMute.TabStop = false;
            picMute.Visible = false;
            picMute.Click += picMute_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(904, 897);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 33);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(348, 52);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "Año";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(88, 52);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(49, 25);
            lblMes.TabIndex = 5;
            lblMes.Text = "Mes:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnEliminarBN);
            panel1.Controls.Add(btnSelecBN);
            panel1.Controls.Add(txtRutaBN);
            panel1.Controls.Add(lblByN);
            panel1.Location = new Point(88, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 174);
            panel1.TabIndex = 18;
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
            // txtRutaBN
            // 
            txtRutaBN.Location = new Point(24, 105);
            txtRutaBN.Name = "txtRutaBN";
            txtRutaBN.ReadOnly = true;
            txtRutaBN.Size = new Size(568, 31);
            txtRutaBN.TabIndex = 0;
            // 
            // btnSelecBN
            // 
            btnSelecBN.Location = new Point(606, 99);
            btnSelecBN.Name = "btnSelecBN";
            btnSelecBN.Size = new Size(179, 42);
            btnSelecBN.TabIndex = 2;
            btnSelecBN.Text = "Seleccionar Archivo";
            btnSelecBN.UseVisualStyleBackColor = true;
            btnSelecBN.Click += btnSelecBN_Click;
            // 
            // btnEliminarBN
            // 
            btnEliminarBN.Location = new Point(791, 99);
            btnEliminarBN.Name = "btnEliminarBN";
            btnEliminarBN.Size = new Size(112, 42);
            btnEliminarBN.TabIndex = 13;
            btnEliminarBN.Text = "Eliminar";
            btnEliminarBN.UseVisualStyleBackColor = true;
            btnEliminarBN.Click += btnEliminarBN_Click;
            // 
            // cmbMeses
            // 
            cmbMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeses.FormattingEnabled = true;
            cmbMeses.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio ", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cmbMeses.Location = new Point(142, 47);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(153, 33);
            cmbMeses.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btnEliminarColAnt);
            panel3.Controls.Add(btnEliminarColAct);
            panel3.Controls.Add(txtColorAnterior);
            panel3.Controls.Add(btnSlcColorAnt);
            panel3.Controls.Add(btnSelecColor);
            panel3.Controls.Add(lblColor);
            panel3.Controls.Add(txtColorActual);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(83, 317);
            panel3.Name = "panel3";
            panel3.Size = new Size(941, 298);
            panel3.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 192);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 15;
            label2.Text = "Mes Anterior:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 98);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 14;
            label1.Text = "Mes Actual:";
            // 
            // txtColorActual
            // 
            txtColorActual.Location = new Point(32, 138);
            txtColorActual.Name = "txtColorActual";
            txtColorActual.ReadOnly = true;
            txtColorActual.Size = new Size(565, 31);
            txtColorActual.TabIndex = 16;
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
            // btnSelecColor
            // 
            btnSelecColor.Location = new Point(611, 132);
            btnSelecColor.Name = "btnSelecColor";
            btnSelecColor.Size = new Size(179, 42);
            btnSelecColor.TabIndex = 17;
            btnSelecColor.Text = "Seleccionar Archivo";
            btnSelecColor.UseVisualStyleBackColor = true;
            btnSelecColor.Click += btnSelecColor_Click;
            // 
            // btnSlcColorAnt
            // 
            btnSlcColorAnt.Location = new Point(611, 226);
            btnSlcColorAnt.Name = "btnSlcColorAnt";
            btnSlcColorAnt.Size = new Size(179, 42);
            btnSlcColorAnt.TabIndex = 10;
            btnSlcColorAnt.Text = "Seleccionar Archivo";
            btnSlcColorAnt.UseVisualStyleBackColor = true;
            btnSlcColorAnt.Click += btnSlcColorAnt_Click;
            // 
            // txtColorAnterior
            // 
            txtColorAnterior.Location = new Point(29, 232);
            txtColorAnterior.Name = "txtColorAnterior";
            txtColorAnterior.ReadOnly = true;
            txtColorAnterior.Size = new Size(568, 31);
            txtColorAnterior.TabIndex = 9;
            // 
            // btnEliminarColAct
            // 
            btnEliminarColAct.Location = new Point(802, 132);
            btnEliminarColAct.Name = "btnEliminarColAct";
            btnEliminarColAct.Size = new Size(112, 42);
            btnEliminarColAct.TabIndex = 14;
            btnEliminarColAct.Text = "Eliminar";
            btnEliminarColAct.UseVisualStyleBackColor = true;
            btnEliminarColAct.Click += btnEliminarColAct_Click;
            // 
            // btnEliminarColAnt
            // 
            btnEliminarColAnt.Location = new Point(802, 226);
            btnEliminarColAnt.Name = "btnEliminarColAnt";
            btnEliminarColAnt.Size = new Size(112, 42);
            btnEliminarColAnt.TabIndex = 18;
            btnEliminarColAnt.Text = "Eliminar";
            btnEliminarColAnt.UseVisualStyleBackColor = true;
            btnEliminarColAnt.Click += btnEliminarColAnt_Click;
            // 
            // btnGenerarRepor
            // 
            btnGenerarRepor.Location = new Point(452, 829);
            btnGenerarRepor.Name = "btnGenerarRepor";
            btnGenerarRepor.Size = new Size(196, 45);
            btnGenerarRepor.TabIndex = 3;
            btnGenerarRepor.Text = "Generar Reporte(s)";
            btnGenerarRepor.UseVisualStyleBackColor = true;
            btnGenerarRepor.Click += btnGenerarRepor_Click;
            // 
            // cmbAnios
            // 
            cmbAnios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnios.FormattingEnabled = true;
            cmbAnios.Location = new Point(399, 47);
            cmbAnios.Name = "cmbAnios";
            cmbAnios.Size = new Size(133, 33);
            cmbAnios.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Moore_large;
            pictureBox1.Location = new Point(895, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtContraloria);
            panel2.Controls.Add(txtDirGral);
            panel2.Controls.Add(txtRH);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(83, 648);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 152);
            panel2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(31, 17);
            label3.Name = "label3";
            label3.Size = new Size(303, 32);
            label3.TabIndex = 18;
            label3.Text = "Impresoras independientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 83);
            label4.Name = "label4";
            label4.Size = new Size(40, 25);
            label4.TabIndex = 19;
            label4.Text = "RH:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 82);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 20;
            label5.Text = "Dir. Gral:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(651, 83);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 21;
            label6.Text = "Contraloría:";
            // 
            // txtRH
            // 
            txtRH.Location = new Point(83, 82);
            txtRH.Name = "txtRH";
            txtRH.Size = new Size(127, 31);
            txtRH.TabIndex = 22;
            txtRH.KeyPress += txtRH_KeyPress;
            // 
            // txtDirGral
            // 
            txtDirGral.Location = new Point(429, 83);
            txtDirGral.Name = "txtDirGral";
            txtDirGral.Size = new Size(127, 31);
            txtDirGral.TabIndex = 23;
            txtDirGral.KeyPress += txtDirGral_KeyPress;
            // 
            // txtContraloria
            // 
            txtContraloria.Location = new Point(756, 80);
            txtContraloria.Name = "txtContraloria";
            txtContraloria.Size = new Size(127, 31);
            txtContraloria.TabIndex = 24;
            txtContraloria.KeyPress += txtContraloria_KeyPress;
            // 
            // picUnMute
            // 
            picUnMute.Image = Properties.Resources.volume;
            picUnMute.Location = new Point(83, 829);
            picUnMute.Name = "picUnMute";
            picUnMute.Size = new Size(35, 35);
            picUnMute.SizeMode = PictureBoxSizeMode.StretchImage;
            picUnMute.TabIndex = 23;
            picUnMute.TabStop = false;
            picUnMute.Click += picUnMute_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-4, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1117, 1009);
            tabControl1.TabIndex = 21;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1103, 1013);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1125, 1069);
            MinimumSize = new Size(1125, 1069);
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes de Impresoras";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBusqueda).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMute).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUnMute).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private TabPage tabPage3;
        private PictureBox picBusqueda;
        private TextBox txtBusqueda;
        private Button btnEliminar;
        private Button btnEditar;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private Panel panelRegistro;
        private ComboBox comboAreas;
        private Button btnRegistro;
        private TextBox txtPuesto;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label lblIDArea;
        private Label lblPuesto;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblRegistroTitle;
        private TabPage tabPage1;
        private PictureBox picUnMute;
        private Panel panel2;
        private TextBox txtContraloria;
        private TextBox txtDirGral;
        private TextBox txtRH;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox cmbAnios;
        private Button btnGenerarRepor;
        private Panel panel3;
        private Button btnEliminarColAnt;
        private Button btnEliminarColAct;
        private TextBox txtColorAnterior;
        private Button btnSlcColorAnt;
        private Button btnSelecColor;
        private Label lblColor;
        private TextBox txtColorActual;
        private Label label1;
        private Label label2;
        private ComboBox cmbMeses;
        private Panel panel1;
        private Button btnEliminarBN;
        private Button btnSelecBN;
        private TextBox txtRutaBN;
        private Label lblByN;
        private Label lblMes;
        private Label lblAnio;
        private Button btnSalir;
        private PictureBox picMute;
        private TabControl tabControl1;
    }
}
