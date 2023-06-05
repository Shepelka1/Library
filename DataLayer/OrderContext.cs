using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class OrderContext : IDb<Order, int>
    {
        private readonly LibraryDbContext dbContext;

        public OrderContext(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Order item)
        {
            try
            {
                dbContext.Orders.Add(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> ReadAll()
        {
            try
            {
                return dbContext.Orders.ToList();
            }
            catch (Exception)
            {

                throw;
            }    
        }

        public Order ReadOne(int id)
        {
            try
            {
                return dbContext.Orders.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Order item)
        {
            try
            {
                Order order = dbContext.Orders.Find(item.Id);
                dbContext.Entry(order).CurrentValues.SetValues(item);
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delele(int id)
        {
            try
            {
                dbContext.Orders.Remove(dbContext.Orders.Find(id));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
