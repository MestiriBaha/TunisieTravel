namespace Domain
{
    public class TravelAgency
    {
        public Guid ID { get; set; }
        public String CompanyName { get; set; }
        public List<Address> AgencyAddress { get; set; } = new List<Address>(); 
        public String SupportNumber { get; set; }   
        public String CompanyEmail { get; set;  }
        public String CustomerServiceRepresenter { get; set; } 
        


    }
}