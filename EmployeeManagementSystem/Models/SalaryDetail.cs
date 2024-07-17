using System.ComponentModel.DataAnnotations;

public class SalaryDetail
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Year is required.")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Amount is required.")]
    [Range(0, double.MaxValue, ErrorMessage = "Amount must be a positive number.")]
    public decimal Amount { get; set; }
}
