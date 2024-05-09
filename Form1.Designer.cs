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
            lblTitulo = new Label();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnSelecBN.Size = new Size(187, 41);
            btnSelecBN.TabIndex = 2;
            btnSelecBN.Text = "Seleccionar Archivo";
            btnSelecBN.UseVisualStyleBackColor = true;
            btnSelecBN.Click += btnSelecBN_Click;
            // 
            // btnGenerarRepor
            // 
            btnGenerarRepor.Location = new Point(450, 778);
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
            cmbMeses.Location = new Point(131, 130);
            cmbMeses.Name = "cmbMeses";
            cmbMeses.Size = new Size(153, 33);
            cmbMeses.TabIndex = 4;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(76, 133);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(49, 25);
            lblMes.TabIndex = 5;
            lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(336, 133);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "Año";
            // 
            // cmbAnios
            // 
            cmbAnios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnios.FormattingEnabled = true;
            cmbAnios.Location = new Point(387, 130);
            cmbAnios.Name = "cmbAnios";
            cmbAnios.Size = new Size(132, 33);
            cmbAnios.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(859, 841);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(692, 131);
            button1.Name = "button1";
            button1.Size = new Size(187, 41);
            button1.TabIndex = 10;
            button1.Text = "Seleccionar Archivo";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(625, 31);
            textBox1.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(355, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 45);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Reportes de Impresión";
            // 
            // lblByN
            // 
            lblByN.AutoSize = true;
            lblByN.Location = new Point(27, 35);
            lblByN.Name = "lblByN";
            lblByN.Size = new Size(200, 25);
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
            label1.Location = new Point(29, 211);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 14;
            label1.Text = "Mes Actual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 96);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 15;
            label2.Text = "Mes Anterior:";
            // 
            // button2
            // 
            button2.Location = new Point(695, 246);
            button2.Name = "button2";
            button2.Size = new Size(187, 41);
            button2.TabIndex = 17;
            button2.Text = "Seleccionar Archivo";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(625, 31);
            textBox2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnSelecBN);
            panel1.Controls.Add(txtRutaBN);
            panel1.Controls.Add(lblByN);
            panel1.Location = new Point(62, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 174);
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
            panel3.Location = new Point(62, 425);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 319);
            panel3.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1147, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(593, 395);
            dataGridView1.TabIndex = 20;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1783, 913);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(cmbAnios);
            Controls.Add(lblAnio);
            Controls.Add(lblMes);
            Controls.Add(cmbMeses);
            Controls.Add(btnGenerarRepor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "VentanaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTitulo;
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
    }
}
