using Hff.MembershipServer.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace Hff.MembershipServer.Entities.Concrete
{
    public class AppUser:IdentityUser,IEntity
    {
    }
}
