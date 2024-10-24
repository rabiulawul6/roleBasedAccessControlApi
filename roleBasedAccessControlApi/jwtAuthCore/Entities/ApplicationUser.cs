using Microsoft.AspNetCore.Identity;

namespace roleBasedAccessControlApi.jwtAuthCore.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
    }
}
