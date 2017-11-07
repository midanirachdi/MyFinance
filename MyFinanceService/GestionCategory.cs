using MyFinance.Data.Infrastructures;
using MyFinance.Domain.Entites;
using ServicePattern;

namespace MyFinanceService
{
    public class GestionCategory:Service<Category>,IGestionCategory
    {
        //static to not be changed outside of the construct
        static  DatabaseFactory dbFactory = new DatabaseFactory();
        static UnitOfWork utw;
        public GestionCategory():base(utw)
        {
            
            utw = new UnitOfWork(dbFactory);
        }
       
    }
}
