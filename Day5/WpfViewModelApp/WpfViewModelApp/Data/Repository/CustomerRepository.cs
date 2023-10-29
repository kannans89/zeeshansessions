using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfViewModelApp.Business;

namespace WpfViewModelApp.Data.Repository
{
    public class CustomerRepository
    {
        private CompanyContext _db;


        public CustomerRepository() {

            _db= new CompanyContext();
        }

        public List<Customer> GetAllCustomers() {

            return _db.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {

            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public void Remove(int id)
        {

            var customer = _db.Customers
                .FirstOrDefault(c => c.Id == id);

            _db.Customers.Remove(customer);

            _db.SaveChanges();
        }

        public Customer GetByCustomerFirstName(string firstName)
        {
         return   _db.Customers.FirstOrDefault(c => c.FirstName.Equals(firstName))
               ;

        }
        public void Update(Customer newCustomer) {
           
             
            ////if (customer != null)
            ////{
            ////    customer.FirstName = newCustomer.FirstName;
            ////    customer.LastName = newCustomer.LastName;
            ////}

            ///_db.Entry(newCustomer).State = customer==null ?
            //                      EntityState.Added :
            ////                      EntityState.Modified;
            _db.Customers.Update(newCustomer);
           _db.SaveChanges();

        }
    }
}
