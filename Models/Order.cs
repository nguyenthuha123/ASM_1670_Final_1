using System.ComponentModel.DataAnnotations;

namespace _1670_Final.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter quantity book you want to borrow")]
        public int Qty { get; set; }
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter your phoneNumber")]
        public string Phone { get; set; }

        public DateTime OrderTime { get; set; }

        public int BookId { get; set; }

        public int UserId { get; set; }


        //cho phep lam khac base

        public virtual Book? book { get; set; }

        public virtual User? User { get; set; }
    }
}
