using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace FluentNHibernateDemo
{
    public class NHibernateHelper
    {
        public static ISessionFactory session;
        public static ISessionFactory CreateSession()
        
        {
             string connectionString = @"Data source=(localdb)\mssqllocaldb; User ID=; Password=; Database=NHibernateDB;Integrated Security=True";

            if (session != null)
              return session;


            var sqlConfiguration = MsSqlConfiguration.MsSql2012.ConnectionString(connectionString);


           return Fluently.Configure()
               .Database(sqlConfiguration)
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Customer>()).BuildSessionFactory();
        }

        public static ISession SessionOpen()
        {
            return CreateSession().OpenSession();
        }
    }
}
   
