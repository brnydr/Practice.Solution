using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Practice.Controllers
{
  public class AuthorsController : Controller
  {
    private readonly PracticeContext _db;

    public AuthorsController(PracticeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Authors";
      return View(_db.Authors.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add an Author";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Author author)
    {
      _db.Authors.Add(author);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

  }
}