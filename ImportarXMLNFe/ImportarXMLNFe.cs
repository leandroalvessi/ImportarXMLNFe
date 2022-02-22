using ImportarXMLNFe.Model;
using ImportarXMLNFe.Serializable;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ZionDanfe;
using ZionDanfe.Modelo;

namespace ImportarXMLNFe
{
    public partial class FormImportarXMLNFe : Form
    {
        public FormImportarXMLNFe()
        {
            InitializeComponent();
        }

        List<NFeProc> listaNFeProc = new List<NFeProc>();

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
                    listaNFeProc.Clear();
                    foreach (FileInfo fileinfo in Arquivos)
                    {
                         AtualizarGrid(serializable.GetObjectFromFile<NFeProc>(txtpathFolderXml.Text + "\\" + fileinfo.Name), txtpathFolderXml.Text + "\\" + fileinfo.Name);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AtualizarGrid(NFeProc nfe, string path)
        {
            if (nfe != null)
            {
                listaNFeProc.Add(nfe);

                if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario == null)
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF,
                                          path);
                }
                else if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco == null)
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                          string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ,
                                          path);
                }
                else
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                          string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xMun,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.UF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP,
                                          path);
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
            {
                PrintXML printXML = new PrintXML(dataGridView.SelectedRows[0].Cells[8].Value.ToString());
                printXML.ShowDialog();
            }
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
                {
                    var nfe = listaNFeProc.Find(x => x.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF == dataGridView.SelectedRows[0].Cells[0].Value);

                    DetalheXMLNFe detalhe = new DetalheXMLNFe(nfe);
                    detalhe.ShowDialog();
                }
            }
        }
    }
}
