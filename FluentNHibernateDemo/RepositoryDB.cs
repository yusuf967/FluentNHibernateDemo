using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernateDemo
{
    public class RepositoryDB : IRepository<Customer>
    {
        ISession session;
        ITransaction transaction;
        public void Add(Customer entities)
        {
            using (ISession session = NHibernateHelper.SessionOpen())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entities);
                transaction.Commit();
            }
        }

        public void Delete(Customer entites)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entities)
        {
            throw new NotImplementedException();
        }
    }
}
