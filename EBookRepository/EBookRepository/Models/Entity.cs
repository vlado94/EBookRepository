using System;
using System.ComponentModel.DataAnnotations;

namespace EBookRepository.Models
{
    public abstract class Entity
    {
        public int ID { get; set; }

        [Required]
        public Boolean IsDeleted { get; set; }
    }
}