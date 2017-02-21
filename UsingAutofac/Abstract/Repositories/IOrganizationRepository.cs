using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAutofac.Abstract
{
    public interface IOrganizationRepository : IRepository<IOrganization>
    {
    }
}
