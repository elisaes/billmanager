using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillTracker.Models
{
    public class BillModels
    {
        [Key]
        public int BillId { get; set; }
        public string BillName { get; set; }
        public string BillCompany { get; set; }
        public string BillDate { get; set; }
        public int BillPrice { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}