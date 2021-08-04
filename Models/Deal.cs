using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post_Deals_Final_Project.Models
{
    //Deal information including the company deal heading and title
    public class Deal
    {
        public int Id { get; set; } // deals id 

        public string Heading { get; set; } // heading

        public string DealInfo { get; set; } // infomation regarding deal


        public int CompanyId { get; set; } // forign key 

        public Company Company { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        



    }
}
