using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }

        public Book(string name, string author, int year, int id)
        {
            Name = name;
            Author = author;
            Year = year;
            Id = id;
        }
    }
}
