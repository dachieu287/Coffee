using System.ComponentModel.DataAnnotations;

namespace Coffee.Models
{
    public class ChangePasswordView
    {
       
        [Display(Name = "Mật khẩu cũ")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [MinLength(4, ErrorMessage = "Độ dài phải ít nhất 4 kí tự")]
        [Display(Name = "Mật khẩu mới")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Nhập lại mật khẩu mới")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; }
    }
}
