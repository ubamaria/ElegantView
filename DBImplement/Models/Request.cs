using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DBImplement.Models
{
    public class Request
    {
        public int Id { get; set; }
        [Required]
        public int ProductionId { get; set; }
        [Required]
        public string ProductionName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Customer { get; set; }
        [Required]
        public string Executor { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Production Productions { get; set; }
    }
}
