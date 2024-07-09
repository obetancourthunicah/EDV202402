namespace ClinicaMedica
{
    partial class WebApi
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
            lblResult = new Label();
            btnGetList = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(29, 22);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(1170, 550);
            lblResult.TabIndex = 0;
            lblResult.Text = "label1";
            // 
            // btnGetList
            // 
            btnGetList.Location = new Point(1001, 584);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(150, 46);
            btnGetList.TabIndex = 1;
            btnGetList.Text = "GetList";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // WebApi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 634);
            Controls.Add(btnGetList);
            Controls.Add(lblResult);
            Name = "WebApi";
            Text = "WebApi";
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Button btnGetList;
    }
}