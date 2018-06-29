using EBookRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBookRepository.Dto
{
    public class BooksForCategory
    {
        public List<EBook> Books { get; set; }
        public string Role { get; set; }
    }
}