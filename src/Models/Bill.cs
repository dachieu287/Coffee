using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class Bill
    {
        [Display(Name = "Mã đơn hàng")]
        public int Id { get; set; }

        [Display(Name = "Tên tài khoản")]
        public string User { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public string Items { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public int Ship { get; set; }
        public int Discount { get; set; }

        [Display(Name = "Tổng tiền")]
        public int Total { get; set; }
        public int PaymentMethod { get; set; }

        [Display(Name = "Thời gian đặt")]
        public string Time { get; set; }

        [Display(Name = "Tình trạng")]
        public int Status { get; set; }
        
    }
}
