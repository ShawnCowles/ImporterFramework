namespace ImporterFramework
{
    partial class SuccessDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkmarkLabel = new System.Windows.Forms.Label();
            this.completeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkmarkLabel
            // 
            this.checkmarkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkmarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.checkmarkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkmarkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkmarkLabel.Location = new System.Drawing.Point(143, 0);
            this.checkmarkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.checkmarkLabel.Name = "checkmarkLabel";
            this.checkmarkLabel.Size = new System.Drawing.Size(24, 39);
            this.checkmarkLabel.TabIndex = 4;
            this.checkmarkLabel.Text = "✓";
            this.checkmarkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completeLabel
            // 
            this.completeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completeLabel.BackColor = System.Drawing.Color.Transparent;
            this.completeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.completeLabel.Location = new System.Drawing.Point(0, 0);
            this.completeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.completeLabel.Name = "completeLabel";
            this.completeLabel.Size = new System.Drawing.Size(143, 39);
            this.completeLabel.TabIndex = 3;
            this.completeLabel.Text = "Import Complete";
            this.completeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccessDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.checkmarkLabel);
            this.Controls.Add(this.completeLabel);
            this.Name = "SuccessDisplay";
            this.Size = new System.Drawing.Size(167, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label checkmarkLabel;
        private System.Windows.Forms.Label completeLabel;
    }
}
