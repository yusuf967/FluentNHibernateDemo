using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateDemo
{
    public class CustomerMap:ClassMap<Customer>
    {
        public CustomerMap()
        {
            Table("Customer");
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.FirstName).Not.Nullable();
            Map(x => x.LastName).Not.Nullable();
        }
    }
}
