using Microsoft.AspNetCore.Mvc;
using HRManagement.Models;

namespace HRManagement.Controllers
{
    public class departmentController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.departments.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            context.departments.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDepartment(int id)
        {
            var delete_dp = context.departments.Find(id);
            context.departments.Remove(delete_dp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FindDepartment(int id)
        {
            var find_dp = context.departments.Find(id);
            return View("FindDepartment",find_dp);
        }

        public IActionResult UpdateDepartment(Department d)
        {
            var update_dp = context.departments.Find(d.department_id);
            update_dp.department_name = d.department_name;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DepartmentDetails(int id) 
        {
            var val = context.employees
                     .Where(x => x.dpt.department_id == id) // departman id’ye göre filtrele
                     .ToList();
            var dep_name = context.departments.Where(x=>x.department_id == id).Select(y=>y.department_name).FirstOrDefault();
            ViewBag.departmentName = dep_name;
            return View(val);
        }

    }

}
