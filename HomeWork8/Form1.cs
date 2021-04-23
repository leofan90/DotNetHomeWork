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

        internal static List<HomeWork5.Order> orderlist = new List<HomeWork5.Order>();

        internal static HomeWork5.OrderService orderService = new HomeWork5.OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            findingBox.DataBindings.Add("Text", this, "finding");
            selectProperty.DataBindings.Add("SelectedItem", this, "property");
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
            orderlist = orderService.findOrder(property, finding);
            foreach (HomeWork5.Order item in Form1.orderlist) { HomeWork5.Order order = item; Form1.orderService.deleteOrder(order); }
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
            orderService.orderExport("export.xml");
        }

        private void InputOrderbutton1_Click(object sender, EventArgs e)
        {
            orderService.orderExport("import.xml");
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
    }
}
