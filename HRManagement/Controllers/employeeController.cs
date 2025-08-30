using HRManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Controllers
{
    public class employeeController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var values = c.employees
                  .Include(e => e.dpt)   // departman bilgisini de yükle
                  .ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            List<SelectListItem> values = (from x in c.departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.department_name,
                                               Value = x.department_id.ToString()
                                           }).ToList();
            ViewBag.dgr = values;
            return View();
        }

        public IActionResult AddEmployee(Employee e)
        {
            var emp = c.departments.Where(x=>x.department_id == e.dpt.department_id).FirstOrDefault();
            e.dpt = emp;
            c.employees.Add(e);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
