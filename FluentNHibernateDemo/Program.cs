
using NHibernate;
using System.Data.Common;
using System.Transactions;

namespace FluentNHibernateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.FirstName = "Yusuf";
            customer.LastName = "Dogan";

            IRepository<Customer> repository = new RepositoryDB();
            repository.Add(customer);

            Console.WriteLine("Müşreti Eklendi: "+customer.FirstName+" "+customer.LastName);

            }

        }
    }

        
    