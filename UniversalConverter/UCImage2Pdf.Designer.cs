namespace UniversalConverter
{
    partial class UCImage2Pdf
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
            groupBox1 = new GroupBox();
            btnCreatePdf = new Button();
            txtOutputFileName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnCreatePdf);
            groupBox1.Controls.Add(txtOutputFileName);
            groupBox1.Location = new Point(4, 5);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(584, 109);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convert Image 2 Pdf";
            // 
            // btnCreatePdf
            // 
            btnCreatePdf.Location = new Point(303, 49);
            btnCreatePdf.Margin = new Padding(4);
            btnCreatePdf.Name = "btnCreatePdf";
            btnCreatePdf.Size = new Size(255, 34);
            btnCreatePdf.TabIndex = 0;
            btnCreatePdf.Text = "Upload file / Create PDF";
            btnCreatePdf.UseVisualStyleBackColor = true;
            btnCreatePdf.Click += btnCreatePdf_Click;
            // 
            // txtOutputFileName
            // 
            txtOutputFileName.Location = new Point(19, 53);
            txtOutputFileName.Margin = new Padding(4);
            txtOutputFileName.Name = "txtOutputFileName";
            txtOutputFileName.PlaceholderText = "Type Output File Name";
            txtOutputFileName.Size = new Size(261, 26);
            txtOutputFileName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif\"";
            openFileDialog1.Multiselect = true;
            // 
            // UCImage2Pdf
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UCImage2Pdf";
            Size = new Size(595, 450);
            Load += UCImage2Pdf_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCreatePdf;
        private TextBox txtOutputFileName;
        private OpenFileDialog openFileDialog1;
    }
}
