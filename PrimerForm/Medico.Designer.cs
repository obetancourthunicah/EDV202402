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
            components = new System.ComponentModel.Container();
            lblTexto = new Label();
            saveDialog = new SaveFileDialog();
            btnExportar = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(702, 300);
            dataGridView1.TabIndex = 2;
            // 
            // Medico
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(dataGridView1);
            Controls.Add(btnExportar);
            Controls.Add(lblTexto);
            Name = "Medico";
            Text = "Medico";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private SaveFileDialog saveDialog;
        private Button btnExportar;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
    }
}