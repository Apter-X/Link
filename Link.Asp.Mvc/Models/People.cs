using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Link.Asp.Mvc.Models
{
    public class People
    {

        public int Id { get; set; }

        [Required (ErrorMessage = "Enter a valid name!")]
        public string FirstName{ get; set; }

        [Required(ErrorMessage = "Enter a valid name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter a valid address!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter a valid postal code!")]
        public string PostalCode { get; set; }
    }
}
