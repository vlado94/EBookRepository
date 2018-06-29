using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBookRepository.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }

        public Category() { }
        public Category(string name)
        {
            Name = name;
        }
    }
}