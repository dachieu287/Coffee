using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Tên:")]
        public string Name { get; set; }

        [Display(Name = "Loại:")]
        public string Genre { get; set; }

        [Display(Name = "Chú thích:")]
        public string Note { get; set; }

        [Display(Name = "Giá:")]
        public int Price { get; set; }

        [Display(Name = "Hình ảnh:")]
        public string Image { get; set; }
    }
}
