using System.ComponentModel.DataAnnotations;

namespace roleBasedAccessControlApi.jwtAuthCore.Dtos
{
    
        public class UpdatePermissionDto
        {
            [Required(ErrorMessage = "UserName is required")]
            public string? UserName { get; set; } 
      
        }
    
}
