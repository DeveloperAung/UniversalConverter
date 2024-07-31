using System;
using System.Collections.Generic;
using System.Diagnostics;
using iText.Kernel.Utils;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace UniversalConverter
{
    public partial class UCMergePdf : UserControl
    {
        public UCMergePdf()
        {
            InitializeComponent();
            txtOutputFileName.Text = DateTime.Now.ToString("yyyyMMdd_HHmm");
        }

        public void MergePdfFiles(string outputPdfPath, List<string> inputPdfPaths)
        {
            using (PdfDocument outputDocument = new PdfDocument())
            {
                foreach (string file in inputPdfPaths)
                {
                    using (PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import))
                    {
                        // Iterate through all pages of the document to import each page
                        for (int idx = 0; idx < inputDocument.PageCount; idx++)
                        {
                            PdfPage page = inputDocument.Pages[idx];
                            outputDocument.AddPage(page);
                        }
                    }
                }
                outputDocument.Save(outputPdfPath);
            }
        }

        private void btnMergePdf_Click(object sender, EventArgs e)
        {
            // Configure OpenFileDialog
            string file_name = "output";
            if (txtOutputFileName.Text != "")
            {
                file_name = txtOutputFileName.Text;
            }
            else
            {
                file_name = "output";
            }
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "PDF Files|*.pdf|All Files|*.*";

            // Show the OpenFileDialog and check if the user selects files
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file paths
                string[] filePaths = openFileDialog1.FileNames;

                // Define the output directory
                string outputFolder = DateTime.Now.ToString("yyyyMMdd");
                string outputDirectory = Path.Combine(@"D:/MergePDF", outputFolder);
                // Ensure the output directory exists
                if (!Directory.Exists(outputDirectory))
                {
                    try
                    {
                        Directory.CreateDirectory(outputDirectory);
                    }
                    catch (Exception ex)
                    {
                        outputDirectory = Path.Combine(Path.GetDirectoryName(filePaths[0]), outputFolder);
                        Directory.CreateDirectory(outputDirectory);
                    }
                }

                // Define the output PDF path
                string outputFileName = file_name + ".pdf";
                string outputPdfPath = Path.Combine(outputDirectory, outputFileName);

                try
                {
                    // Create PDF from images
                    MergePdfFiles(outputPdfPath, new List<string>(filePaths));
                    MessageBox.Show(outputDirectory);
                    Process.Start("explorer.exe", outputDirectory.Replace("/", "\\"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}\nStack Trace: {ex.StackTrace}");
                }
            }
        }
    }    
}


