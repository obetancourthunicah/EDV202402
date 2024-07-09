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
            btnNext = new Button();
            btnPrevious = new Button();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(29, 22);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(16);
            lblResult.Size = new Size(1170, 818);
            lblResult.TabIndex = 0;
            lblResult.Text = "Click Get List to Start";
            // 
            // btnGetList
            // 
            btnGetList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGetList.Location = new Point(523, 852);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(150, 46);
            btnGetList.TabIndex = 1;
            btnGetList.Text = "GetList";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Location = new Point(720, 852);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 46);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Visible = false;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrevious.Location = new Point(324, 852);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(150, 46);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Visible = false;
            // 
            // WebApi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 910);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnGetList);
            Controls.Add(lblResult);
            Name = "WebApi";
            Text = "WebApi";
            ResumeLayout(false);
        }

        #endregion

        private Label lblResult;
        private Button btnGetList;
        private Button btnNext;
        private Button btnPrevious;
    }
}