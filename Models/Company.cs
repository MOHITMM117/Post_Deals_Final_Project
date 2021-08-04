using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Post_Deals_Final_Project.Models
{
    //Deal company details
    public class Company
    {
        public int Id { get; set; } // company id 

        public string CompanyName { get; set; } // comany name 

        public string Email { get; set; } // email
        
        public string ContactNumber { get; set; } // contact number
    }
}
