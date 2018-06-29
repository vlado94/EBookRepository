using EBookRepository.Dto;
using EBookRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static EBookRepository.Constants.Constants;

namespace EBookRepository.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult SetDatabase()
        {
            using (var ef = new EfContext())
            {
                User u1 = new User("Vladimir", "Stanojevic", "Vlado", "111", Roles.Admin);
                ef.Users.Add(u1);
                User u2 = new User("Olja", "Miljatovic", "Olja", "111", Roles.Subscriber);
                ef.Users.Add(u2);
                User u3 = new User("Tomo", "Stanic", "Tomo", "111", Roles.Admin);
                ef.Users.Add(u3);
                User u4 = new User("Profa", "Profa", "Profa", "111", Roles.Subscriber);
                ef.Users.Add(u4);

                Language l1 = new Language("Srpski");
                ef.Languages.Add(l1);
                Language l2 = new Language("Engleski");
                ef.Languages.Add(l2);
                Language l3 = new Language("Spanski");
                ef.Languages.Add(l3);

                Category c1 = new Category("Category1");
                ef.Categories.Add(c1);
                Category c2 = new Category("Category2");
                ef.Categories.Add(c2);
                Category c3 = new Category("Category3");
                ef.Categories.Add(c3);


                EBook b1 = new EBook("Book1","Author1","sport,tenis,novak,pariz",2016,"Tenis");
                b1.Language = l1;
                b1.Category = c1;
                ef.EBooks.Add(b1);
                EBook b2 = new EBook("Book2", "Author2", "vreme,leto,vrucina", 2018, "Prognoza");
                b2.Language = l2;
                b2.Category = c2;
                ef.EBooks.Add(b2);
                EBook b3 = new EBook("Book3", "Author3", "geografija,francuska,pariz,leto", 2015, "Pariz");
                b3.Language = l3;
                b3.Category = c3;
                ef.EBooks.Add(b3);

                ef.SaveChanges();
                
            }
            return View("Contact");
        }

        [AllowAnonymous]
        public ActionResult GetCategories()
        {
            List<Category> categories = new List<Category>();
            using (var ef = new EfContext())
            {
                categories = ef.Categories.ToList();
            }
            AllCategories retVal = new AllCategories
            {
                Categories = categories,
                Role = ""
            };
            return Json(retVal, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public ActionResult GetBooksForCategory(int categoryID)
        {
            List<EBook> eBooks = new List<EBook>();
            using (var ef = new EfContext())
            {
                eBooks = ef.EBooks.ToList();
            }
            BooksForCategory retVal = new BooksForCategory
            {
                Books = eBooks,
                Role = ""
            };
            return Json(retVal, JsonRequestBehavior.AllowGet);
        }


    }
}