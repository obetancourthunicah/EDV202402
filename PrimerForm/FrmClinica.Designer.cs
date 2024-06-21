namespace ClinicaMedica
{
    partial class FrmClinica
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            cmbEstado = new ComboBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            tituloFormulario = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 166);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 235);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 304);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 373);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 442);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 4;
            label5.Text = "Estado";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(233, 163);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(508, 39);
            txtCodigo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(233, 232);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(508, 39);
            txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(233, 301);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(508, 39);
            txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(233, 370);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(508, 39);
            txtTelefono.TabIndex = 8;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstado.Location = new Point(233, 439);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(508, 40);
            cmbEstado.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(423, 516);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 46);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(591, 516);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tituloFormulario
            // 
            tituloFormulario.AutoSize = true;
            tituloFormulario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tituloFormulario.Location = new Point(71, 58);
            tituloFormulario.Name = "tituloFormulario";
            tituloFormulario.Size = new Size(368, 51);
            tituloFormulario.TabIndex = 12;
            tituloFormulario.Text = "Trabajar con Clinica";
            // 
            // FrmClinica
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(tituloFormulario);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbEstado);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmClinica";
            Text = "FrmClinica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private ComboBox cmbEstado;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label tituloFormulario;
    }
}