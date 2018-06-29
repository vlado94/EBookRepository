using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBookRepository.Models
{
    public class EBook : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Keywords { get; set; }
        public int PublicationYear { get; set; }
        public string Filename { get; set; }

        public Language Language { get; set; }
        public Category Category { get; set; }

        public EBook() { }

        public EBook(string title, string author, string keywords, int publicationYear, string filename)
        {
            Title = title;
            Author = author;
            Keywords = keywords;
            PublicationYear = publicationYear;
            Filename = filename;
        }
    }
}