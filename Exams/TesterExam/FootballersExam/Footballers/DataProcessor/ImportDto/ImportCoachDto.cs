﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto
{
    [XmlType("Coach")]
    public class ImportCoachDto
    {
        [XmlElement("Name")]
        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string Name { get; set; }

        [XmlElement("Nationality")]
        [Required]
        public string Nationality { get; set; }

        [XmlArray("Footballers")]
        public List<ImportFootballerDto> Footballers { get; set; }
    }
}
