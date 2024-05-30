namespace PrimerForm
{
    partial class FrmContactos
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColEmail = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            btnNuevo = new Button();
            btnGuardar = new Button();
            saveDialog = new SaveFileDialog();
            btnAbrir = new Button();
            openDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "Contactos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColEmail, ColPhone });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(47, 80);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1040, 696);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_DoubleClick;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 10;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 200;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Nombre";
            ColName.MinimumWidth = 10;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            ColName.Width = 200;
            // 
            // ColEmail
            // 
            ColEmail.DataPropertyName = "Email";
            ColEmail.HeaderText = "Correo";
            ColEmail.MinimumWidth = 10;
            ColEmail.Name = "ColEmail";
            ColEmail.ReadOnly = true;
            ColEmail.Width = 200;
            // 
            // ColPhone
            // 
            ColPhone.DataPropertyName = "Phone";
            ColPhone.HeaderText = "Telefono";
            ColPhone.MinimumWidth = 10;
            ColPhone.Name = "ColPhone";
            ColPhone.ReadOnly = true;
            ColPhone.Width = 200;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.Location = new Point(923, 808);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 46);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(793, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // saveDialog
            // 
            saveDialog.DefaultExt = "xml";
            saveDialog.FileName = "contactos";
            saveDialog.Filter = "Archivos XML (*.xml)|*.xml";
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAbrir.Location = new Point(949, 18);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(150, 46);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // openDialog
            // 
            openDialog.DefaultExt = "xml";
            openDialog.FileName = "contactos";
            openDialog.Filter = "Archivos Xml (*.xml) | *.xml";
            // 
            // FrmContactos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 894);
            Controls.Add(btnAbrir);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "FrmContactos";
            Text = "Listado de Contactos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColEmail;
        private DataGridViewTextBoxColumn ColPhone;
        private Button btnNuevo;
        private Button btnGuardar;
        private SaveFileDialog saveDialog;
        private Button btnAbrir;
        private OpenFileDialog openDialog;
    }
}