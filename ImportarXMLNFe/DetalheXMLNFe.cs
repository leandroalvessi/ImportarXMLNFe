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
        public DetalheXMLNFe(Identificacao i) 
        { 
           InitializeComponent();
            
            /* Populando tab Identificação */
            txtNaturezaOperacao.Text = i.natOp;
            txtNumero.Text = i.nNF;
            txtModelo.Text = i.mod;
            txtSerie.Text = i.serie.ToString();
            txtDataEmissao.Text = i.dhEmi.ToShortDateString();
        }
    }
}
