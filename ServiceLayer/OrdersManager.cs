using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer;
using DataLayer;

namespace ServiceLayer
{
    public class OrdersManager
    {
        private static OrderContext orderContext;
        public OrdersManager(LibraryDbContext dbContext)
        {
            orderContext = new OrderContext(dbContext);
        }

        public static void Create(Order order)
        {
            try
            {
                orderContext.Create(order);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Order Read(int key)
        {
            try
            {
                return orderContext.ReadOne(key);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ICollection<Order> ReadAll()
        {
            try
            {
                return orderContext.ReadAll();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Update(Order order)
        {
            try
            {
                orderContext.Update(order);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void Delete(int key)
        {
            try
            {
                orderContext.Delele(key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
