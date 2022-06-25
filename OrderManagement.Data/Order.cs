using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using OrderManagement.Data.Entity;

namespace OrderManagement.Data
{
    public class Order : DataObject
    {

        public Order(): base(null)
        {
            var holder = ConnectionString;
        }

        public Order(SqlTransaction trans): base(trans)
        {
           
        }

        public List<OrderEntity> GetOrders(SqlTransaction trans = null)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);


            sqlConnection.Open();

            var transaction = trans == null ? sqlConnection.BeginTransaction() : Trans ?? trans;


            try
            {
                //send invoice
                //create order
                //payment 




                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                sqlConnection.Close();
            }

            return new List<OrderEntity>();
        }

        public OrderEntity GetOrder(int id)
        {
            OrderEntity order = new OrderEntity();

            order.AddressItem = new Address().GetAddress(order.AddressId);
            
            return order;
        }

        public OrderEntity CreateOrder(OrderEntity model)
        {
            return new OrderEntity();
        }

        public OrderEntity UpdateOrder(OrderEntity model)
        {
            return new OrderEntity();
        }

        public void DeleteOrder(int id)
        {

        }
    }



  
}