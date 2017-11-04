using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructures
{
    public class DatabaseFactory :Disposable, IDatabaseFactory
    {
        private MyFinalsContext mycontext;
        public DatabaseFactory()
        {
            mycontext = new MyFinalsContext();
        }
        public MyFinalsContext Mycontext
        {
            get { return mycontext;}
        }
        protected override void DisposeCore()
        {
            if (Mycontext != null)
                Mycontext.Dispose();
        }
    }
}
