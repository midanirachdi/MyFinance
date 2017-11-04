using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Configrations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {

        public ProductConfiguration()
        {
            /*
             * relation d'héritage(usually its mapped by default we just 
               redefined discriminator column and renamed it IsBiological)
            */
            Map<Biological>(b => b.Requires("isBiological").HasValue(1));
            Map<Chemical>(b => b.Requires("isBiological").HasValue(2));


            //ManyToMany
            HasMany(p => p.MyProviders).WithMany(pr => pr.MyProducts).Map(t=>
            {
                //une seule variable parceque le mapping va se faire dans une seule table
                t.ToTable("ProductProvding");//table d'association
                t.MapLeftKey("Product");//parent entity
                t.MapRightKey("Provider");
            });
            //realtion one to many //tjs desctiver delete on cascade si 0..* optionel puisque il peut n'avait pas des product
            HasOptional(p => p.MyCategory).WithMany(c => c.MyProducts).HasForeignKey(p => p.CategoryId).WillCascadeOnDelete(false);

        }



    }
}
