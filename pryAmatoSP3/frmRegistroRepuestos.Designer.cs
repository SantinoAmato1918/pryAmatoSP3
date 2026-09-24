namespace pryAmatoSP3
{
    partial class frmRegistroRepuestos
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
            lblMarca = new Label();
            cmbMarca = new ComboBox();
            gpbOrigen = new GroupBox();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            lblNumero = new Label();
            lblPrecio = new Label();
            txtNumero = new TextBox();
            txtPrecio = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lstRepuesto = new ListBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            gpbOrigen.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 38);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(45, 17);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P", "R", "F" });
            cmbMarca.Location = new Point(113, 37);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(148, 23);
            cmbMarca.TabIndex = 1;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // gpbOrigen
            // 
            gpbOrigen.Controls.Add(rbImportado);
            gpbOrigen.Controls.Add(rbNacional);
            gpbOrigen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbOrigen.Location = new Point(26, 84);
            gpbOrigen.Name = "gpbOrigen";
            gpbOrigen.Size = new Size(235, 58);
            gpbOrigen.TabIndex = 2;
            gpbOrigen.TabStop = false;
            gpbOrigen.Text = "Origen";
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(141, 24);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(88, 21);
            rbImportado.TabIndex = 1;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(45, 24);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(77, 21);
            rbNacional.TabIndex = 0;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(26, 159);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(56, 17);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Número";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(27, 208);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(44, 17);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(126, 158);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(135, 23);
            txtNumero.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(126, 207);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(135, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(226, 342);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(145, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lstRepuesto
            // 
            lstRepuesto.FormattingEnabled = true;
            lstRepuesto.Location = new Point(27, 371);
            lstRepuesto.Name = "lstRepuesto";
            lstRepuesto.Size = new Size(267, 109);
            lstRepuesto.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(27, 250);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(76, 17);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(117, 250);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(144, 86);
            txtDescripcion.TabIndex = 11;
            // 
            // frmRegistroRepuestos
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(317, 499);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lstRepuesto);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNumero);
            Controls.Add(lblPrecio);
            Controls.Add(lblNumero);
            Controls.Add(gpbOrigen);
            Controls.Add(cmbMarca);
            Controls.Add(lblMarca);
            MaximizeBox = false;
            Name = "frmRegistroRepuestos";
            Text = "Gestión de Repuestos";
            Load += frmRegistroRepuestos_Load;
            gpbOrigen.ResumeLayout(false);
            gpbOrigen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private ComboBox cmbMarca;
        private GroupBox gpbOrigen;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private Label lblNumero;
        private Label lblPrecio;
        private TextBox txtNumero;
        private TextBox txtPrecio;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ListBox lstRepuesto;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
    }
}