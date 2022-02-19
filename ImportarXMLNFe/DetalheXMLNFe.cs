using ImportarXMLNFe.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportarXMLNFe
{
    public partial class DetalheXMLNFe : Form
    {
        public DetalheXMLNFe(NFeProc nfe) 
        { 
           InitializeComponent();
            
            /* Populando tab Identificação */
            txtNaturezaOperacao.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Destinatario.xNome;
            txtNumero.Text = nfe.NotaFiscalEletronica.InformacoesNFe.Identificacao.nNF;
            //txtModelo.Text = i.mod;
            //txtSerie.Text = i.serie.ToString();
            //txtDataEmissao.Text = i.dhEmi.ToShortDateString();

            ///* Populando tab Emitente */
            //txtRazaoSocial.Text = em.xNome;
            //txtNomeFantasia.Text = em.xFant;
            //txtCpfCnpjEmitente.Text = em.CNPJ;
            //txtInscricaoEstadual.Text = em.IE;

            //txtLogradouroEmitente.Text = enEmi.xLgr;
            //txtNroEmitente.Text = enEmi.nro;
            //txtMunicipioEmitente.Text = enEmi.xMun;
            //txtUFEmitente.Text = enEmi.UF;

            ///* Populando tab Destinatário */
            //txtDestNomeFantasia.Text = d.xNome;
            //txtDestCpfCnpj.Text = d.CNPJ;
            //txtDestEmail.Text = d.email;

            //txtDestLogradouro.Text = enDes.xLgr;
            //txtDestNumero.Text = enDes.nro;
            //txtDestMunicipio.Text = enDes.xMun;
            //txtDestUF.Text = enDes.UF;
            //txtDestCEP.Text = enDes.CEP;
            //txtDestBairro.Text = enDes.xBairro;

            foreach (var d in nfe.NotaFiscalEletronica.InformacoesNFe.Detalhe)
            {
               // tbItens.Text = d.Produto.vUnCom.ToString();
            }
        }
    }
}
