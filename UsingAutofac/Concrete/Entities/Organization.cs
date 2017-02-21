using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingAutofac.Abstract;

namespace UsingAutofac.Concrete
{
    public class Organization : IOrganization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<IPerson> Persons { get; set; }
    }
}
