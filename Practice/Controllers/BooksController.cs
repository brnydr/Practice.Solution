using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Practice.Controllers
{
  public class BooksController : Controller
  {
    private readonly PracticeContext _db;

    public BooksController(PracticeContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Books";
      return View(_db.Books.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add a book";
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
