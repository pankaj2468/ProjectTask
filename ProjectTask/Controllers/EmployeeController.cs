using Microsoft.AspNetCore.Mvc;
using ProjectTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using ProjectTask.Models.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectTask.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;


        public EmployeeController(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public IActionResult Index()
        {
            var cat = context.Employees.ToList();
            return View(cat);
        }

        [HttpPost]
        public IActionResult Index(DateTime fromdate, DateTime todate)
        {

            ViewBag.fromdate = fromdate.ToString("yyyy-MM-dd");
            ViewBag.todate = todate.ToString("yyyy-MM-dd");
            var cat = context.Employees.Where(s => s.DOJ >= fromdate && s.DOJ <= todate.AddDays(1)).ToList();
            return View(cat);
            
        }
           
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(obj);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = context.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Update(obj);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = context.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            {
                var obj = context.Employees.Find(id);

                if (obj == null)
                {

                    return NotFound();
                }
                context.Employees.Remove(obj);
                context.SaveChanges();
                return RedirectToAction("Index");
               
            }


        }

    }
}
// var cat = context.Employees.Where(s => s.DOJ.Date <= fromdate.Date && s.DOJ.Date >= todate.Date).ToList();
//return View(cat);
//var cat = context.Employees.Where(s => s.DOJ).Where(t => t.DOJ >= fromdate && t.DOJ <= todate).ToList();
//return View(cat);
//var cat = context.Employees.Where(x => x.fromdate).Where(x => x.todate).Where(x => x.CreatedOn >= FromDate).Where(x => x.CreatedOn <= ToDate).Where(x => x.IsActive == true).ToList();
//var cat = (from s in context.Employees where (s.DOJ <= fromdate) && (s.DOJ >= todate) select s).ToList();     
//return View(cat);