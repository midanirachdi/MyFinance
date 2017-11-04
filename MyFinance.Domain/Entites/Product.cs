using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Domain.Entites
{
   public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required]
        [StringLength(25,ErrorMessage="invalid")]
        [MaxLength(50,ErrorMessage ="invalid")]
        public string Name { get; set; }

        [Range(0,int.MaxValue,ErrorMessage ="prix doit etre postive")]
        public int Quantity { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Prix invalid")]
        public double price { get; set; }
        [DataType(DataType.MultilineText,ErrorMessage ="")]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name ="date de production")]
        public DateTime DateProd { get; set; }
       
        public virtual ICollection<Provider> MyProviders { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category MyCategory { get; set; }
        
        //FK nullable
       
        public int? CategoryId { get; set; }

        public string ImageName { get; set; }
    }
}
