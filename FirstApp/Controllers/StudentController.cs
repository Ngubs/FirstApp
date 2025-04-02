using System.Security.Cryptography.Xml;
using FirstApp.Data;
using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _db;

        public StudentController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = _db.StudentTable.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _db.StudentTable.Add(student);
            _db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if ((id == 0) || (id == null))
            {
                return NotFound();
            }

            Student? studentFromDb = _db.StudentTable.Find(id);
            //Student? studentFromDb1 = _db.StudentTable.
            //                            FirstOrDefault(s => s.Id == id);
            //Student? studentFromDb2 = _db.StudentTable.
            //                            Where(s => s.Id == id).
            //                            FirstOrDefault();
            return View(studentFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _db.StudentTable.Update(student);
            _db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if ((id == 0) || (id == null))
            {
                return NotFound();
            }

            Student? studentFromDb = _db.StudentTable.Find(id);
            //Student? studentFromDb1 = _db.StudentTable.
            //                            FirstOrDefault(s => s.Id == id);
            //Student? studentFromDb2 = _db.StudentTable.
            //                            Where(s => s.Id == id).
            //                            FirstOrDefault();
            return View(studentFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Student? studentFromDb = _db.StudentTable.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }

            _db.StudentTable.Remove(studentFromDb);
            _db.SaveChanges();
            return RedirectToAction("Index", "Student");
        }
    }
}
