using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using roleBasedAccessCcontrolApi.jwtAuthCore.DbContext;
using roleBasedAccessControlApi.jwtAuthCore.Entities;

namespace roleBasedAccessControlApi.jwtAuthCore.Identity.Stores
{
    public class ApplicationRoleStore(ApplicationDbContext context, IdentityErrorDescriber? describer = null)
        : RoleStore<ApplicationRole, ApplicationDbContext, Guid>(context, describer)
    {
    }
}
