using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mindly.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
