using ImportarXMLNFe.Model;
using ImportarXMLNFe.Serializable;
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

namespace ImportarXMLNFe
{
    public partial class FormImportarXMLNFe : Form
    {
        public FormImportarXMLNFe()
        {
            InitializeComponent();
        }

        private void btnLerFolderXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtpathFolderXml.Text = folderBrowserDialog1.SelectedPath;
                    DirectoryInfo diretorio = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                    FileInfo[] Arquivos = diretorio.GetFiles("*.xml");

                    NFeSerialization serializable = new NFeSerialization();

                    dataGridView.Rows.Clear();
                    foreach (FileInfo fileinfo in Arquivos)
                    {
                        AtualizarGrid(serializable.GetObjectFromFile<NFeProc>(txtpathFolderXml.Text + "\\" + fileinfo.Name));
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AtualizarGrid(NFeProc nfe)
        {
            if (nfe != null)
            {
                dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                      nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod,
                                      nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString(),
                                      nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                      nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp);
            }
        }
    }
}
