using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pan2api.Models
{
    public class UserModel
    {
        [Key]
        public string FacebookId { get; set; }

        [Required]
        public string Color { get; set; }
        
    }
}
