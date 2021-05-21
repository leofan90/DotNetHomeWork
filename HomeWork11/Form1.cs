using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HomeWork8
{
    public partial class Form1 : Form
    {
        public class OrderContext : DbContext
        {
            public OrderContext() : base("OrderDataBase")
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
            }
            public DbSet<HomeWork6.Order> Orders { get; set; }
            public DbSet<HomeWork6.OrderDetails> OrderDetails { get; set; }
            public DbSet<HomeWork6.Client> Clients { get; set; }
            public DbSet<HomeWork6.Goods> Goods { get; set; }
        }

        public String property { get; set; }
        public String finding { get; set; }

        public HomeWork6.Order Oldorder { get; set; }
        public IQueryable<HomeWork6.Order> query { get; set; }

        public List<HomeWork6.Order> orderlist = new List<HomeWork6.Order>();

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
            using (var db = new Form1.OrderContext())
            {
                switch (property)
                {
                    case "client":
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Client.Name == finding);
                        break;
                    case "goods":
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Goods.Name == finding));
                        break;
                    case "address":
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Address == finding));
                        break;
                    case "phone":
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Phone == finding));
                        break;
                    case "total":
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.Details.Any(d => d.Total == Double.Parse(finding)));
                        break;
                    default:
                        Oldorder = db.Orders.Include("client").Include("Details").SingleOrDefault(o => o.OrderID == finding);
                        break;
                }
                if (Oldorder != null)
                {
                    db.Clients.Remove(Oldorder.Client);
                    db.OrderDetails.RemoveRange(Oldorder.Details);
                    db.Orders.Remove(Oldorder);
                    db.SaveChanges();
                }
                 orderlist = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Customer").ToList();
            }
            foreach (HomeWork6.Order item in orderlist)
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

        }

        private void InputOrderbutton1_Click(object sender, EventArgs e)
        {

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
            using (var db = new Form1.OrderContext())
            {
                switch (property)
                {
                    case "client":
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.Client.Name == finding);
                        query.ToList();
                        break;
                    case "goods":
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.Details.Any(item => item.Goods.Name == finding));
                        query.ToList();
                        break;
                    case "address":
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.Details.Any(item => item.Address == finding));
                        query.ToList();
                        break;
                    case "phone":
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.Details.Any(item => item.Phone == finding));
                        query.ToList();
                        break;
                    case "total":
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.Details.Any(item => item.Total == Double.Parse(finding)));
                        query.ToList();
                        break;
                    default:
                        query = db.Orders.Include(o => o.Details.Select(d => d.Goods)).Include("Client")
                            .Where(order => order.OrderID == finding);
                        query.ToList();
                        break;
                }         
            }
            foreach (HomeWork6.Order item in query) 
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
