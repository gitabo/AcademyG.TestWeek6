using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AcademyG.TestWeek6.Core.Model
{   
    [DataContract]
    public class Ordine
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime DataOrdine { get; set; }
        [DataMember]
        public string CodiceOrdine { get; set; }
        [DataMember]
        public string CodiceProdotto { get; set; }
        [DataMember]
        public decimal Importo { get; set; }
        [DataMember]
        public Cliente Cliente { get; set; }
    }
}
