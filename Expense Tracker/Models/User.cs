using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Expense_Tracker.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Username..")]
        [Display(Name = "UserName")]
        [Column(TypeName = "nvarchar(20)")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Email..")]
        [Display(Name = "UserEmail")]
        [Column(TypeName = "nvarchar(20)")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Phone NO..")]
        [Display(Name = "UserPhone")]
        [Column(TypeName = "nvarchar(10)")]
        public string UserPhone { get; set; }

        [Required(ErrorMessage = "Please Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Column(TypeName = "nvarchar(20)")]
        public string UserPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public bool IsAuthenticated { get; set; } = false;






    }
}
