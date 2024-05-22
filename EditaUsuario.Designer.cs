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
            pnlEdicion.Location = new Point(33, 24);
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Size = new Size(838, 538);
            pnlEdicion.TabIndex = 0;
            // 
            // btnSalirEdicion
            // 
            btnSalirEdicion.Location = new Point(685, 470);
            btnSalirEdicion.Name = "btnSalirEdicion";
            btnSalirEdicion.Size = new Size(112, 34);
            btnSalirEdicion.TabIndex = 22;
            btnSalirEdicion.Text = "Cancelar";
            btnSalirEdicion.UseVisualStyleBackColor = true;
            btnSalirEdicion.Click += btnSalirEdicion_Click;
            // 
            // btnEdicionConfirm
            // 
            btnEdicionConfirm.Location = new Point(405, 426);
            btnEdicionConfirm.Name = "btnEdicionConfirm";
            btnEdicionConfirm.Size = new Size(112, 34);
            btnEdicionConfirm.TabIndex = 21;
            btnEdicionConfirm.Text = "Editar";
            btnEdicionConfirm.UseVisualStyleBackColor = true;
            // 
            // lblEdicionTitulo
            // 
            lblEdicionTitulo.AutoSize = true;
            lblEdicionTitulo.Font = new Font("Segoe UI", 10F);
            lblEdicionTitulo.Location = new Point(66, 55);
            lblEdicionTitulo.Name = "lblEdicionTitulo";
            lblEdicionTitulo.Size = new Size(368, 28);
            lblEdicionTitulo.TabIndex = 20;
            lblEdicionTitulo.Text = "Selecciona los campos que deseas editar:";
            // 
            // checkID_Area
            // 
            checkID_Area.AutoSize = true;
            checkID_Area.Location = new Point(66, 357);
            checkID_Area.Name = "checkID_Area";
            checkID_Area.Size = new Size(99, 29);
            checkID_Area.TabIndex = 19;
            checkID_Area.Text = "ID_Area";
            checkID_Area.UseVisualStyleBackColor = true;
            // 
            // checkPuesto
            // 
            checkPuesto.AutoSize = true;
            checkPuesto.Location = new Point(66, 276);
            checkPuesto.Name = "checkPuesto";
            checkPuesto.Size = new Size(96, 29);
            checkPuesto.TabIndex = 18;
            checkPuesto.Text = "Puesto:";
            checkPuesto.UseVisualStyleBackColor = true;
            // 
            // checkNombre
            // 
            checkNombre.AutoSize = true;
            checkNombre.Location = new Point(66, 202);
            checkNombre.Name = "checkNombre";
            checkNombre.Size = new Size(108, 29);
            checkNombre.TabIndex = 17;
            checkNombre.Text = "Nombre:";
            checkNombre.UseVisualStyleBackColor = true;
            // 
            // checkCorreo
            // 
            checkCorreo.AutoSize = true;
            checkCorreo.Location = new Point(66, 130);
            checkCorreo.Name = "checkCorreo";
            checkCorreo.Size = new Size(96, 29);
            checkCorreo.TabIndex = 16;
            checkCorreo.Text = "Correo:";
            checkCorreo.UseVisualStyleBackColor = true;
            // 
            // txtIDArea
            // 
            txtIDArea.Location = new Point(210, 355);
            txtIDArea.Name = "txtIDArea";
            txtIDArea.Size = new Size(150, 31);
            txtIDArea.TabIndex = 15;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(210, 276);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(514, 31);
            txtPuesto.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(514, 31);
            txtNombre.TabIndex = 13;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(210, 130);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(514, 31);
            txtCorreo.TabIndex = 12;
            // 
            // EditaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 601);
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