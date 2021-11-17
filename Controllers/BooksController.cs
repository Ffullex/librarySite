using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;

namespace WebAppWithBootsTRAP.Controllers
{
    public class BooksController : Controller
    {
        private readonly BooksCatalog _booksCatalog;
        
        public BooksController()
        {
            _booksCatalog = new BooksCatalog();

            _booksCatalog.AddBook(new Book
            {
                Title = "Headless",
                Author = "Head User",
                Genre = "reality",
                InventoryNumber = Guid.NewGuid().ToString(),
                ISBN = "023874074932",
                YearOfEdition = "1488",
            });

            _booksCatalog.AddBook(new Book
            {
                Title = "Headless",
                Author = "Head User",
                Genre = "reality",
                InventoryNumber = Guid.NewGuid().ToString(),
                ISBN = "023874074932",
                YearOfEdition = "1488",
            });
        }
        public IActionResult Index()
        {
            var books = _booksCatalog.GetAll();
            return View(books);
        }
    }
}
