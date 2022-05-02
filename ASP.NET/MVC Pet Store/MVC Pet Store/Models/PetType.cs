using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Pet_Store.Models
{
    public class PetType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Type { get; set; }
    }
}