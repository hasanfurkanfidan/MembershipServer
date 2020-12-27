using Hff.MembershipServer.Entities.Concrete;
using Hff.MembershipServer.Service.Concrete.Data.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hff.MembershipServer.Service.Concrete.Data.EntityFrameworkCore
{
    public class MembershipContext : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-3VB3SSC\\SQLEXPRESS01;Database=FnfWorkshopMembershipIdentityServer;Integrated Security=true");

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMap());
        }
        


    }
}
