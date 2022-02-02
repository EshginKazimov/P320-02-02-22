using DatabaseConnection.Models;
using System.Collections.Generic;

namespace DatabaseConnection.ViewModels
{
    public class HomeViewModel
    {
        public List<Student> Students { get; set; }
        
        public List<Teacher> Teachers { get; set; }
    }
}
