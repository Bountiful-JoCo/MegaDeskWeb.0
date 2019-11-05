using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb._0.Models
{
    public class RushOrder
    {
        public int RushOrderID { get; set; }
        public string RushOrderCode { get; set; }
        public double RushOrderPrice { get; set; }
        

        //Navigation Properties
        public Desk Desk { get; set; }

    }
}
