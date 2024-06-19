namespace ClinicaMedica
{
    partial class FrmClinicas
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
            bindingClinicas = new BindingSource(components);
            dataGridView1 = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            btnDetalle = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingClinicas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colEstado });
            dataGridView1.DataSource = bindingClinicas;
            dataGridView1.Location = new Point(61, 80);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1324, 772);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 10;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 200;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 10;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 10;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 200;
            // 
            // btnDetalle
            // 
            btnDetalle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDetalle.Location = new Point(71, 877);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(150, 46);
            btnDetalle.TabIndex = 1;
            btnDetalle.Text = "Detalle";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(239, 877);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 46);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(409, 877);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.Location = new Point(1235, 877);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 46);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // FrmClinicas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 980);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnDetalle);
            Controls.Add(dataGridView1);
            Name = "FrmClinicas";
            Text = "FrmClinicas";
            ((System.ComponentModel.ISupportInitialize)bindingClinicas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingClinicas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colEstado;
        private Button btnDetalle;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnNuevo;
    }
}