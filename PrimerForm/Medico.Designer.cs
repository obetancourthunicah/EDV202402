namespace PrimerForm
{
    partial class Medico
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
            lblTexto = new Label();
            saveDialog = new SaveFileDialog();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(51, 40);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(71, 32);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Texto";
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "demoExcel";
            saveDialog.Filter = "Archivos de Excel 2007+ | *.xlsx";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(51, 98);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(150, 46);
            btnExportar.TabIndex = 1;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Medico
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportar);
            Controls.Add(lblTexto);
            Name = "Medico";
            Text = "Medico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private SaveFileDialog saveDialog;
        private Button btnExportar;
    }
}