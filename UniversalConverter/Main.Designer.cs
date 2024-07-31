namespace UniversalConverter
{
    partial class UniversalConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversalConverter));
            btnCreatePdf = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtOutputFileName = new TextBox();
            pnlMain = new Panel();
            groupBox2 = new GroupBox();
            btnMergePdf = new Button();
            btnImage2Pdf = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreatePdf
            // 
            btnCreatePdf.Location = new Point(0, 0);
            btnCreatePdf.Name = "btnCreatePdf";
            btnCreatePdf.Size = new Size(75, 23);
            btnCreatePdf.TabIndex = 0;
            // 
            // txtOutputFileName
            // 
            txtOutputFileName.Location = new Point(0, 0);
            txtOutputFileName.Name = "txtOutputFileName";
            txtOutputFileName.Size = new Size(100, 23);
            txtOutputFileName.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Location = new Point(191, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(608, 391);
            pnlMain.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMergePdf);
            groupBox2.Controls.Add(btnImage2Pdf);
            groupBox2.Location = new Point(8, -4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 400);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // btnMergePdf
            // 
            btnMergePdf.FlatStyle = FlatStyle.Flat;
            btnMergePdf.Location = new Point(6, 70);
            btnMergePdf.Name = "btnMergePdf";
            btnMergePdf.Size = new Size(165, 39);
            btnMergePdf.TabIndex = 0;
            btnMergePdf.Text = "Merge PDF";
            btnMergePdf.UseVisualStyleBackColor = true;
            btnMergePdf.Click += btnMergePdf_Click;
            // 
            // btnImage2Pdf
            // 
            btnImage2Pdf.FlatStyle = FlatStyle.Flat;
            btnImage2Pdf.Location = new Point(6, 25);
            btnImage2Pdf.Name = "btnImage2Pdf";
            btnImage2Pdf.Size = new Size(165, 39);
            btnImage2Pdf.TabIndex = 0;
            btnImage2Pdf.Text = "Image To PDF";
            btnImage2Pdf.UseVisualStyleBackColor = true;
            btnImage2Pdf.Click += btnImage2Pdf_Click;
            // 
            // UniversalConverter
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 401);
            Controls.Add(groupBox2);
            Controls.Add(pnlMain);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UniversalConverter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universal Converter";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreatePdf;
        private OpenFileDialog openFileDialog1;
        private TextBox txtOutputFileName;
        private Panel pnlMain;
        private GroupBox groupBox2;
        private Button btnMergePdf;
        private Button btnImage2Pdf;
    }
}
