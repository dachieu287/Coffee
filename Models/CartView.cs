using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class CartView
    {
        public int Id { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Note { get; set; }

        [Display(Name = "Đơn giá")]
        public int Price { get; set; }

        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Thành tiền")]
        public int Total { get; set; }
    }
}
