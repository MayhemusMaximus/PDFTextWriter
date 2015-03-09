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
            this.btnWriteHeat = new System.Windows.Forms.Button();
            this.txtboxOriginalPDF = new System.Windows.Forms.TextBox();
            this.txtboxToDirectory = new System.Windows.Forms.TextBox();
            this.btnOriginalPDFBrowse = new System.Windows.Forms.Button();
            this.btnToDirectoryBrowse = new System.Windows.Forms.Button();
            this.txtboxHeatNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWriteHeat
            // 
            this.btnWriteHeat.Location = new System.Drawing.Point(400, 62);
            this.btnWriteHeat.Name = "btnWriteHeat";
            this.btnWriteHeat.Size = new System.Drawing.Size(75, 23);
            this.btnWriteHeat.TabIndex = 0;
            this.btnWriteHeat.Text = "Write Heat";
            this.btnWriteHeat.UseVisualStyleBackColor = true;
            this.btnWriteHeat.Click += new System.EventHandler(this.WriteHeat_Click);
            // 
            // txtboxOriginalPDF
            // 
            this.txtboxOriginalPDF.Location = new System.Drawing.Point(91, 12);
            this.txtboxOriginalPDF.Name = "txtboxOriginalPDF";
            this.txtboxOriginalPDF.ReadOnly = true;
            this.txtboxOriginalPDF.Size = new System.Drawing.Size(303, 20);
            this.txtboxOriginalPDF.TabIndex = 1;
            // 
            // txtboxToDirectory
            // 
            this.txtboxToDirectory.Location = new System.Drawing.Point(91, 38);
            this.txtboxToDirectory.Name = "txtboxToDirectory";
            this.txtboxToDirectory.ReadOnly = true;
            this.txtboxToDirectory.Size = new System.Drawing.Size(303, 20);
            this.txtboxToDirectory.TabIndex = 1;
            // 
            // btnOriginalPDFBrowse
            // 
            this.btnOriginalPDFBrowse.Location = new System.Drawing.Point(400, 10);
            this.btnOriginalPDFBrowse.Name = "btnOriginalPDFBrowse";
            this.btnOriginalPDFBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalPDFBrowse.TabIndex = 0;
            this.btnOriginalPDFBrowse.Text = "Browse";
            this.btnOriginalPDFBrowse.UseVisualStyleBackColor = true;
            this.btnOriginalPDFBrowse.Click += new System.EventHandler(this.BrowseFiles_Click);
            // 
            // btnToDirectoryBrowse
            // 
            this.btnToDirectoryBrowse.Location = new System.Drawing.Point(400, 36);
            this.btnToDirectoryBrowse.Name = "btnToDirectoryBrowse";
            this.btnToDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnToDirectoryBrowse.TabIndex = 0;
            this.btnToDirectoryBrowse.Text = "Browse";
            this.btnToDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnToDirectoryBrowse.Click += new System.EventHandler(this.BF_Click);
            // 
            // txtboxHeatNumber
            // 
            this.txtboxHeatNumber.Location = new System.Drawing.Point(91, 64);
            this.txtboxHeatNumber.Name = "txtboxHeatNumber";
            this.txtboxHeatNumber.Size = new System.Drawing.Size(303, 20);
            this.txtboxHeatNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Heat #";
            // 
            // PDFHeatTextWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 103);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxHeatNumber);
            this.Controls.Add(this.txtboxToDirectory);
            this.Controls.Add(this.txtboxOriginalPDF);
            this.Controls.Add(this.btnToDirectoryBrowse);
            this.Controls.Add(this.btnOriginalPDFBrowse);
            this.Controls.Add(this.btnWriteHeat);
            this.Name = "PDFHeatTextWriter";
            this.Text = "PDF Heat Text Writer";
            this.Load += new System.EventHandler(this.PDFHeatTextWriter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteHeat;
        private System.Windows.Forms.TextBox txtboxOriginalPDF;
        private System.Windows.Forms.TextBox txtboxToDirectory;
        private System.Windows.Forms.Button btnOriginalPDFBrowse;
        private System.Windows.Forms.Button btnToDirectoryBrowse;
        private System.Windows.Forms.TextBox txtboxHeatNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

