
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Models
{
    public class CreateAccountView
    {
        [Required(ErrorMessage = "Không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Độ dài tối thiểu 3 kí tự")]
        [Display(Name = "Tên tài khoản")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Độ dài tối thiểu 3 kí tự")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string Repassword { get; set; }


        [Required(ErrorMessage = "Không được bỏ trống")]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống")]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
    }
}
