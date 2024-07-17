using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.Include(e => e.SalaryDetails).ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

    [HttpGet]
    public IActionResult FilterIndex(string yearFilter, string nameFilter)
    {
        var employees = _context.Employees.Include(e => e.SalaryDetails).AsQueryable();

        if (!string.IsNullOrEmpty(yearFilter))
        {
            employees = employees.Where(e => e.SalaryDetails.Any(sd => sd.Year.ToString() == yearFilter));
        }

        if (!string.IsNullOrEmpty(nameFilter))
        {
            employees = employees.Where(e => e.EmployeeName.Contains(nameFilter));
        }

        var employeeList = employees.ToList();
            return View("Index", employeeList);
    }
    }
}
