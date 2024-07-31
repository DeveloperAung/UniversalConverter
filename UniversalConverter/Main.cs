namespace UniversalConverter
{
    public partial class UniversalConverter : Form
    {
        public UniversalConverter()
        {
            InitializeComponent();
        }

        private void btnImage2Pdf_Click(object sender, EventArgs e)
        {
            UCImage2Pdf ucImage2Pdf = new UCImage2Pdf();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucImage2Pdf);
        }

        private void btnMergePdf_Click(object sender, EventArgs e)
        {
            UCMergePdf ucMergePDF = new UCMergePdf();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucMergePDF);
        }
    }
}
