using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using roleBasedAccessControlApi.jwtAuthCore.Entities;
using roleBasedAccessControlApi.Models;

namespace roleBasedAccessCcontrolApi.jwtAuthCore.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
