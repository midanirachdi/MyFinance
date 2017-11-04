using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configrations
{
    //partie flunet api
    public class CategoryConfigration:EntityTypeConfiguration<Category>
    {
        public CategoryConfigration()
        {
            HasKey(c => c.CategoryId);
            //la propriete puis les regles 
            Property(c => c.NameCategory).IsRequired().HasMaxLength(50);
        }
    }
}
