﻿namespace DatabaseConnection.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Group.Name}";
        }
    }
}
