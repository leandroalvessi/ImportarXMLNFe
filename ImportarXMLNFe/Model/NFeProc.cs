﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImportarXMLNFe.Model
{
    [XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NFeProc
    {
        [XmlAttribute("versao")]
        public string versao { get; set; }

        [XmlElement("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public NFe NotaFiscalEletronica
        {
            get; set;
        }
    }
}

