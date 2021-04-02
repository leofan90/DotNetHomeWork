using System;
using System.Collections.Generic;
using System.Linq;
namespace HomeWork5
{
    public class Order{
        private string orderID;
        public string OrderID{get; set;}
        public Order(string orderID){
            OrderID = this.orderID;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Order))
            {
                throw new System.ArgumentException();
            }
            Order m = obj as Order;
            return m != null && m.orderID == orderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return orderID;
        }
    }
    public class OrderDetails:Order{
        private string client;
        private string goods;
        private string address;
        private string phone;
        private double total;
        public string Client{get; set;}
        public string Goods{get; set;}
        public string Address{get; set;}
        public string Phone{get; set;}
        public double Total{get; set;}
        public OrderDetails(string orderID, string client, string goods, string address, string phone, double total):base(orderID){
            client = this.client;
            goods = this.goods;
            address = this.address;
            phone = this.phone;
            total =this.total;
        }
        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            if (OrderID == m.OrderID)
            {
                return m != null && m.goods ==goods;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "OrderID:" + OrderID + "/n" + "Client:" + client + "/n" + "Goods:" + goods + "/n" + "Address:" + address + "/n" + "Phone:" + phone + "/n" + "Total:" + total + "/n";
        }
    }
    public class OrderService{
        static private List<OrderDetails> orderlist = new List<OrderDetails>();
        static public void addOrder(string orderID, string client, string goods, string address, string phone, double total){
            var query = from o in orderlist where o.OrderID == orderID select o;
            if (query != null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Add(new OrderDetails(orderID,client,goods,address,phone,total));
            }
        }
        static public void deleteOrder(string orderID){
            var query = from o in orderlist where o.OrderID == orderID select o;
            if (query ==null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((OrderDetails)query);
            }
        }
        static public void modifyOrder(string orderID, string property, string newone){
            var query = from o in orderlist where o.OrderID == orderID select o;
            if (query ==null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((OrderDetails)query);
                switch (property)
                {
                    case "client": ((OrderDetails)query).Client = newone; break;
                    case "goods": ((OrderDetails)query).Goods = newone; break;
                    case "address": ((OrderDetails)query).Address = newone; break;
                    case "phone": ((OrderDetails)query).Phone = newone; break;
                    case "total": ((OrderDetails)query).Total = Double.Parse(newone); break;
                }
                orderlist.Add((OrderDetails)query);
            }
        }
        static public void findOrder(string property){
            switch (property)
                {
                    case "client": 
                        var cquery = from o in orderlist orderby o.Total select o.Client; 
                        ((OrderDetails)cquery).ToString();
                        break;
                    case "goods": 
                        var gquery = from o in orderlist orderby o.Total select o.Goods; 
                        ((OrderDetails)gquery).ToString();
                        break;
                    case "address": 
                        var aquery = from o in orderlist orderby o.Total select o.Address; 
                        ((OrderDetails)aquery).ToString();
                        break;
                    case "phone": 
                        var pquery = from o in orderlist orderby o.Total select o.Phone; 
                        ((OrderDetails)pquery).ToString();
                        break;
                    case "total": 
                        var tquery = from o in orderlist orderby o.Total select o.Total; 
                        ((OrderDetails)tquery).ToString();
                        break;
                    default:
                        var query = from o in orderlist orderby o.Total select o.OrderID;
                        ((OrderDetails)query).ToString();
                        break;
                }
        }
        static public void orderOrderlist(string property){
            switch (property)
                {
                    case "client": 
                        var cquery = from o in orderlist orderby o.Client select o;
                        ((OrderDetails)cquery).ToString();
                        break;
                    case "goods": 
                        var gquery = from o in orderlist orderby o.Goods select o;
                        ((OrderDetails)gquery).ToString();
                        break;
                    case "address": 
                        var aquery = from o in orderlist orderby o.Address select o;
                        ((OrderDetails)aquery).ToString();
                        break;
                    case "phone": 
                        var pquery = from o in orderlist orderby o.Phone select o;
                        ((OrderDetails)pquery).ToString();
                        break;
                    case "total": 
                        var tquery = from o in orderlist orderby o.Total select o;
                        ((OrderDetails)tquery).ToString();
                        break;
                    default:
                        var query = from o in orderlist orderby o.OrderID select o;
                        ((OrderDetails)query).ToString();
                        break;

                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
