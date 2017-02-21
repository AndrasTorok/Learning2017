using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAutofac.Abstract;

namespace UsingAutofac.Concrete
{
    public class PersonRepository : RepositoryBase<IPerson>, IPersonRepository
    {
    }
}
