using Hff.MembershipServer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Hff.MembershipServer.Service.Concrete.Data.EntityFrameworkCore
{
    public class MembershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3VB3SSC\\SQLEXPRESS01;Database=MembershipServer;Integrated Security=true");

        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
