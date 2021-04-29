using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBImplement.Models
{
    public class Production
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Kind { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public string Color { get; set; }
        public virtual List<Request> Requests { get; set; }
    }
}
