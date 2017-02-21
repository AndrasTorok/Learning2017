using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAutofac.Abstract;

namespace UsingAutofac.Concrete
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable
        where T : class
    {       
        public T GetById(int id)
        {
            return null;
        }

        public void Dispose()
        {
            //implementation will come here
        }
    }
}
