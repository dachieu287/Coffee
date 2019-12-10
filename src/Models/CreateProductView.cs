using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Coffee.Models
{
    public class CreateProductView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Genre { get; set; }

        
        public string Note { get; set; }

        
        public int Price { get; set; }

        
        public IFormFile Image { get; set; }
    }
}
