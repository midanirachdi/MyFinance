using MyFinance.Data.Configrations;
using MyFinance.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data
{
   public class MyFinalsContext:DbContext
    {
        /*
        -> génération de base de données 1 seule fois
	    -> se pointer sur la base : pour remplir les dbset par les informations 
	       qui existent dans la base de données
        -> le constructeur par défault ne met pas la base de données à jour si sa structure change
        */

            // MyFinanceCS : pointe sur le connectionString ( se trouve dans le fichier MyFinance.Data/App.config)
        public MyFinalsContext() : base("Name=MyFinanceCS")
        {
            /*
             * si les dbset dans la base de données sont les mêmes que ceux ici , 
            ce custom initializer ne va pas être utilisé
             */
            Database.SetInitializer<MyFinalsContext>(new MyFinanceContextInitializer());
        }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }

        // use annotations or configuration class instanciated in the context
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
             * dbModelbuilder: takes configuration rules and applies them when migrations happen or context intiliazer happens
             works sur le contenu des colones
            */
            modelBuilder.Configurations.Add(new CategoryConfigration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
        }

    }
    
    public class MyFinanceContextInitializer : DropCreateDatabaseIfModelChanges<MyFinalsContext> 
    {
        //alimenter directement la base de données 
        protected override void Seed(MyFinalsContext context)
        {

            List<Category> MyList = new List<Category>
            {
                new Category {NameCategory="vetements" },
                  new Category {NameCategory="medicaments" },
                    new Category {NameCategory="meubles" },
            };
            context.Categorys.AddRange(MyList);
            context.SaveChanges();
        }
      
    }
}
