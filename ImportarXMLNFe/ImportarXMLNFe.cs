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
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xFant,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.IE,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF);
                }
                else if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco == null)
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xFant,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.IE,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                          string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.email);
                }
                else
                {
                    dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.serie.ToString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.natOp,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xNome,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.xFant,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.IE,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xLgr,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.nro,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.xMun,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.Endereco.UF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                          string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.email,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xLgr,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.nro,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xMun,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.UF,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP,
                                          nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xBairro);
                }


            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
            {
                /* Populando tab Identificação */
                Identificacao i = new Identificacao();
                i.nNF = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                i.mod = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                i.serie = Convert.ToInt16(dataGridView.SelectedRows[0].Cells[2].Value);
                i.dhEmi = Convert.ToDateTime(dataGridView.SelectedRows[0].Cells[3].Value.ToString());
                i.natOp = dataGridView.SelectedRows[0].Cells[4].Value.ToString();

                /* Populando tab Emitente */
                Emitente em = new Emitente();
                if (dataGridView.SelectedRows[0].Cells[5].Value != null)
                {
                    em.xNome = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[6].Value != null)
                {
                    em.xFant = dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[7].Value != null)
                {
                    em.CNPJ = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[8].Value != null)
                {
                    em.IE = dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                }

                Endereco enEmi = new Endereco();
                enEmi.xLgr = dataGridView.SelectedRows[0].Cells[9].Value.ToString();
                enEmi.nro = dataGridView.SelectedRows[0].Cells[10].Value.ToString();
                enEmi.xMun = dataGridView.SelectedRows[0].Cells[11].Value.ToString();
                enEmi.UF = dataGridView.SelectedRows[0].Cells[12].Value.ToString();

                /* Populando tab Destinatário */
                Destinatario d = new Destinatario();
                if (dataGridView.SelectedRows[0].Cells[13].Value != null)
                {
                    d.xNome = dataGridView.SelectedRows[0].Cells[13].Value.ToString();                    
                }

                if (dataGridView.SelectedRows[0].Cells[14].Value != null)
                {
                    d.CNPJ = dataGridView.SelectedRows[0].Cells[14].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[15].Value != null)
                {
                    d.email = dataGridView.SelectedRows[0].Cells[15].Value.ToString();
                }

                Endereco enDes = new Endereco();
                if (dataGridView.SelectedRows[0].Cells[16].Value != null)
                {
                    enDes.xLgr = dataGridView.SelectedRows[0].Cells[16].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[17].Value != null)
                {
                    enDes.nro = dataGridView.SelectedRows[0].Cells[17].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[18].Value != null)
                {
                    enDes.xMun = dataGridView.SelectedRows[0].Cells[18].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[19].Value != null)
                {
                    enDes.UF = dataGridView.SelectedRows[0].Cells[19].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[20].Value != null)
                {
                    enDes.CEP = dataGridView.SelectedRows[0].Cells[20].Value.ToString();
                }

                if (dataGridView.SelectedRows[0].Cells[21].Value != null)
                {
                    enDes.xBairro = dataGridView.SelectedRows[0].Cells[21].Value.ToString();
                }

                DetalheXMLNFe detalhe = new DetalheXMLNFe(i, em, enEmi, d, enDes);
                detalhe.ShowDialog();
            }
        }
    }
}
