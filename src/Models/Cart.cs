
using System.ComponentModel.DataAnnotations;

namespace Coffee.Models
{
    public class Cart
    {
        public int Id { get; set; }
        
        public string User { get; set; }
        public int Product { get; set; }
        public int Quantity { get; set; }
    }
}
