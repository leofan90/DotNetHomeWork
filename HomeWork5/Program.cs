using System;
using System.Collections.Generic;
using System.Linq;
namespace HomeWork5
{
    public class Client{
        public string id{get; set;}
        public string name{get; set;}
        public Client(string id, string name){
            this.id = id;
            this.name = name;
        }
        public override string ToString(){
            return $"ClientId:{id}, ClientName:{name}";
        }
        public override bool Equals(object obj){
            var client = obj as Client;
            return client != null && id == client.id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public class Goods{
        public string id{get; set;}
        public string name{get; set;}
        private double price;
        public double Price{
            get{return price;}
            set{
                if (value < 0)
                    throw new ArgumentOutOfRangeException("the price must be >= 0!");
                price = value;
            }
        }
        public Goods(string id, string name, double price){
            this.id = id;
            this.name = name;
            this.Price = price;
        }
        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && id == goods.id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString() {
            return $"Id:{id}, Name:{name}, Value:{Price}";
        }
    }
    public class Order{
        public string OrderID{get; set;}
        public Client Client{get; set;}
        public List<OrderDetails> Details { get; } = new List<OrderDetails>();
        public Order(string orderID, Client client){
            OrderID = orderID;
            Client = client;
        }
        public void addDetails(OrderDetails orderDetail) {
            if (this.Details.Contains(orderDetail)) {
                throw new ApplicationException($"The goods ({orderDetail.Goods.name}) exist in order {OrderID}");
            }
            Details.Add(orderDetail);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Order))
            {
                throw new System.ArgumentException();
            }
            var m = obj as Order;
            return m != null && m.OrderID == OrderID;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            String result = $"OrderId:{OrderID}, Client:({Client})";
            return result;
        }
    }
    public class OrderDetails{
        public Goods Goods{get; set;}
        public int Quantity{get; set;}
        public string Address{get; set;}
        public string Phone{get; set;}
        public double Total{get => Goods.Price * Quantity;}
        public OrderDetails(Goods goods, int quantity, string address, string phone){
            Goods = goods;
            Quantity = quantity;
            Address = address;
            Phone = phone;
        }
        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.Goods == Goods && m.Quantity == Quantity;
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
    public class OrderService{
        private List<Order> orderlist = new List<Order>();
        public OrderService() {
        }
        public List<Order> QueryAll() {
            return orderlist;
        }
        public void addOrder(Order order){
                orderlist.Add(order);
        }
        public void deleteOrder(Order order){
            var query = from o in orderlist where o.OrderID == order.OrderID select o;
            if (query ==null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((Order)query);
            }
        }
        public void modifyOrder(Order order, Order newOrder){
            var query = from o in orderlist where o.OrderID == order.OrderID select o;
            if (query ==null)
            {
                throw new System.NullReferenceException();
            }
            else
            {
                orderlist.Remove((Order)query);
                orderlist.Add((Order)newOrder);
            }
        }
        public List<Order> findOrder(string property, string finding){
            switch (property)
                {
                    case "client": 
                        var cquery = from o in orderlist where o.Client.name == finding orderby o.Details.All(d => d.Total > 0) select o; 
                        return cquery.ToList();
                    case "goods": 
                        var gquery = from o in orderlist where o.Details.Any(d => d.Goods.name == finding) orderby o.Details.All(d => d.Total > 0) select o; 
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
        public List<Order> orderOrderlist(string property){
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
                        var tquery = from o in orderlist orderby o.Details.All(d => d.Total > 0 ) select o;
                        return tquery.ToList();
                    default:
                        var query = from o in orderlist orderby o.OrderID select o;
                        return query.ToList();

                }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Client client1 = new Client("1", "Client1");
                Client client2 = new Client("2", "Client2");

                Goods milk = new Goods("1", "Milk", 69.9f);
                Goods eggs = new Goods("2", "eggs", 4.99f);
                Goods apple = new Goods("3", "apple", 5.59f);

                Order order1 = new Order("1", client1);
                order1.addDetails(new OrderDetails(apple, 8, "America", "12345"));
                order1.addDetails(new OrderDetails(eggs, 10, "America", "12345"));
                //order1.AddDetails(new OrderDetail(eggs, 8));
                //order1.AddDetails(new OrderDetail(milk, 10));

                Order order2 = new Order("2", client2);
                order2.addDetails(new OrderDetails(eggs, 10, "China","67890"));
                order2.addDetails(new OrderDetails(milk, 10, "China","67890"));

                Order order3 = new Order("3", client2);
                order3.addDetails(new OrderDetails(milk, 100, "China","67890"));

                OrderService orderService = new OrderService();
                orderService.addOrder(order1);
                orderService.addOrder(order2);
                orderService.addOrder(order3);

                List<Order> orders = orderService.QueryAll();
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\n OrderByID");
                orders = orderService.orderOrderlist("OrderID");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersByClientName:'Client2'");
                orders = orderService.findOrder("client", "Client2");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersByGoodsName:'eggs'");
                orders = orderService.findOrder("goods", "eggs");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersTotalAmount:1000");
                orders = orderService.findOrder("total", "1000");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\n order by Amount");
                orders = orderService.orderOrderlist("total");
                orders.ForEach(o => Console.WriteLine(o));

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
