using Microsoft.AspNetCore.Mvc;
using PocWebAppRazor.Models;

namespace PocWebAppRazor.Controllers;

public class DepartmentsController : Controller
{
    public IActionResult Index()
    {
        List<Department> list = new List<Department>();
        list.Add(new Department {Id = 1, Name = "Electronics"});
        list.Add(new Department {Id = 2, Name = "Fashion"});

        return View(list);
    }

    public IActionResult Create()
    {
        return View();
    }
    
    public IActionResult Edit()
    {
        return Redirect("Create");
    }
    
    public IActionResult Details()
    {
        return View();
    }
    
    public IActionResult Delete()
    {
        return RedirectToAction("Index");
    }
}