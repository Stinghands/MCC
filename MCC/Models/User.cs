using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCC.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
