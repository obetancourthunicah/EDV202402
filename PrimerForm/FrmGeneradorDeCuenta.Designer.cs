namespace PrimerForm
{
    partial class FrmGeneradorDeCuenta
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
            label1 = new Label();
            txtNumeroCuenta = new TextBox();
            btnSubstituir = new Button();
            txtNuevoNumero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubstituir = new TextBox();
            txtPor = new TextBox();
            txtSubstituciones = new TextBox();
            btnAddSubstituciones = new Button();
            chkInvertir = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 44);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Numero de Cuenta";
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.Location = new Point(295, 44);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(352, 39);
            txtNumeroCuenta.TabIndex = 1;
            txtNumeroCuenta.TextChanged += txtNumerCuenta_OnTextChanged;
            // 
            // btnSubstituir
            // 
            btnSubstituir.Enabled = false;
            btnSubstituir.Location = new Point(497, 532);
            btnSubstituir.Name = "btnSubstituir";
            btnSubstituir.Size = new Size(150, 46);
            btnSubstituir.TabIndex = 10;
            btnSubstituir.Text = "Substituir";
            btnSubstituir.UseVisualStyleBackColor = true;
            btnSubstituir.Click += btnSubstituir_Click;
            // 
            // txtNuevoNumero
            // 
            txtNuevoNumero.Location = new Point(53, 605);
            txtNuevoNumero.Name = "txtNuevoNumero";
            txtNuevoNumero.ReadOnly = true;
            txtNuevoNumero.Size = new Size(594, 39);
            txtNuevoNumero.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 121);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 2;
            label2.Text = "Agregar Substituciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 190);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 3;
            label3.Text = "Substituir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 186);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 5;
            label4.Text = "Por";
            // 
            // txtSubstituir
            // 
            txtSubstituir.Location = new Point(177, 183);
            txtSubstituir.Name = "txtSubstituir";
            txtSubstituir.Size = new Size(126, 39);
            txtSubstituir.TabIndex = 4;
            // 
            // txtPor
            // 
            txtPor.Location = new Point(379, 183);
            txtPor.Name = "txtPor";
            txtPor.Size = new Size(81, 39);
            txtPor.TabIndex = 6;
            // 
            // txtSubstituciones
            // 
            txtSubstituciones.Location = new Point(53, 235);
            txtSubstituciones.Multiline = true;
            txtSubstituciones.Name = "txtSubstituciones";
            txtSubstituciones.ReadOnly = true;
            txtSubstituciones.Size = new Size(594, 180);
            txtSubstituciones.TabIndex = 8;
            // 
            // btnAddSubstituciones
            // 
            btnAddSubstituciones.Enabled = false;
            btnAddSubstituciones.Location = new Point(466, 183);
            btnAddSubstituciones.Name = "btnAddSubstituciones";
            btnAddSubstituciones.Size = new Size(56, 46);
            btnAddSubstituciones.TabIndex = 7;
            btnAddSubstituciones.Text = "+";
            btnAddSubstituciones.UseVisualStyleBackColor = true;
            btnAddSubstituciones.Click += btnAddSubstituciones_Click;
            // 
            // chkInvertir
            // 
            chkInvertir.AutoSize = true;
            chkInvertir.Location = new Point(53, 434);
            chkInvertir.Name = "chkInvertir";
            chkInvertir.Size = new Size(121, 36);
            chkInvertir.TabIndex = 9;
            chkInvertir.Text = "Invertir";
            chkInvertir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 684);
            Controls.Add(chkInvertir);
            Controls.Add(btnAddSubstituciones);
            Controls.Add(txtSubstituciones);
            Controls.Add(txtPor);
            Controls.Add(txtSubstituir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNuevoNumero);
            Controls.Add(btnSubstituir);
            Controls.Add(txtNumeroCuenta);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeroCuenta;
        private Button btnSubstituir;
        private TextBox txtNuevoNumero;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubstituir;
        private TextBox txtPor;
        private TextBox txtSubstituciones;
        private Button btnAddSubstituciones;
        private CheckBox chkInvertir;
    }
}
