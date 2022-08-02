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
    internal class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<Permission> Permissions { get; set; }
    }
}
