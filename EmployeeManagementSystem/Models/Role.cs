using System.ComponentModel.DataAnnotations;

public class Role
{
    public int RoleId { get; set; }
    [Required]
    public string RoleName { get; set; } 
}
