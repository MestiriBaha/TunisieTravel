using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Advertisement
    {
        public string Location { get; set;  }
        public int Days { get; set;  }

        public double Price { get; set; }
        public double Discount { get; set; }    
        public DateTime DepartureDate { get; set;  }
        
    }
}
