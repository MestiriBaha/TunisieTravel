using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Review
    {
        public Guid ReviewID { get; set;  }
        public string Comment { get; set; }  
        public double ResponseStars { get; set; }
        public double ConsultationStars { get; set; }
        public double KindnessStars { get; set; }


    }
}
