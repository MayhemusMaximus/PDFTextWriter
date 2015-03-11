namespace PDFTextWriter
{
    partial class PDFHeatTextWriter
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
            this.BTNWriteHeat = new System.Windows.Forms.Button();
            this.TBOrigin = new System.Windows.Forms.TextBox();
            this.TBDestination = new System.Windows.Forms.TextBox();
            this.BTNOriginBrowse = new System.Windows.Forms.Button();
            this.BTNDestinationBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVFiles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNWriteHeat
            // 
            this.BTNWriteHeat.Location = new System.Drawing.Point(400, 417);
            this.BTNWriteHeat.Name = "BTNWriteHeat";
            this.BTNWriteHeat.Size = new System.Drawing.Size(75, 23);
            this.BTNWriteHeat.TabIndex = 0;
            this.BTNWriteHeat.Text = "Write Heat";
            this.BTNWriteHeat.UseVisualStyleBackColor = true;
            this.BTNWriteHeat.Click += new System.EventHandler(this.WriteHeat_Click);
            // 
            // TBOrigin
            // 
            this.TBOrigin.Location = new System.Drawing.Point(91, 12);
            this.TBOrigin.Name = "TBOrigin";
            this.TBOrigin.ReadOnly = true;
            this.TBOrigin.Size = new System.Drawing.Size(303, 20);
            this.TBOrigin.TabIndex = 1;
            // 
            // TBDestination
            // 
            this.TBDestination.Location = new System.Drawing.Point(91, 38);
            this.TBDestination.Name = "TBDestination";
            this.TBDestination.ReadOnly = true;
            this.TBDestination.Size = new System.Drawing.Size(303, 20);
            this.TBDestination.TabIndex = 1;
            // 
            // BTNOriginBrowse
            // 
            this.BTNOriginBrowse.Location = new System.Drawing.Point(400, 10);
            this.BTNOriginBrowse.Name = "BTNOriginBrowse";
            this.BTNOriginBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTNOriginBrowse.TabIndex = 0;
            this.BTNOriginBrowse.Text = "Browse";
            this.BTNOriginBrowse.UseVisualStyleBackColor = true;
            this.BTNOriginBrowse.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // BTNDestinationBrowse
            // 
            this.BTNDestinationBrowse.Location = new System.Drawing.Point(400, 36);
            this.BTNDestinationBrowse.Name = "BTNDestinationBrowse";
            this.BTNDestinationBrowse.Size = new System.Drawing.Size(75, 23);
            this.BTNDestinationBrowse.TabIndex = 0;
            this.BTNDestinationBrowse.Text = "Browse";
            this.BTNDestinationBrowse.UseVisualStyleBackColor = true;
            this.BTNDestinationBrowse.Click += new System.EventHandler(this.BrowseFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination:";
            // 
            // DGVFiles
            // 
            this.DGVFiles.AllowUserToAddRows = false;
            this.DGVFiles.AllowUserToDeleteRows = false;
            this.DGVFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFiles.Location = new System.Drawing.Point(12, 65);
            this.DGVFiles.Name = "DGVFiles";
            this.DGVFiles.Size = new System.Drawing.Size(463, 346);
            this.DGVFiles.TabIndex = 3;
            // 
            // PDFHeatTextWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 446);
            this.Controls.Add(this.DGVFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDestination);
            this.Controls.Add(this.TBOrigin);
            this.Controls.Add(this.BTNDestinationBrowse);
            this.Controls.Add(this.BTNOriginBrowse);
            this.Controls.Add(this.BTNWriteHeat);
            this.Name = "PDFHeatTextWriter";
            this.Text = "PDF Heat Text Writer";
            this.Load += new System.EventHandler(this.PDFHeatTextWriter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNWriteHeat;
        private System.Windows.Forms.TextBox TBOrigin;
        private System.Windows.Forms.TextBox TBDestination;
        private System.Windows.Forms.Button BTNOriginBrowse;
        private System.Windows.Forms.Button BTNDestinationBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVFiles;
    }
}

