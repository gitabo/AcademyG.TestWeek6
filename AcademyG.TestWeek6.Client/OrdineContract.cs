using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyG.TestWeek6.Client
{
    public class OrdineContract
    {
        public int Id { get; set; }

        public DateTime DataOrdine { get; set; }
 
        public string CodiceOrdine { get; set; }
        
        public string CodiceProdotto { get; set; }
        
        public decimal Importo { get; set; }
        
    }
}
