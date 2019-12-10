using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class BookATable
    {
        [Display(Name = "Mã")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        [Display(Name = "Họ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        [Display(Name = "Tên")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        [Display(Name = "Ngày")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        [Display(Name = "Giờ")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Không được trống")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Lời nhắn")]
        public string Message { get; set; }
    }
}
