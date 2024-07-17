using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Employee name is required.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Employee name must be between 3 and 100 characters.")]
    public string EmployeeName { get; set; }

    [Required(ErrorMessage = "Employee code is required.")]
    [StringLength(10, MinimumLength = 3, ErrorMessage = "Employee code must be between 3 and 10 characters.")]
    public string EmployeeCode { get; set; }

    public List<SalaryDetail> SalaryDetails { get; set; }
}
