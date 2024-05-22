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
            btnSalirEdicion = new Button();
            btnEdicionConfirm = new Button();
            lblEdicionTitulo = new Label();
            checkID_Area = new CheckBox();
            checkPuesto = new CheckBox();
            checkNombre = new CheckBox();
            checkCorreo = new CheckBox();
            txtIDArea = new TextBox();
            txtPuesto = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            pnlEdicion.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEdicion
            // 
            pnlEdicion.BorderStyle = BorderStyle.Fixed3D;
            pnlEdicion.Controls.Add(btnSalirEdicion);
            pnlEdicion.Controls.Add(btnEdicionConfirm);
            pnlEdicion.Controls.Add(lblEdicionTitulo);
            pnlEdicion.Controls.Add(checkID_Area);
            pnlEdicion.Controls.Add(checkPuesto);
            pnlEdicion.Controls.Add(checkNombre);
            pnlEdicion.Controls.Add(checkCorreo);
            pnlEdicion.Controls.Add(txtIDArea);
            pnlEdicion.Controls.Add(txtPuesto);
            pnlEdicion.Controls.Add(txtNombre);
            pnlEdicion.Controls.Add(txtCorreo);
            pnlEdicion.Location = new Point(23, 14);
            pnlEdicion.Margin = new Padding(2);
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Size = new Size(588, 324);
            pnlEdicion.TabIndex = 0;
            // 
            // btnSalirEdicion
            // 
            btnSalirEdicion.Location = new Point(480, 282);
            btnSalirEdicion.Margin = new Padding(2);
            btnSalirEdicion.Name = "btnSalirEdicion";
            btnSalirEdicion.Size = new Size(78, 20);
            btnSalirEdicion.TabIndex = 22;
            btnSalirEdicion.Text = "Cancelar";
            btnSalirEdicion.UseVisualStyleBackColor = true;
            btnSalirEdicion.Click += btnSalirEdicion_Click;
            // 
            // btnEdicionConfirm
            // 
            btnEdicionConfirm.Location = new Point(268, 257);
            btnEdicionConfirm.Margin = new Padding(2);
            btnEdicionConfirm.Name = "btnEdicionConfirm";
            btnEdicionConfirm.Size = new Size(78, 25);
            btnEdicionConfirm.TabIndex = 21;
            btnEdicionConfirm.Text = "Actualizar";
            btnEdicionConfirm.UseVisualStyleBackColor = true;
            btnEdicionConfirm.Click += btnEdicionConfirm_Click;
            // 
            // lblEdicionTitulo
            // 
            lblEdicionTitulo.AutoSize = true;
            lblEdicionTitulo.Font = new Font("Segoe UI", 10F);
            lblEdicionTitulo.Location = new Point(59, 33);
            lblEdicionTitulo.Margin = new Padding(2, 0, 2, 0);
            lblEdicionTitulo.Name = "lblEdicionTitulo";
            lblEdicionTitulo.Size = new Size(257, 19);
            lblEdicionTitulo.TabIndex = 20;
            lblEdicionTitulo.Text = "Selecciona los campos que deseas editar:";
            // 
            // checkID_Area
            // 
            checkID_Area.AutoSize = true;
            checkID_Area.Location = new Point(59, 218);
            checkID_Area.Margin = new Padding(2);
            checkID_Area.Name = "checkID_Area";
            checkID_Area.Size = new Size(66, 19);
            checkID_Area.TabIndex = 19;
            checkID_Area.Text = "ID_Area";
            checkID_Area.UseVisualStyleBackColor = true;
            checkID_Area.CheckedChanged += checkID_Area_CheckedChanged;
            // 
            // checkPuesto
            // 
            checkPuesto.AutoSize = true;
            checkPuesto.Location = new Point(59, 170);
            checkPuesto.Margin = new Padding(2);
            checkPuesto.Name = "checkPuesto";
            checkPuesto.Size = new Size(65, 19);
            checkPuesto.TabIndex = 18;
            checkPuesto.Text = "Puesto:";
            checkPuesto.UseVisualStyleBackColor = true;
            checkPuesto.CheckedChanged += checkPuesto_CheckedChanged;
            // 
            // checkNombre
            // 
            checkNombre.AutoSize = true;
            checkNombre.Location = new Point(59, 125);
            checkNombre.Margin = new Padding(2);
            checkNombre.Name = "checkNombre";
            checkNombre.Size = new Size(73, 19);
            checkNombre.TabIndex = 17;
            checkNombre.Text = "Nombre:";
            checkNombre.UseVisualStyleBackColor = true;
            checkNombre.CheckedChanged += checkNombre_CheckedChanged;
            // 
            // checkCorreo
            // 
            checkCorreo.AutoSize = true;
            checkCorreo.Location = new Point(59, 82);
            checkCorreo.Margin = new Padding(2);
            checkCorreo.Name = "checkCorreo";
            checkCorreo.Size = new Size(65, 19);
            checkCorreo.TabIndex = 16;
            checkCorreo.Text = "Correo:";
            checkCorreo.UseVisualStyleBackColor = true;
            checkCorreo.CheckedChanged += checkCorreo_CheckedChanged;
            // 
            // txtIDArea
            // 
            txtIDArea.Enabled = false;
            txtIDArea.Location = new Point(147, 213);
            txtIDArea.Margin = new Padding(2);
            txtIDArea.Name = "txtIDArea";
            txtIDArea.Size = new Size(106, 23);
            txtIDArea.TabIndex = 15;
            // 
            // txtPuesto
            // 
            txtPuesto.Enabled = false;
            txtPuesto.Location = new Point(147, 166);
            txtPuesto.Margin = new Padding(2);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(361, 23);
            txtPuesto.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(147, 121);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(147, 78);
            txtCorreo.Margin = new Padding(2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 23);
            txtCorreo.TabIndex = 12;
            // 
            // EditaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 361);
            Controls.Add(pnlEdicion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private TextBox txtIDArea;
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
    }
}