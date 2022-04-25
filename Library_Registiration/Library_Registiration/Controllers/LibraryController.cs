using Library_Registiration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library_Registiration.Controllers
{
    public class LibraryController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List_Book()
        {
            Context c = new Context();
            var books = c.books.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult Add_Book()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_Book(Book p)
        {
            Context c = new Context();
            c.books.Add(p);
            if (ModelState.IsValid)
            {
                var result = c.SaveChanges();
                return RedirectToAction("List_Book", "Library");

            }
            else
            {
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Edit_Book(int id)
        {
            Context c = new Context();
            var res = c.books.Find(id);
            //var book_id = c.books.FirstOrDefault(x => x.Book_id == id);
            return View(res);
        }

        [HttpPost]
        public IActionResult Edit_Book(Book p)
        {
            Context c = new Context();
            c.books.Update(p);
            if(ModelState.IsValid)
            {
                c.SaveChanges();
                return View();
            }
            else
            {
                return RedirectToAction("List_Book", "Library");
            }
           
        }
        public IActionResult Delete_Book(int id)
        {
            Context c = new Context();
            var sil = c.books.Find(id);
            c.books.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("List_Book", "Library");
        }
    }
}
