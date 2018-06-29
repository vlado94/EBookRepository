using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBookRepository.Models
{
    public class Language : Entity
    {
        public string Name { get; set; }


        public Language() { }
        public Language(string name)
        {
            Name = name;
        }
    }
}