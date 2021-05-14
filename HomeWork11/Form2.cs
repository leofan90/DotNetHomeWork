﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class Form2 : Form
    {
        public String orderID { get; set; }
        public String clientname { get; set; }
        public String clientID { get; set; }
        public String goodsname { get; set; }
        public double goodsprice { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public int quantity { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OrderIDtextBox1.DataBindings.Add("Text", this, "orderID");
            clientIDBox2.DataBindings.Add("Text", this, "clientID");
            clientnametextBox2.DataBindings.Add("Text", this, "clientname");
            goodstextBox1.DataBindings.Add("Text", this, "goodsname");
            textBox1.DataBindings.Add("Text", this, "goodsprice");
            QuantityBox.DataBindings.Add("Text", this, "quantity");
            AddressBox.DataBindings.Add("Text", this, "address");
            PhoneBox.DataBindings.Add("Text", this, "phone");
        }

        private void OrderIDtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyOrderDetbutton1_Click(object sender, EventArgs e)
        {
            HomeWork6.Client client = new HomeWork6.Client(clientID, clientname);
            HomeWork6.Goods goods = new HomeWork6.Goods(goodsname, goodsprice);
            HomeWork6.Order neworder = new HomeWork6.Order(orderID, client);
            HomeWork6.OrderDetails neworderdetails = new HomeWork6.OrderDetails(goods, quantity, address, phone);
            neworder.addDetails(neworderdetails);
            using (var db = new Form1.OrderContext())
            {
                var query = db.Orders.Where(o => o.OrderID == orderID).OrderBy(o => o.Details.All(d => d.Total > 0));
                foreach(var o in query) { db.Orders.Remove(o); db.SaveChanges(); }
                db.Orders.Add(neworder);
                db.SaveChanges();
            }
        }

        private void AddOrderDetailbutton1_Click(object sender, EventArgs e)
        {
            HomeWork6.Client client = new HomeWork6.Client(clientID, clientname);
            HomeWork6.Goods goods = new HomeWork6.Goods(goodsname, goodsprice);
            HomeWork6.Order neworder = new HomeWork6.Order(orderID, client);
            HomeWork6.OrderDetails neworderdetails = new HomeWork6.OrderDetails(goods, quantity, address, phone);
            neworder.addDetails(neworderdetails);
            using (var db = new Form1.OrderContext())
            {
                db.Orders.Add(neworder);
                db.SaveChanges();
            }
        }

        private void goodstextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientIDBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientnametextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
