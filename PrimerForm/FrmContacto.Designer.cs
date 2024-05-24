namespace PrimerForm
{
    partial class FrmContacto
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
            txtNombre = new TextBox();
            labelemail = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(540, 39);
            txtNombre.TabIndex = 1;
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.Location = new Point(49, 120);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(86, 32);
            labelemail.TabIndex = 2;
            labelemail.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(199, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(540, 39);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 196);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 4;
            label2.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(199, 193);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(540, 39);
            txtTelefono.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(589, 268);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(150, 46);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmContacto
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(labelemail);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximumSize = new Size(826, 423);
            MinimumSize = new Size(826, 423);
            Name = "FrmContacto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label labelemail;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtTelefono;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}