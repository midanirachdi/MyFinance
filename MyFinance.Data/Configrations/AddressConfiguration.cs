using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configrations
{
    //
    class AddressConfiguration:ComplexTypeConfiguration<Adress>
    {
        /*
         * use ctx to implement these changes
         * 
         * even if we don't respect complex type rules(3 rules) 
         * the inheritance means the class is complex
         * NB: can't use annotations for complex type
         * 
         * EntityTypeConfiguration<Address> is used for simple type
         * ComplexTypeConfiguration<Address> is for complex type
             */
        public AddressConfiguration()
        {
            Property(a => a.City).IsRequired();
            Property(a => a.StreetAddress).IsOptional().HasMaxLength(50);
        }
    }
}
