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
                listaNFeProc.Add(nfe);

                if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario == null)
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF);
                }
                else if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco == null)
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                          string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ);
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
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP);
                }


            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
