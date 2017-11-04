using MyFinance.Data.Infrastructures;
using MyFinance.Domain.Entites;
using MyFinanceService;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinanceConsole
{
    public class Program
    {
        /*
         * if you want to test using this: Click “Set as start-up project”
         */
         
        static void Main(string[] args)
        {

            //ajouter un produit // ajouter un catgeroy.
            //UnitOfWork o = new UnitOfWork();
            //Product p1 = new Product
            //{
            //    DateProd = new DateTime(),
            //    Name = "p1",
            //    price = 12

            //};
            //ServicePattern.Service<Product> d = new Service<Product>(o);
            //d.Create(p1);
            //System.Console.WriteLine("sucess");
            //System.Console.ReadKey();

            MyFinance.Data.MyFinalsContext ctx = new MyFinance.Data.MyFinalsContext();
            Product p1 = new Product
            {
                DateProd = new DateTime(),
                Name = "p1",
                price = 12

            };
            ctx.Products.Add(p1);
            ctx.SaveChanges();


        }
    }
}
