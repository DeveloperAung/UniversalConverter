using PdfSharp.Drawing;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;

namespace UniversalConverter
{
    public partial class UCImage2Pdf : UserControl
    {
        public UCImage2Pdf()
        {
            InitializeComponent();
        }

        private void UCImage2Pdf_Load(object sender, EventArgs e)
        {
            txtOutputFileName.Text = DateTime.Now.ToString("yyyyMMdd_HHmm");
        }

        public void CreatePdfFromImages(string outputPdfPath, string[] imagePaths)
        {
            try
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();

                foreach (string imagePath in imagePaths)
                {
                    // Verify the image file exists
                    if (!File.Exists(imagePath))
                    {
                        MessageBox.Show($"Image file does not exist: {imagePath}");
                        continue;
                    }

                    // Create a new PDF page
                    PdfPage page = document.AddPage();

                    // Draw the image on the PDF page
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XImage image = XImage.FromFile(imagePath);

                    // Resize the page to match the image size
                    page.Width = image.PixelWidth;
                    page.Height = image.PixelHeight;

                    gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                }

                // Save the document
                document.Save(outputPdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the PDF: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
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
            openFileDialog1.Filter = "PDF Files|*.pdf;";

            // Show the OpenFileDialog and check if the user selects files
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file paths
                string[] imagePaths = openFileDialog1.FileNames;

                // Define the output directory
                string outputFolder = DateTime.Now.ToString("yyyyMMdd");
                string outputDirectory = Path.Combine(@"D:/Image2Pdf", outputFolder);
                // Ensure the output directory exists
                if (!Directory.Exists(outputDirectory))
                {
                    try
                    {
                        Directory.CreateDirectory(outputDirectory);
                    }
                    catch (Exception ex)
                    {
                        outputDirectory = Path.Combine(Path.GetDirectoryName(imagePaths[0]), outputFolder);
                        Directory.CreateDirectory(outputDirectory);
                        //MessageBox.Show("output directory" + outputDirectory);
                        //MessageBox.Show($"Failed to create output directory: {ex.Message}");
                        //return;
                    }
                }

                // Define the output PDF path
                string outputFileName = file_name + ".pdf";
                string outputPdfPath = Path.Combine(outputDirectory, outputFileName);

                try
                {
                    // Create PDF from images
                    CreatePdfFromImages(outputPdfPath, imagePaths);
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
