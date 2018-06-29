using EBookRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBookRepository.Dto
{
    public class AllCategories
    {
        public List<Category> Categories { get; set; }
        public string Role { get; set; }
    }
}