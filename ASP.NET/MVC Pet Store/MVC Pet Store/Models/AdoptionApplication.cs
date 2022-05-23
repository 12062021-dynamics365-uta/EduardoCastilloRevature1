using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Pet_Store.Models
{
    public class AdoptionApplication
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public Pet Pet { get; set; }
    }
}