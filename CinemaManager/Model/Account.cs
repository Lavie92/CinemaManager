using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManager.Model;

namespace CinemaManager.Model
{
    internal class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Permission> Permissions { get; set; }

    }
}
