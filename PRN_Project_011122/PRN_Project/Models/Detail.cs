using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace PRN_Project.Models
{
    public partial class Detail
    {
        [Key]
        public int? BillId { get; set; }
        public string Price { get; set; }
        public int? Amount { get; set; }
        public int? IdProduct { get; set; }
        public string ProductName { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
