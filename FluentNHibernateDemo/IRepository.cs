using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateDemo
{
    interface IRepository<T> where T : class
    {
        void Add(T entities);
        void Delete(T entites);

        void Update(T entities);

        T GetById(int id);

        List<T> GetAll();
    }
}
