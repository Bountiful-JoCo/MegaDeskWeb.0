using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb._0.Models
{
    public class DeskQuote
    {
        public int DeskQuoteID { get; set; }
        public int DeskID { get; set; }
        public DateTime QuoteDate { get; set; }



        //Navigation Properties
        public Desk Desk { get; set; }


    }
}
