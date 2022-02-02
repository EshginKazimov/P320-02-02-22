using DatabaseConnection.DataAccessLayer;
using DatabaseConnection.Models;
using DatabaseConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //var p318 = new Group { Id = 1, Name = "P318" };
            //var p320 = new Group { Id = 2, Name = "P320" };

            //var students = new List<Student>
            //{
            //    new Student{ Id = 1, Name = "Akif", Surname = "Talibov", Age = 35, Group = p318},
            //    new Student{ Id = 2, Name = "Elnur", Surname = "Meherremli", Age = 28, Group = p320},
            //    new Student{ Id = 3, Name = "Emil", Surname = "Karimov", Age = 25, Group = p318},
            //};

            var students = _dbContext.Students.Include(x => x.Group).ToList();

            //var teachers = new List<Teacher>
            //{
            //    new Teacher{ Id = 1, Name = "Elchin", Surname = "Aghayev"},
            //    new Teacher{ Id = 2, Name = "Mehemmed", Surname = "Mikayilov"},
            //};

            var teachers = _dbContext.Teachers.ToList();

            return View(new HomeViewModel
            {
                Students = students, 
                Teachers = teachers
            });
        }

        public IActionResult Detail()
        {
            var p318 = new Group { Id = 1, Name = "P318" };

            return View(new Student 
            { 
                Id = 1, 
                Name = "Akif", 
                Surname = "Talibov", 
                //Age = 35, 
                Group = p318 
            });
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
