namespace ReporteImpresoras
{
    partial class VentanaCarga
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
            lblCarga = new Label();
            picCarga = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCarga).BeginInit();
            SuspendLayout();
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Location = new Point(62, 142);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(90, 25);
            lblCarga.TabIndex = 0;
            lblCarga.Text = "Cargando";
            // 
            // picCarga
            // 
            picCarga.Image = Properties.Resources.Load;
            picCarga.Location = new Point(82, 56);
            picCarga.Name = "picCarga";
            picCarga.Size = new Size(50, 50);
            picCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            picCarga.TabIndex = 1;
            picCarga.TabStop = false;
            // 
            // VentanaCarga
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 215);
            Controls.Add(picCarga);
            Controls.Add(lblCarga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaCarga";
            Opacity = 0.8D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaCarga";
            ((System.ComponentModel.ISupportInitialize)picCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCarga;
        private PictureBox picCarga;
    }
}