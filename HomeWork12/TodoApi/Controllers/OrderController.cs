using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TodoApi;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly OrderContext orderDb;

        public TodoController(OrderContext context)
        {
            this.orderDb = context;
        }

        [HttpPost]
        public ActionResult<List<Order>> AddOrder(string clientID, string clientname, string goodsname, double goodsprice, string orderID, int quantity, string address, string phone, string add){
            IQueryable<Order> query = orderDb.Orders;
            Client client = new Client(clientID, clientname);
            orderDb.Entry(client).State = EntityState.Added;
            Goods goods = new Goods(goodsname, goodsprice);
            orderDb.Entry(goods).State = EntityState.Added;
            Order neworder = new Order(orderID, client);
            orderDb.Entry(neworder).State = EntityState.Added;
            OrderDetails neworderdetails = new OrderDetails(goods, quantity, address, phone);
            neworder.Details = new List<OrderDetails>() { new OrderDetails() { Goods = goods, Quantity = quantity, Address = address, Phone = phone } };
            orderDb.Orders.Add(neworder);
            orderDb.SaveChanges();
            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Order> ModifyOrder(string clientID, string clientname, string goodsname, double goodsprice, string orderID, int quantity, string address, string phone){
            var oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.OrderID == orderID);
            if (oldorder != null)
            {
                orderDb.Clients.Remove(oldorder.Client);
                orderDb.OrderDetails.RemoveRange(oldorder.Details);
                orderDb.Orders.Remove(oldorder);
                orderDb.SaveChanges();
            }
            Client client = new Client(clientID, clientname);
            orderDb.Entry(client).State = EntityState.Added;
            Goods goods = new Goods(goodsname, goodsprice);
            orderDb.Entry(goods).State = EntityState.Added;
            Order neworder = new Order(orderID, client);
            orderDb.Entry(neworder).State = EntityState.Added;
            OrderDetails neworderdetails = new OrderDetails(goods, quantity, address, phone);
            neworder.Details = new List<OrderDetails>() { new OrderDetails() { Goods = goods, Quantity = quantity, Address = address, Phone = phone } };
            orderDb.Orders.Add(neworder);
            orderDb.SaveChanges();
            return neworder;
        }

        [HttpPost]
        public ActionResult<List<Order>> DeleteOrder(string property, string finding){
            List<Order> query;
            Order Oldorder;
            switch (property)
            {
                case "client":
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Client.Name == finding);
                    break;
                case "goods":
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Goods.Name == finding));
                    break;
                case "address":
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Address == finding));
                    break;
                case "phone":
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Phone == finding));
                    break;
                case "total":
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Total == Double.Parse(finding)));
                    break;
                default:
                    Oldorder = orderDb.Orders.Include("client").Include("Details").SingleOrDefault(o => o.OrderID == finding);
                    break;
            }
            if (Oldorder != null)
            {
                orderDb.Clients.Remove(Oldorder.Client);
                orderDb.OrderDetails.RemoveRange(Oldorder.Details);
                orderDb.Orders.Remove(Oldorder);
                orderDb.SaveChanges();
            }
            query = orderDb.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Customer").ToList();
            return query;
        }
    }
}
