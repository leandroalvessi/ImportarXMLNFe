using ACBrLib.NFe;
using ImportarXMLNFe.Model;
using ImportarXMLNFe.Serializable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImportarXMLNFe
{
    public partial class FormImportarXMLNFe : Form
    {
        private ACBrNFe ACBrNFe;
        List<NFeProc> listaNFeProc = new List<NFeProc>();
        public FormImportarXMLNFe()
        {
            InitializeComponent();
            ACBrNFe = new ACBrNFe();

            dtaInicio.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtaFim.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        public void AtualizarGrid(NFeProc nfe, string path)
        {
            if (nfe != null)
            {
                if (radioSaida.Checked)
                {
                    if (string.Join("", txtCpfCnpj.Text.Split('.', '-', '/')) != nfe.NotaFiscalEletronica.InformacoesNFe.Emitente.CNPJ)
                    {
                        return;
                    }
                }
                else if (radioEntrada.Checked)
                {
                    if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario != null)
                    {
                        if (string.Join("", txtCpfCnpj.Text.Split('.', '-', '/')) != (string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ))
                        {
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }

                if ((nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.Date >= dtaInicio.Value) &&
                    (nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.Date <= dtaFim.Value))
                {
                    listaNFeProc.Add(nfe);
                    if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario == null)
                    {
                        dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod == "55" ? "NF-e" : "NFC-e",
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF,
                                              path);
                    }
                    else if (nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco == null)
                    {
                        dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod == "55" ? "NF-e" : "NFC-e",
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, path,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                              string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ);
                    }
                    else
                    {
                        dataGridView.Rows.Add(nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.mod == "55" ? "NF-e" : "NFC-e",
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.dhEmi.ToShortDateString(),
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Total.ICMSTotal.vNF, path,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome,
                                              string.IsNullOrEmpty(nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ) ? nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CPF : nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.CNPJ,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.xMun,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.UF,
                                              nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.Endereco.CEP);
                    }
                }
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
            {
                if (chkVisualizarPdf.Checked)
                {
                    ACBrNFe.LimparLista();
                    ACBrNFe.CarregarXML(dataGridView.SelectedRows[0].Cells[4].Value.ToString());
                    ACBrNFe.Imprimir(bMostrarPreview: true);
                }
                else
                {
                    var nfe = listaNFeProc.Find(x => x.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF == dataGridView.SelectedRows[0].Cells[0].Value);

                    DetalheXMLNFe detalhe = new DetalheXMLNFe(nfe);
                    detalhe.ShowDialog();
                }
            }
        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                e.Handled = true;
                if (dataGridView.Rows.Count > 0 && dataGridView.SelectedRows.Count > 0)
                {
                    if (chkVisualizarPdf.Checked)
                    {
                        ACBrNFe.LimparLista();
                        ACBrNFe.CarregarXML(dataGridView.SelectedRows[0].Cells[4].Value.ToString());
                        ACBrNFe.Imprimir(bMostrarPreview: true);
                    }
                    else
                    {
                        var nfe = listaNFeProc.Find(x => x.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF == dataGridView.SelectedRows[0].Cells[0].Value);

                        DetalheXMLNFe detalhe = new DetalheXMLNFe(nfe);
                        detalhe.ShowDialog();
                    }

                }
            } 
        }
        private void btnLerFolderXml_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathFolderXml.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void dtaInicio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidarDataInicialFinal())
            {
               dtaInicio.Focus();
            }

        }
        private bool ValidarDataInicialFinal()
        {
            if (dtaInicio.Value > dtaFim.Value)
            {
                MessageBox.Show("A Data final não pode ser menor que a data inicial!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void dtaFim_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidarDataInicialFinal())
            {
                dtaFim.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioTodas.Checked)
            {
                txtCpfCnpj.Clear();
            }
            if ((string.IsNullOrEmpty(txtCpfCnpj.Text)) && (radioEntrada.Checked || radioSaida.Checked))
            {
                MessageBox.Show("Para o tipo entrada ou saida de NFe/NFCe é necessário informar a inscrição.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpfCnpj.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPathFolderXml.Text))
            {
                MessageBox.Show("Não foi informado o caminho para os arquivos XML.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLerFolderXml.Focus();
            }
            else
            {
                BuscarXML(txtPathFolderXml.Text);
            }
        }

        private void BuscarXML(string strPath)
        {
            try
            {
                DirectoryInfo diretorio = new DirectoryInfo(strPath);
                FileInfo[] Arquivos = diretorio.GetFiles("*.xml");

                NFeSerialization serializable = new NFeSerialization();

                dataGridView.Rows.Clear();
                listaNFeProc.Clear();
            foreach (FileInfo fileinfo in Arquivos)
            {
                AtualizarGrid(serializable.GetObjectFromFile<NFeProc>(txtPathFolderXml.Text + "\\" + fileinfo.Name), txtPathFolderXml.Text + "\\" + fileinfo.Name);
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (listaNFeProc.Count == 0)
            {
                MessageBox.Show("Nenhuma XML de NF-e/NFC-e encontrado para o período informado!", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string FormatarCpfOuCnpj(string str)
        {
            if (str.Length == 11)
            {
                return Convert.ToUInt64(str).ToString(@"000\.000\.000\-00");
            }
            else if (str.Length == 14)
            {
                return Convert.ToUInt64(str).ToString(@"00\.000\.000\/0000\-00");
            }
            else
            {
                return "";
            }

        }

        private void TxtCpfCnpj_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            txtCpfCnpj.Text = FormatarCpfOuCnpj(txtCpfCnpj.Text);
        }

        private void radioTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTodas.Checked)
            {
                txtCpfCnpj.Text = "";
            }
        }
    }
}
