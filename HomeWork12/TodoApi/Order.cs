using System;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TodoApi
{
    public class Client
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Client()
        {
            ID = Guid.NewGuid().ToString();
        }
        public Client(string ID, string Name):this()
        {
            this.ID = ID;
            this.Name = Name;
        }
        public override string ToString()
        {
            return "ClientID:" + ID + "," + "ClientName:" + Name;
        }
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null && this.ID == client.ID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public class Goods
    {
        public string Id { get; set; }
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The price is negative");
                }
                price = value;
            }
        }
        public Goods()
        {
            Id = Guid.NewGuid().ToString();
        }
        public Goods(string Name, double price):this()
        {
            this.Name = Name;
            this.Price = price;
        }
        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && this.Name == goods.Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "GoodsName:" + Name + "," + "GoodsPrice:" + Price;
        }
    }
    public class Order
    {
        public string OrderID { get; set; }
        public string ClientID { get; set; }
        public Client Client { get; set; }
        public List<OrderDetails> Details = new List<OrderDetails>();
        public Order()
        {
            OrderID = Guid.NewGuid().ToString();
        }
        public Order(string orderID, Client client):this()
        {
            this.OrderID = orderID;
            this.Client = client;
        }
        public void addDetails(OrderDetails orderDetail)
        {
            Details.Add(orderDetail);
        }
        public override bool Equals(object obj)
        {
            var m = obj as Order;
            return m != null && m.OrderID == OrderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "OrderID:" + OrderID + "," + "Client:" + "(" + Client + ")";
        }
    }
    public class OrderDetails
    {
        public string Id { get; set; }
        public Goods Goods { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Total { get { return Goods.Price * Quantity; } }
        public OrderDetails()
        {
            Id = Guid.NewGuid().ToString();
        }
        public OrderDetails(Goods goods, int quantity, string address, string phone):this()
        {
            this.Goods = goods;
            this.Quantity = quantity;
            this.Address = address;
            this.Phone = phone;
        }
        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.Phone == Phone;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Goods:" + Goods + "/n" + "Quantity:" + Quantity + "Address:" + Address + "/n" + "Phone:" + Phone;
        }
    }
    public class OrderService
    {
        private List<Order> orderlist = new List<Order>();
        public OrderService()
        {
        }
        public List<Order> showOrder()
        {
            return orderlist;
        }
        public void addOrder(Order order)
        {
            orderlist.Add(order);
        }
        public void deleteOrder(Order order)
        {
            if (order == null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                    orderlist.Remove(order);
            }
        }
        public void modifyOrder(Order order, Order newOrder)
        {
//            var query = from o in orderlist where o.OrderID == order.OrderID select o;
            if (order == null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                    orderlist.Remove(order);
                    orderlist.Add(newOrder);           
            }
        }
        public List<Order> findOrder(string property, string finding)
        {
            switch (property)
            {
                case "client":
                    var cquery = from o in orderlist where o.Client.Name == finding orderby o.Details.All(d => d.Total > 0) select o;
                    return cquery.ToList();
                case "goods":
                    var gquery = from o in orderlist where o.Details.Any(d => d.Goods.Name == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return gquery.ToList();
                case "address":
                    var aquery = from o in orderlist where o.Details.Any(d => d.Address == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return aquery.ToList();
                case "phone":
                    var pquery = from o in orderlist where o.Details.Any(d => d.Phone == finding) orderby o.Details.All(d => d.Total > 0) select o;
                    return pquery.ToList();
                case "total":
                    var tquery = from o in orderlist where o.Details.Any(d => d.Total == Double.Parse(finding)) orderby o.Details.All(d => d.Total > 0) select o;
                    return tquery.ToList();
                default:
                    var query = from o in orderlist where o.OrderID == finding orderby o.Details.All(d => d.Total > 0) select o;
                    return query.ToList();
            }
        }
        public List<Order> orderOrderlist(string property)
        {
            switch (property)
            {
                case "client":
                    var cquery = from o in orderlist orderby o.Client select o;
                    return cquery.ToList();
                case "goods":
                    var gquery = from o in orderlist orderby o.Details.All(d => d.Goods != null) select o;
                    return gquery.ToList();
                case "address":
                    var aquery = from o in orderlist orderby o.Details.All(d => d.Address != null) select o;
                    return aquery.ToList();
                case "phone":
                    var pquery = from o in orderlist orderby o.Details.All(d => d.Phone != null) select o;
                    return pquery.ToList();

                case "total":
                    var tquery = from o in orderlist orderby o.Details.All(d => d.Total > 0) select o;
                    return tquery.ToList();
                default:
                    var query = from o in orderlist orderby o.OrderID select o;
                    return query.ToList();

            }
        }
    }

    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Goods> Goods { get; set; }
    }
}
