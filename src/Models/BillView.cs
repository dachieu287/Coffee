using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class BillView
    {
        [Display(Name = "Mã đơn hàng")]
        public int Id { get; set; }

        [Display(Name = "Tên tài khoản")]
        public string User { get; set; }

        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Mã khuyễn mãi")]
        public string Code { get; set; }

        [Display(Name = "Ghi chú")]
        public string Note { get; set; }

        [Display(Name = "Danh sách món:")]
        public List<BillItem> Items { get; set; }

        [Display(Name = "Phí giao hàng")]
        public int Ship { get; set; }

        [Display(Name = "Giảm giá")]
        public int Discount { get; set; }

        [Display(Name = "Tổng tiền")]
        public int Total { get; set; }

        [Display(Name = "Phương thức thanh toán")]
        public int PaymentMethod { get; set; }

        [Display(Name = "Thời gian đặt")]
        public string Time { get; set; }

        [Display(Name = "Tình trạng")]
        public int Status { get; set; }
    }
    public class BillItem
    {
        [Display(Name = "Tên món")]
        public string Name { get; set; }

        [Display(Name = "Số lượng")]
        public int Quantity { get; set; }

        [Display(Name = "Giá")]
        public int Price { get; set; }
    }
}
