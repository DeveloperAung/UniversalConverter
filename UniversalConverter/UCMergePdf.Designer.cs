namespace UniversalConverter
{
    partial class UCMergePdf
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
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            btnMergePdf = new Button();
            txtOutputFileName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif\"";
            openFileDialog1.Multiselect = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnMergePdf);
            groupBox1.Controls.Add(txtOutputFileName);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(645, 109);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Merge PDF files";
            // 
            // btnMergePdf
            // 
            btnMergePdf.Location = new Point(303, 49);
            btnMergePdf.Margin = new Padding(4);
            btnMergePdf.Name = "btnMergePdf";
            btnMergePdf.Size = new Size(134, 34);
            btnMergePdf.TabIndex = 0;
            btnMergePdf.Text = "Upload / Merge";
            btnMergePdf.UseVisualStyleBackColor = true;
            btnMergePdf.Click += btnMergePdf_Click;
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
            // UCMergePdf
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UCMergePdf";
            Size = new Size(653, 452);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private Button btnMergePdf;
        private TextBox txtOutputFileName;
    }
}
