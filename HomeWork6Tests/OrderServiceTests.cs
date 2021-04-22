using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork6;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HomeWork6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        List<Order> orders = null;

        [TestInitialize]
        public void TestInitialize()
        {
            OrderService orderService = new OrderService();
            Client client1 = new Client("TeacherID", "Teacher");
            Order o1 = new Order("1", client1);
            orderService.addOrder(o1);
            List<Order> orders = orderService.showOrder();
        }

        [TestMethod()]
        public void showOrderTest()
        {
            
        }

        [TestMethod()]
        public void addOrderTest()
        {
            Client client2 = new Client("StudentID", "Student");
            Order o1 = new Order("2", client2);
            orderService.addOrder(o1);
            Assert.IsNotNull(orderService);
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            Order o1 = null;
            orderService.deleteOrder(o1);
            Assert.IsNotNull(orderService);

            Client client1 = new Client("TeacherID", "Teacher");
            Order o2 = new Order("1", client1);
            orderService.deleteOrder(o2);
            Assert.IsNull(orderService);
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            Client client1 = new Client("TeacherID", "Teacher");
            Order o1 = new Order("1", client1);
            Order o2 = null;
            orderService.modifyOrder(o2, o1);
            Assert.IsNotNull(orderService);

            orderService.modifyOrder(o1, o2);
            Assert.IsNull(orderService);

        }

        [TestMethod()]
        public void findOrderTest()
        {
            string property = "client";
            List<Order> orders1 = orderService.showOrder();
            orders = orderService.findOrder(property, "Teacher");
            Assert.AreEqual(orders, orders1);
        }

        [TestMethod()]
        public void orderOrderlistTest()
        {
            string property = "client";
            List<Order> orders1 = orderService.showOrder();
            orders = orderService.orderOrderlist("client");
            Assert.AreEqual(orders, orders1);
        }

        [TestMethod()]
        public void orderExportTest()
        {
            String file = "export.xml";
            orderService.orderExport(file);
            Assert.IsTrue(File.Exists(file));

            String result = File.ReadAllText(file);
            String expect = File.ReadAllText("../expectedOrders.xml");
            Assert.AreEqual(expect, result);

            File.Delete(file);
        }

        [TestMethod()]
        public void orderImportTest()
        {
            List<Order> expect = orderService.showOrder();
            orderService.orderImport("../expectedOrders.xml");
            List<Order> result = orderService.showOrder();
            Assert.AreEqual(expect, result);
        }
    }
}