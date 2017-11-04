using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyFinance.Domain.Entites
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Product> MyProducts { get; set; }

    }
}
