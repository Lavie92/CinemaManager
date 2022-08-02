using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManager.Model;


namespace CinemaManager.Model
{
    internal class CinemaContext : DbContext
    {
        public CinemaContext() : base("name = CinemaContext") { }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
    }
}
