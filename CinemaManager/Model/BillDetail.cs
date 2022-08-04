using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Model
{
    internal class BillDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillDetailId { get; set; }
        public double Price { get; set; }
        public int SeatNumber { get; set; }
        public Bill Bill { get; set; }
        [ForeignKey("Bill")]
        public int BillId { get; set; }
    }
}
