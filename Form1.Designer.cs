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
            button1 = new Button();
            textBox1 = new TextBox();
            lblByN = new Label();
            lblColor = new Label();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panelRegistro = new Panel();
            lblRegistroTitle = new Label();
            btnRegistro = new Button();
            txtIDArea = new TextBox();
            txtPuesto = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            lblIDArea = new Label();
            lblPuesto = new Label();
            lblNombre = new Label();
            lblCorreo = new Label();
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
            tabPage2.SuspendLayout();
            panelRegistro.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBusqueda).BeginInit();
            SuspendLayout();
            // 
            // txtRutaBN
            // 
            txtRutaBN.Location = new Point(17, 63);
            txtRutaBN.Margin = new Padding(2, 2, 2, 2);
            txtRutaBN.Name = "txtRutaBN";
            txtRutaBN.ReadOnly = true;
            txtRutaBN.Size = new Size(439, 23);
            txtRutaBN.TabIndex = 0;
            // 
            // btnSelecBN
            // 
            btnSelecBN.Location = new Point(483, 60);
            btnSelecBN.Margin = new Padding(2, 2, 2, 2);
            btnSelecBN.Name = "btnSelecBN";
            btnSelecBN.Size = new Size(131, 25);
            btnSelecBN.TabIndex = 2;
            btnSelecBN.Text = "Seleccionar Archivo";
            btnSelecBN.UseVisualStyleBackColor = true;
            btnSelecBN.Click += btnSelecBN_Click;
            // 
            // btnGenerarRepor
            // 
            btnGenerarRepor.Location = new Point(344, 433);
            btnGenerarRepor.Margin = new Padding(2, 2, 2, 2);
            btnGenerarRepor.Name = "btnGenerarRepor";
            btnGenerarRepor.Size = new Size(137, 27);
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
            cmbMeses.Location = new Point(120, 44);
            cmbMeses.Margin = new Padding(2, 2, 2, 2);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(108, 23);
            cmbMeses.TabIndex = 4;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(82, 46);
            lblMes.Margin = new Padding(2, 0, 2, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(32, 15);
            lblMes.TabIndex = 5;
            lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(264, 46);
            lblAnio.Margin = new Padding(2, 0, 2, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "Año";
            // 
            // cmbAnios
            // 
            cmbAnios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnios.FormattingEnabled = true;
            cmbAnios.Location = new Point(300, 44);
            cmbAnios.Margin = new Padding(2, 2, 2, 2);
            cmbAnios.Name = "cmbAnios";
            cmbAnios.Size = new Size(94, 23);
            cmbAnios.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(630, 470);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 20);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(484, 79);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(131, 25);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar Archivo";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 82);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(439, 23);
            textBox1.TabIndex = 9;
            // 
            // lblByN
            // 
            lblByN.AutoSize = true;
            lblByN.Location = new Point(19, 21);
            lblByN.Margin = new Padding(2, 0, 2, 0);
            lblByN.Name = "lblByN";
            lblByN.Size = new Size(132, 15);
            lblByN.TabIndex = 12;
            lblByN.Text = "Reporte Blanco y Negro";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 12F);
            lblColor.Location = new Point(20, 21);
            lblColor.Margin = new Padding(2, 0, 2, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(107, 21);
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
            label1.Location = new Point(20, 127);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 14;
            label1.Text = "Mes Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 15;
            label2.Text = "Mes Anterior:";
            // 
            // button2
            // 
            button2.Location = new Point(486, 148);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(131, 25);
            button2.TabIndex = 17;
            button2.Text = "Seleccionar Archivo";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 151);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(439, 23);
            textBox2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSelecBN);
            panel1.Controls.Add(txtRutaBN);
            panel1.Controls.Add(lblByN);
            panel1.Location = new Point(72, 94);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 106);
            panel1.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(lblColor);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(72, 221);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(638, 193);
            panel3.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 62);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(599, 433);
            dataGridView1.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 7);
            tabControl1.Margin = new Padding(2, 2, 2, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 541);
            tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbAnios);
            tabPage1.Controls.Add(btnGenerarRepor);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(cmbMeses);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(lblMes);
            tabPage1.Controls.Add(lblAnio);
            tabPage1.Controls.Add(btnSalir);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 2, 2, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 2, 2, 2);
            tabPage1.Size = new Size(768, 513);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reportes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panelRegistro);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 2, 2, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 2, 2, 2);
            tabPage2.Size = new Size(768, 513);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelRegistro
            // 
            panelRegistro.BorderStyle = BorderStyle.Fixed3D;
            panelRegistro.Controls.Add(lblRegistroTitle);
            panelRegistro.Controls.Add(btnRegistro);
            panelRegistro.Controls.Add(txtIDArea);
            panelRegistro.Controls.Add(txtPuesto);
            panelRegistro.Controls.Add(txtNombre);
            panelRegistro.Controls.Add(txtCorreo);
            panelRegistro.Controls.Add(lblIDArea);
            panelRegistro.Controls.Add(lblPuesto);
            panelRegistro.Controls.Add(lblNombre);
            panelRegistro.Controls.Add(lblCorreo);
            panelRegistro.Location = new Point(30, 34);
            panelRegistro.Margin = new Padding(2, 2, 2, 2);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(708, 450);
            panelRegistro.TabIndex = 0;
            // 
            // lblRegistroTitle
            // 
            lblRegistroTitle.AutoSize = true;
            lblRegistroTitle.Font = new Font("Segoe UI", 13F);
            lblRegistroTitle.Location = new Point(303, 37);
            lblRegistroTitle.Margin = new Padding(2, 0, 2, 0);
            lblRegistroTitle.Name = "lblRegistroTitle";
            lblRegistroTitle.Size = new Size(133, 25);
            lblRegistroTitle.TabIndex = 9;
            lblRegistroTitle.Text = "Nuevo Usuario:";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(330, 385);
            btnRegistro.Margin = new Padding(2, 2, 2, 2);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(78, 20);
            btnRegistro.TabIndex = 8;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            // 
            // txtIDArea
            // 
            txtIDArea.Location = new Point(200, 320);
            txtIDArea.Margin = new Padding(2, 2, 2, 2);
            txtIDArea.Name = "txtIDArea";
            txtIDArea.Size = new Size(106, 23);
            txtIDArea.TabIndex = 7;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(200, 248);
            txtPuesto.Margin = new Padding(2, 2, 2, 2);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(395, 23);
            txtPuesto.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 179);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(395, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(200, 107);
            txtCorreo.Margin = new Padding(2, 2, 2, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(395, 23);
            txtCorreo.TabIndex = 4;
            // 
            // lblIDArea
            // 
            lblIDArea.AutoSize = true;
            lblIDArea.Location = new Point(99, 320);
            lblIDArea.Margin = new Padding(2, 0, 2, 0);
            lblIDArea.Name = "lblIDArea";
            lblIDArea.Size = new Size(64, 15);
            lblIDArea.TabIndex = 3;
            lblIDArea.Text = "ID de Área:";
            // 
            // lblPuesto
            // 
            lblPuesto.AutoSize = true;
            lblPuesto.Location = new Point(99, 248);
            lblPuesto.Margin = new Padding(2, 0, 2, 0);
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(46, 15);
            lblPuesto.TabIndex = 2;
            lblPuesto.Text = "Puesto:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(99, 179);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(99, 107);
            lblCorreo.Margin = new Padding(2, 0, 2, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(46, 15);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(picBusqueda);
            tabPage3.Controls.Add(txtBusqueda);
            tabPage3.Controls.Add(btnEliminar);
            tabPage3.Controls.Add(btnEditar);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 2, 2, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 2, 2, 2);
            tabPage3.Size = new Size(768, 513);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Usuarios";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // picBusqueda
            // 
            picBusqueda.BackColor = SystemColors.Window;
            picBusqueda.Image = Properties.Resources.busqueda;
            picBusqueda.Location = new Point(399, 33);
            picBusqueda.Margin = new Padding(2, 2, 2, 2);
            picBusqueda.Name = "picBusqueda";
            picBusqueda.Size = new Size(18, 16);
            picBusqueda.SizeMode = PictureBoxSizeMode.StretchImage;
            picBusqueda.TabIndex = 24;
            picBusqueda.TabStop = false;
            picBusqueda.Click += picBusqueda_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(89, 31);
            txtBusqueda.Margin = new Padding(2, 2, 2, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(332, 23);
            txtBusqueda.TabIndex = 23;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(610, 33);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 20);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(517, 33);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 20);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 449);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
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
            tabPage2.ResumeLayout(false);
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
        private Button button1;
        private TextBox textBox1;
        private Label lblByN;
        private Label lblColor;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private Button button2;
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
    }
}
