using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void Read(Book book)
        {

        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BookText { get; set; }
        public DateTime LaunchDate { get; set; }

        public Book(string title)
        {
            Title = title;
        }
    }

    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
    }


}
