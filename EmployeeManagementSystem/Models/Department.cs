using System.ComponentModel.DataAnnotations;

public class Department
{
    public int DepartmentId { get; set; }
    [Required]
    public string DepartmentName { get; set; } 
}
