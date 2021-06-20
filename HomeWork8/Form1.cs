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
    public partial class Form1 : Form
    {
        public String property { get; set; }
        public String finding { get; set; }

        internal static List<HomeWork6.Order> orderlist = new List<HomeWork6.Order>();

        internal static HomeWork6.OrderService orderService = new HomeWork6.OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            findingBox.DataBindings.Add("Text", this, "finding");
            selectProperty.DataBindings.Add("SelectedItem", this, "property");
//            HomeWork6.Client client1 = new HomeWork6.Client("TeacherID", "Teacher");

//            HomeWork6.Goods bread = new HomeWork6.Goods("bread", 10);

//           HomeWork6.Order order1 = new HomeWork6.Order("1", client1);

//            order1.addDetails(new HomeWork6.OrderDetails(bread, 4, "America", "12345"));

//            orderService.addOrder(order1);

        }

        private void goodsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void orderDetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddOrderbutton_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void DeleteOrderbutton_Click(object sender, EventArgs e)
        {
            Form1.orderlist = Form1.orderService.findOrder(property, finding);
            foreach (HomeWork6.Order item in Form1.orderlist) { Form1.orderService.deleteOrder(item); }
            foreach (HomeWork6.Order item in Form1.orderService.showOrder())
            {
                this.clientBindingSource.DataSource = item.Client;
                this.orderBindingSource.DataSource = new HomeWork6.Order(item.OrderID, item.Client);
                foreach (HomeWork6.OrderDetails item2 in item.Details)
                {
                    this.goodsBindingSource.DataSource = item2.Goods;
                    this.orderDetailsBindingSource.DataSource = new HomeWork6.OrderDetails(item2.Goods, item2.Quantity, item2.Address, item2.Phone);
                }
            }
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void ModifyOrderbutton1_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void FindOrderbutton1_Click(object sender, EventArgs e)
        {

        }

        private void OutputOrderbutton1_Click(object sender, EventArgs e)
        {
            orderService.orderExport("C:\\Users\\apple\\Desktop\\HomeWork8\\export.xml");
        }

        private void InputOrderbutton1_Click(object sender, EventArgs e)
        {
            orderService.orderExport("C:\\Users\\apple\\Desktop\\HomeWork8\\import.xml");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectProperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            orderlist = orderService.findOrder(property, finding);
            foreach (HomeWork6.Order item in Form1.orderlist) 
            {
                this.clientBindingSource.DataSource = item.Client;
                this.orderBindingSource.DataSource = new HomeWork6.Order(item.OrderID, item.Client);
                foreach(HomeWork6.OrderDetails item2 in item.Details)
                {
                    this.goodsBindingSource.DataSource = item2.Goods;
                    this.orderDetailsBindingSource.DataSource = new HomeWork6.OrderDetails(item2.Goods, item2.Quantity, item2.Address, item2.Phone);
                }
            }
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void ClientGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GoodsGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDetailGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderDetailGridView1.Update();
            ClientGridView2.Update();
            GoodsGridView3.Update();
            OrderGridView4.Update();
        }

        private void clientBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
