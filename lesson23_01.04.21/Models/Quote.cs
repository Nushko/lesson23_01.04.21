using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lesson23_01._04._21.Models
{
    public class Quote
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public string Author { get; set; }

        [Required]
        public DateTime InsertDate { get; set; }

    }
}
