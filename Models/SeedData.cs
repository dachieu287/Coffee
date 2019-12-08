using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Coffee.Data;
using System;
using System.Linq;
using Coffee.Models;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CoffeeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CoffeeContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                   new Product()
                   {
                       Name = "Espresso",
                       Note = "Trong tiếng Ý, Espresso nghĩa là cà phê có thể được phục vụ cho khách hàng ngay lập tức.",
                       Genre = "Coffee",
                       Price = 20,
                       Image = "ca-phe-espresso.jpg"
                   },
                    new Product()
                    {
                        Name = "Cappuccino",
                        Note = "Mỗi người có cách pha khác nhau, khác về tâm hồn, khác cả về nghệ thuật.",
                        Genre = "Coffee",
                        Price = 40,
                        Image = "ca-phe-capuchino.jpg"
                    },
                    new Product()
                    {
                        Name = "Macchiato",
                        Note = "Macchiato trong tiếng Ý có nghĩa là lốm đốm.",
                        Genre = "Coffee",
                        Price = 40,
                        Image = "ca-phe-macchiato.jpg"
                    },
                    new Product()
                    {
                        Name = "Latte",
                        Note = "Cà phê Latte trong tiếng Ý có nghĩa là cà phê sữa.",
                        Genre = "Coffee",
                        Price = 40,
                        Image = "ca-phe-latte.jpg"
                    },
                    new Product()
                    {
                        Name = "Trà sữa trân châu trắng",
                        Note = "Nếu trân châu đen đã quá phổ biến và quen thuộc với nhiều người thì trân châu trắng là một loại topping khá mới lạ.",
                        Genre = "MilkTea",
                        Price = 50,
                        Image = "tra-sua-tran-chau-trang.jpg"
                    },
                    new Product()
                    {
                        Name = "Trà sữa Oreo Cake Cream",
                        Note = "Những miếng bánh Oreo thơm ngon, hấp dẫn được nghiền nhỏ và rắc vụn lên phía trên lớp kem.",
                        Genre = "MilkTea",
                        Price = 50,
                        Image = "tra-sua-oreo-cake-cream.jpg"
                    },
                    new Product()
                    {
                        Name = "Trà sữa trân châu đường đen",
                        Note = "Cốc trà với phần trà sữa trắng hòa quyện khéo léo cùng phần đường đen, trân châu đen bên dưới.",
                        Genre = "MilkTea",
                        Price = 60,
                        Image = "tra-sua-tran-chau-duong-den.jpg"
                    },
                    new Product()
                    {
                        Name = "Trà xoài kem cheese",
                        Note = "Vẻ bề ngoài với màu vàng đậm bắt mắt, kết hợp cùng lớp kem cheese trắng hấp dẫn phía trên.",
                        Genre = "MilkTea",
                        Price = 40,
                        Image = "tra-xoai-kem-cheese.jpg"
                    },
                    new Product()
                    {
                        Name = "Sinh tố cam tươi",
                        Note = "Một ly sinh tố cam tươi sau bữa sáng sẽ giúp bạn cảm thấy khỏe khoắn, tràn đầy năng lượng, sẵn sàng cho một ngày làm việc.",
                        Genre = "SinhTo",
                        Price = 50,
                        Image = "sinh-to-cam.jpg"
                    },
                    new Product()
                    {
                        Name = "Sinh tố bí đỏ",
                        Note = "Ly sinh tố bí đỏ thơm ngon, bổ dưỡng",
                        Genre = "SinhTo",
                        Price = 50,
                        Image = "sinh-to-bi-do.jpg"
                    },
                    new Product()
                    {
                        Name = "Sinh tố bơ",
                        Note = "Trong quả bơ có chứa nhiều loại vitamin (A, E,..), kali, canxi, chất xơ… rất tốt cho sức khỏe, phòng ngừa nhiều loại bệnh.",
                        Genre = "SinhTo",
                        Price = 60,
                        Image = "sinh-to-bo.jpg"
                    },
                    new Product()
                    {
                        Name = "Sinh tố chuối mật ong",
                        Note = "Hương vị thơm mát của chuối hòa quyện cùng vị ngọt mật ong sẽ làm cho bạn không thể chối từ loại thức uống này.",
                        Genre = "SinhTo",
                        Price = 40,
                        Image = "sinh-to-chuoi.jpg"
                    },
                    new Product()
                    {
                        Name = "Soda mix",
                        Note = "Toàn bộ nguyên liệu, hương vị cho đến màu sắc đều từ các loại trái cây, hoa quả.",
                        Genre = "Soda",
                        Price = 50,
                        Image = "so-da-mix.jpg"
                    },
                    new Product()
                    {
                        Name = "Mojito",
                        Note = " Mojito được xem là biểu tượng của sự thời thượng.",
                        Genre = "Soda",
                        Price = 50,
                        Image = "soda-mojito.jpg"
                    },
                    new Product()
                    {
                        Name = "Italian Soda",
                        Note = "Cái mát lạnh tê tái của soda kết hợp với vị ngọt ngào của sữa khiến ai cũng trầm trồ khen ngợi khi thưởng thức loại đồ uống này.",
                        Genre = "Soda",
                        Price = 60,
                        Image = "italian-soda.jpg"
                    }
                );
                context.SaveChanges();
                context.Account.AddRange(
                    new Account()
                    {
                        Id = "admin",
                        Password = "123456",
                        Privilege = 1,
                        Name = "No",
                        Address = "No",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "user",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Đắc Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "dodachieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Đắc Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "dodachoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Đắc Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "doxuanduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Xuân Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "doxuanhoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Xuân Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "doxuanhieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Xuân Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "dobaduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Bá Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "dobahieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Bá Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "dobahoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Đỗ Bá Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "ledacduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Đắc Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "ledachieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Đắc Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "ledachoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Đắc Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lexuanduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Xuân Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lexuanhieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Xuân Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lexuanhoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Xuân Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lebaduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Bá Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lebahieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Bá Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "lebahoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Lê Bá Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyendacduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Đắc Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyendachieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Đắc Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyendachoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Đắc Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenxuanduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Xuân Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenxuanhieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Xuân Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenxuanhoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Xuân Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenbaduoc",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Bá Được",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenbahieu",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Bá Hiếu",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    },
                    new Account()
                    {
                        Id = "nguyenbahoan",
                        Password = "123456",
                        Privilege = 2,
                        Name = "Nguyễn Bá Hoàn",
                        Address = "Số 1, đường AAA, phường BBB, quận CCC",
                        Email = "email@email.com",
                        Phone = "0123456789"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}