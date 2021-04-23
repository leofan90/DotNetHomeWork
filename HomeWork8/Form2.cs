using System;
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
        public HomeWork5.Client client { get; set; }
        public HomeWork5.Goods goods { get; set; }
        public HomeWork5.OrderDetails orderDetails { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public int quantity { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
//            OrderIDtextBox1.DataBindings.Add("Text", this, "orderID");
//            ClientBox.DataBindings.Add("Text", this, "client");
//            goodstextBox1.DataBindings.Add("Text", this, "goods.Name");
//            textBox1.DataBindings.Add("Text", this, "goods.Price");
            QuantityBox.DataBindings.Add("Text", this, "quantity");
            AddressBox.DataBindings.Add("Text", this, "address");
            PhoneBox.DataBindings.Add("Text", this, "phone");
        }

        private void OrderIDtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifyOrderDetbutton1_Click(object sender, EventArgs e)
        {
            HomeWork5.Order neworder = new HomeWork5.Order(orderID, client);
            HomeWork5.OrderDetails neworderdetails = new HomeWork5.OrderDetails(goods, quantity, address, phone);
            neworder.addDetails(neworderdetails);
            Form1.orderlist = Form1.orderService.findOrder("order", orderID);
            foreach(HomeWork5.Order item in Form1.orderlist) { HomeWork5.Order order = item; Form1.orderService.modifyOrder(order, neworder); }
        }

        private void AddOrderDetailbutton1_Click(object sender, EventArgs e)
        {
            HomeWork5.Order neworder = new HomeWork5.Order(orderID, client);
            HomeWork5.OrderDetails neworderdetails = new HomeWork5.OrderDetails(goods, quantity, address, phone);
            neworder.addDetails(neworderdetails);
            Form1.orderService.addOrder(neworder);
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

        private void ClientBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
