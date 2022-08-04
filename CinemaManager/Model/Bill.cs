using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Model
{
    internal class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; } 
        public double Total { get; set; }
        public DateTime Day { get; set; }
        public ICollection<BillDetail> billDetails { get; set; }

        public Customer Customer { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; } 
    }
}
