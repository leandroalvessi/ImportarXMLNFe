﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ImportarXMLNFe.Model
{
    public class Total
    {
        [XmlElement("ICMSTot")]
        public ICMSTotal ICMSTotal { get; set; }
    }
}
