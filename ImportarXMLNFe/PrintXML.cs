using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZionDanfe;
using ZionDanfe.Modelo;

namespace ImportarXMLNFe
{
    public partial class PrintXML : Form
    {
        PdfiumViewer.PdfViewer pdf;
        public PrintXML(string str)
        {
            InitializeComponent();
            pdf = new PdfViewer();
            pdf.Width = 1400;
            pdf.Height = 700;
            this.Controls.Add(pdf);


            ////https://www.youtube.com/watch?v=jP5dQcUO4CQ
            //// Inicia o Danfe o obtem os Bytes do PDF Gerado
            var modelo = DanfeViewModelCreator.CriarDeArquivoXml(str);
            var pdfStream = new MemoryStream();
            using (var danfe = new Danfe(modelo))
            {
                danfe.Gerar();
                var bytesPdf = danfe.ObterPdfBytes(pdfStream);
                //  byte[] bytes = File.ReadAllBytes(txtpathFolderXml.Text + "\\" + fileinfo.Name);
                var stream = new System.IO.MemoryStream(bytesPdf);
                PdfDocument doc = PdfDocument.Load(stream);
                pdf.Document = doc;
            }

            // webBrowser.Navigate(string.Format(@"file://{0}\danfe.pdf", Application.StartupPath));
            //string filename = Application.StartupPath;
            //filename = Path.GetFullPath(Path.Combine(filename, ".\\danfe.pdf"));
            //webBrowser.Navigate(filename);
        }
    }
}
