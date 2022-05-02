using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MVC_Pet_Store.Models
{
    public class Gender
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string GenderName { get; set; }
    }
}