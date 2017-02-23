namespace ImporterFramework
{
    partial class ImportResultsForm<T>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.resultsDetailArea = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(12, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 30);
            this.panel1.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(3, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "label1";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Location = new System.Drawing.Point(624, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resultsList
            // 
            this.resultsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultsList.FormattingEnabled = true;
            this.resultsList.Location = new System.Drawing.Point(12, 12);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(166, 446);
            this.resultsList.TabIndex = 1;
            this.resultsList.SelectedIndexChanged += new System.EventHandler(this.resultsList_SelectedIndexChanged);
            // 
            // resultsDetailArea
            // 
            this.resultsDetailArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsDetailArea.Location = new System.Drawing.Point(184, 12);
            this.resultsDetailArea.Multiline = true;
            this.resultsDetailArea.Name = "resultsDetailArea";
            this.resultsDetailArea.ReadOnly = true;
            this.resultsDetailArea.Size = new System.Drawing.Size(527, 446);
            this.resultsDetailArea.TabIndex = 2;
            // 
            // ImportResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.resultsDetailArea);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.panel1);
            this.Name = "ImportResultsForm";
            this.Text = "ImporterFramework";
            this.Load += new System.EventHandler(this.ImportResultsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.TextBox resultsDetailArea;
    }
}

