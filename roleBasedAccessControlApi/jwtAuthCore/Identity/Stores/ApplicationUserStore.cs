using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using roleBasedAccessCcontrolApi.jwtAuthCore.DbContext;
using roleBasedAccessControlApi.jwtAuthCore.Entities;

namespace roleBasedAccessCcontrolApi.jwtAuthCore.Identity.Stores
{
    public class ApplicationUserStore(ApplicationDbContext context, IdentityErrorDescriber? describer = null)
        : UserStore<
            ApplicationUser,
            ApplicationRole,
            ApplicationDbContext,
            Guid,
            IdentityUserClaim<Guid>,
            IdentityUserRole<Guid>,
            IdentityUserLogin<Guid>,
            IdentityUserToken<Guid>,
            IdentityRoleClaim<Guid>
            >(context, describer)
    {
    }
}
