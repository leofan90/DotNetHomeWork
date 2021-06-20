using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
namespace HomeWork6
{
    public class Client
    {
        //Primary key
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
        //Primary key
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
        //Primary key
        public string OrderID { get; set; }
        //Foreign key
        public string ClientID { get; set; }
        //Navigation properties
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
        //Primary
        public string Id { get; set; }
        //Navigation properties
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
        public void orderExport(string filename)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                xmlserializer.Serialize(fs, this.orderlist);
            }
        }
        public void orderImport(string filename)
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                this.orderlist = (List<Order>)xmlserializer.Deserialize(fs);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("TeacherID", "Teacher");
            Client client2 = new Client("StudentID", "Student");

            Goods milk = new Goods("Milk", 27.3);
            Goods eggs = new Goods("eggs", 3.5);
            Goods bread = new Goods("apple", 10);

            Order order1 = new Order("1", client1);
            order1.addDetails(new OrderDetails(bread, 4, "America", "12345"));
            order1.addDetails(new OrderDetails(eggs, 10, "America", "12345"));

            Order order2 = new Order("2", client2);
            order2.addDetails(new OrderDetails(eggs, 1, "China", "67890"));
            order2.addDetails(new OrderDetails(milk, 1, "China", "67890"));

            Order order3 = new Order("3", client2);
            order3.addDetails(new OrderDetails(milk, 100, "China", "67890"));

            OrderService orderService = new OrderService();
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);

            List<Order> orders = orderService.showOrder();
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nOrderByID");
            orders = orderService.orderOrderlist("OrderID");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByClientName:'Student'");
            orders = orderService.findOrder("client", "Student");
            orders.ForEach(o => Console.WriteLine(o));

            Console.WriteLine("\nGetOrdersByGoodsName:'eggs'");
            orders = orderService.findOrder("goods", "eggs");
            orders.ForEach(o => Console.WriteLine(o));

            orderService.orderExport("C:\\visual studio\\HomeWork6\\export.xml");
            orderService.orderImport("C:\\visual studio\\HomeWork6\\export.xml");
        }
    }
}
