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
                    foreach (FileInfo fileinfo in Arquivos)
                    {
                        
                        var nfe = serializable.GetObjectFromFile<NFeProc>(txtpathFolderXml.Text + "\\" + fileinfo.Name);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Falha no processo de leitura do arquivo xml da Nota Fiscal.", "Aviso - Leitura do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
