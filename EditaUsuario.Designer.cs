namespace ReporteImpresoras
{
    partial class EditaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditaUsuario));
            pnlEdicion = new Panel();
            comboAreasEdit = new ComboBox();
            btnSalirEdicion = new Button();
            btnEdicionConfirm = new Button();
            lblEdicionTitulo = new Label();
            checkID_Area = new CheckBox();
            checkPuesto = new CheckBox();
            checkNombre = new CheckBox();
            checkCorreo = new CheckBox();
            txtPuesto = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            pnlEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEdicion
            // 
            pnlEdicion.BorderStyle = BorderStyle.Fixed3D;
            pnlEdicion.Controls.Add(comboAreasEdit);
            pnlEdicion.Controls.Add(btnSalirEdicion);
            pnlEdicion.Controls.Add(btnEdicionConfirm);
            pnlEdicion.Controls.Add(lblEdicionTitulo);
            pnlEdicion.Controls.Add(checkID_Area);
            pnlEdicion.Controls.Add(checkPuesto);
            pnlEdicion.Controls.Add(checkNombre);
            pnlEdicion.Controls.Add(checkCorreo);
            pnlEdicion.Controls.Add(txtPuesto);
            pnlEdicion.Controls.Add(txtNombre);
            pnlEdicion.Controls.Add(txtCorreo);
            pnlEdicion.Location = new Point(33, 23);
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Size = new Size(838, 537);
            pnlEdicion.TabIndex = 0;
            // 
            // comboAreasEdit
            // 
            comboAreasEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAreasEdit.FormattingEnabled = true;
            comboAreasEdit.Items.AddRange(new object[] { "1 (DN1)", "2 (DN2)", "3 (TI)", "4 (RH)", "5 (AUDITORIA)", "6 (COMERCIO)", "7 (CONTRALORIA)", "8 (DIR. GRAL.)", "10 (LEGAL)", "11 (PLANEACION)", "12 (SOX)" });
            comboAreasEdit.Location = new Point(210, 357);
            comboAreasEdit.Name = "comboAreasEdit";
            comboAreasEdit.Size = new Size(261, 33);
            comboAreasEdit.TabIndex = 23;
            // 
            // btnSalirEdicion
            // 
            btnSalirEdicion.Location = new Point(686, 470);
            btnSalirEdicion.Name = "btnSalirEdicion";
            btnSalirEdicion.Size = new Size(111, 33);
            btnSalirEdicion.TabIndex = 22;
            btnSalirEdicion.Text = "Cancelar";
            btnSalirEdicion.UseVisualStyleBackColor = true;
            btnSalirEdicion.Click += btnSalirEdicion_Click;
            // 
            // btnEdicionConfirm
            // 
            btnEdicionConfirm.Location = new Point(383, 428);
            btnEdicionConfirm.Name = "btnEdicionConfirm";
            btnEdicionConfirm.Size = new Size(111, 42);
            btnEdicionConfirm.TabIndex = 21;
            btnEdicionConfirm.Text = "Actualizar";
            btnEdicionConfirm.UseVisualStyleBackColor = true;
            btnEdicionConfirm.Click += btnEdicionConfirm_Click;
            // 
            // lblEdicionTitulo
            // 
            lblEdicionTitulo.AutoSize = true;
            lblEdicionTitulo.Font = new Font("Segoe UI", 10F);
            lblEdicionTitulo.Location = new Point(84, 55);
            lblEdicionTitulo.Name = "lblEdicionTitulo";
            lblEdicionTitulo.Size = new Size(368, 28);
            lblEdicionTitulo.TabIndex = 20;
            lblEdicionTitulo.Text = "Selecciona los campos que deseas editar:";
            // 
            // checkID_Area
            // 
            checkID_Area.AutoSize = true;
            checkID_Area.Location = new Point(84, 357);
            checkID_Area.Name = "checkID_Area";
            checkID_Area.Size = new Size(99, 29);
            checkID_Area.TabIndex = 19;
            checkID_Area.Text = "ID_Area";
            checkID_Area.UseVisualStyleBackColor = true;
            checkID_Area.CheckedChanged += checkID_Area_CheckedChanged;
            // 
            // checkPuesto
            // 
            checkPuesto.AutoSize = true;
            checkPuesto.Location = new Point(84, 279);
            checkPuesto.Name = "checkPuesto";
            checkPuesto.Size = new Size(96, 29);
            checkPuesto.TabIndex = 18;
            checkPuesto.Text = "Puesto:";
            checkPuesto.UseVisualStyleBackColor = true;
            checkPuesto.CheckedChanged += checkPuesto_CheckedChanged;
            // 
            // checkNombre
            // 
            checkNombre.AutoSize = true;
            checkNombre.Location = new Point(84, 204);
            checkNombre.Name = "checkNombre";
            checkNombre.Size = new Size(108, 29);
            checkNombre.TabIndex = 17;
            checkNombre.Text = "Nombre:";
            checkNombre.UseVisualStyleBackColor = true;
            checkNombre.CheckedChanged += checkNombre_CheckedChanged;
            // 
            // checkCorreo
            // 
            checkCorreo.AutoSize = true;
            checkCorreo.Location = new Point(84, 132);
            checkCorreo.Name = "checkCorreo";
            checkCorreo.Size = new Size(96, 29);
            checkCorreo.TabIndex = 16;
            checkCorreo.Text = "Correo:";
            checkCorreo.UseVisualStyleBackColor = true;
            checkCorreo.CheckedChanged += checkCorreo_CheckedChanged;
            // 
            // txtPuesto
            // 
            txtPuesto.Enabled = false;
            txtPuesto.Location = new Point(210, 277);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(514, 31);
            txtPuesto.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(210, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(514, 31);
            txtNombre.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(210, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(514, 31);
            txtCorreo.TabIndex = 12;
            // 
            // EditaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(903, 602);
            Controls.Add(pnlEdicion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditaUsuario";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            pnlEdicion.ResumeLayout(false);
            pnlEdicion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEdicion;
        private TextBox txtPuesto;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label lblEdicionTitulo;
        private CheckBox checkID_Area;
        private CheckBox checkPuesto;
        private CheckBox checkNombre;
        private CheckBox checkCorreo;
        private Button btnSalirEdicion;
        private Button btnEdicionConfirm;
        private ComboBox comboAreasEdit;
    }
}