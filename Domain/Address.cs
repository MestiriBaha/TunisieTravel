using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Address
    {
        public string Country
        {
            get { return "Tunisia" ; }
        }

        public  string city { get; set; } 
        public string address { get; set; } 
        public string zipcode { get; set; } 

    }
}
