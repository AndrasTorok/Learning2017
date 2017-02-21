using System.Collections.Generic;

namespace UsingAutofac.Abstract
{
    public interface IOrganization
    {
        int Id { get; set; }
        string Name { get; set; }
        IList<IPerson> Persons { get; set; }
    }
}