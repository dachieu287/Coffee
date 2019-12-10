using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class CheckoutView
    {
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Mã khuyến mãi")]
        public string Code { get; set; }

        [Display(Name = "Ghi chú")]
        public string Note { get; set; }

        public List<Item> Items { get; set; }

        [Display(Name = "Tổng giá món")]
        public int Price { get; set; }

        [Display(Name = "Phí vẫn chuyển")]
        public int Ship { get; set; }

        [Display(Name = "Giảm giá")]
        public int Discount { get; set; }
        public int PaymentMethod { get; set; }
    }
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
