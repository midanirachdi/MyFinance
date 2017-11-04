using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entites
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string NameCategory { get; set; }
        public virtual ICollection<Product> MyProducts{ get; set; }
    }
}
