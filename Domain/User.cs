using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public Guid ID { get; set;  }
        public userType UserType { get; set; }  
        public string userName { get; set;  } 
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateOnly Birthday { get; set; }   
        public string Email { get; set;  }
        public string TelephoneNumber { get; set; } 
        public String Sex { get; set; }  
        public String Status { get; set; }  
        public Address UserAddress { get; set; }    
    }
}
