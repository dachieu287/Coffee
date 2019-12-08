using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Models
{
    public class Account
    {
   
        [Display(Name = "Tên tài khoản")]
       
        public string Id { get; set; }

       
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Quyền")]
        public int Privilege { get; set; }

        [Display(Name = "Tên")]
        public string Name { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
    }
}
