using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructures
{
    public interface IUnitOfWork:IDisposable
    {
        RespositoryBase<T>GetRepository<T>()where T:class;
        void commit();
    }
}
