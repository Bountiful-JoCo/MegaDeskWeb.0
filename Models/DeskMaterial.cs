using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb._0.Models
{
    public class DeskMaterial
    {
        public int DeskMaterialID { get; set; }
        public string Material { get; set; }
        public double MaterialPrice { get; set; }


        //Navigation Properties
        public Desk Desk { get; set; }


    }
}
