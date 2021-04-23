namespace HomeWork8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsGridView3 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderGridView4 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddOrderbutton = new System.Windows.Forms.Button();
            this.DeleteOrderbutton = new System.Windows.Forms.Button();
            this.ModifyOrderbutton1 = new System.Windows.Forms.Button();
            this.OutputOrderbutton1 = new System.Windows.Forms.Button();
            this.InputOrderbutton1 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.selectProperty = new System.Windows.Forms.ComboBox();
            this.findingBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(HomeWork5.OrderDetails);
            this.orderDetailsBindingSource.CurrentChanged += new System.EventHandler(this.orderDetailsBindingSource_CurrentChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(HomeWork5.Client);
            this.clientBindingSource.CurrentChanged += new System.EventHandler(this.clientBindingSource_CurrentChanged);
            // 
            // ClientGridView2
            // 
            this.ClientGridView2.AutoGenerateColumns = false;
            this.ClientGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.ClientGridView2.DataSource = this.clientBindingSource;
            this.ClientGridView2.Location = new System.Drawing.Point(34, 218);
            this.ClientGridView2.Name = "ClientGridView2";
            this.ClientGridView2.RowHeadersWidth = 82;
            this.ClientGridView2.RowTemplate.Height = 37;
            this.ClientGridView2.Size = new System.Drawing.Size(1645, 150);
            this.ClientGridView2.TabIndex = 1;
            this.ClientGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView2_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // GoodsGridView3
            // 
            this.GoodsGridView3.AutoGenerateColumns = false;
            this.GoodsGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.GoodsGridView3.DataSource = this.goodsBindingSource;
            this.GoodsGridView3.Location = new System.Drawing.Point(34, 510);
            this.GoodsGridView3.Name = "GoodsGridView3";
            this.GoodsGridView3.RowHeadersWidth = 82;
            this.GoodsGridView3.RowTemplate.Height = 37;
            this.GoodsGridView3.Size = new System.Drawing.Size(1645, 150);
            this.GoodsGridView3.TabIndex = 2;
            this.GoodsGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsGridView3_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(HomeWork5.Goods);
            this.goodsBindingSource.CurrentChanged += new System.EventHandler(this.goodsBindingSource_CurrentChanged);
            // 
            // OrderGridView4
            // 
            this.OrderGridView4.AutoGenerateColumns = false;
            this.OrderGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn});
            this.OrderGridView4.DataSource = this.orderBindingSource;
            this.OrderGridView4.Location = new System.Drawing.Point(34, 364);
            this.OrderGridView4.Name = "OrderGridView4";
            this.OrderGridView4.RowHeadersWidth = 82;
            this.OrderGridView4.RowTemplate.Height = 37;
            this.OrderGridView4.Size = new System.Drawing.Size(1645, 150);
            this.OrderGridView4.TabIndex = 3;
            this.OrderGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridView4_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(HomeWork5.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
            // 
            // AddOrderbutton
            // 
            this.AddOrderbutton.Location = new System.Drawing.Point(52, 127);
            this.AddOrderbutton.Name = "AddOrderbutton";
            this.AddOrderbutton.Size = new System.Drawing.Size(179, 53);
            this.AddOrderbutton.TabIndex = 4;
            this.AddOrderbutton.Text = "创建订单";
            this.AddOrderbutton.UseVisualStyleBackColor = true;
            this.AddOrderbutton.Click += new System.EventHandler(this.AddOrderbutton_Click);
            // 
            // DeleteOrderbutton
            // 
            this.DeleteOrderbutton.Location = new System.Drawing.Point(422, 127);
            this.DeleteOrderbutton.Name = "DeleteOrderbutton";
            this.DeleteOrderbutton.Size = new System.Drawing.Size(179, 53);
            this.DeleteOrderbutton.TabIndex = 5;
            this.DeleteOrderbutton.Text = "删除订单";
            this.DeleteOrderbutton.UseVisualStyleBackColor = true;
            this.DeleteOrderbutton.Click += new System.EventHandler(this.DeleteOrderbutton_Click);
            // 
            // ModifyOrderbutton1
            // 
            this.ModifyOrderbutton1.Location = new System.Drawing.Point(237, 127);
            this.ModifyOrderbutton1.Name = "ModifyOrderbutton1";
            this.ModifyOrderbutton1.Size = new System.Drawing.Size(179, 53);
            this.ModifyOrderbutton1.TabIndex = 6;
            this.ModifyOrderbutton1.Text = "修改订单";
            this.ModifyOrderbutton1.UseVisualStyleBackColor = true;
            this.ModifyOrderbutton1.Click += new System.EventHandler(this.ModifyOrderbutton1_Click);
            // 
            // OutputOrderbutton1
            // 
            this.OutputOrderbutton1.Location = new System.Drawing.Point(607, 127);
            this.OutputOrderbutton1.Name = "OutputOrderbutton1";
            this.OutputOrderbutton1.Size = new System.Drawing.Size(179, 53);
            this.OutputOrderbutton1.TabIndex = 8;
            this.OutputOrderbutton1.Text = "导出订单";
            this.OutputOrderbutton1.UseVisualStyleBackColor = true;
            this.OutputOrderbutton1.Click += new System.EventHandler(this.OutputOrderbutton1_Click);
            // 
            // InputOrderbutton1
            // 
            this.InputOrderbutton1.Location = new System.Drawing.Point(792, 127);
            this.InputOrderbutton1.Name = "InputOrderbutton1";
            this.InputOrderbutton1.Size = new System.Drawing.Size(179, 53);
            this.InputOrderbutton1.TabIndex = 9;
            this.InputOrderbutton1.Text = "导入订单";
            this.InputOrderbutton1.UseVisualStyleBackColor = true;
            this.InputOrderbutton1.Click += new System.EventHandler(this.InputOrderbutton1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(656, 34);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(179, 53);
            this.search.TabIndex = 14;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // selectProperty
            // 
            this.selectProperty.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.selectProperty.FormattingEnabled = true;
            this.selectProperty.Items.AddRange(new object[] {
            "client",
            "goods",
            "address",
            "phone",
            "total"});
            this.selectProperty.Location = new System.Drawing.Point(52, 34);
            this.selectProperty.Name = "selectProperty";
            this.selectProperty.Size = new System.Drawing.Size(157, 45);
            this.selectProperty.TabIndex = 16;
            this.selectProperty.SelectedIndexChanged += new System.EventHandler(this.selectProperty_SelectedIndexChanged);
            // 
            // findingBox
            // 
            this.findingBox.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findingBox.Location = new System.Drawing.Point(237, 34);
            this.findingBox.Name = "findingBox";
            this.findingBox.Size = new System.Drawing.Size(392, 50);
            this.findingBox.TabIndex = 17;
            this.findingBox.TextChanged += new System.EventHandler(this.findingBox_TextChanged);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(HomeWork5.Client);
            // 
            // orderDetailGridView1
            // 
            this.orderDetailGridView1.AutoGenerateColumns = false;
            this.orderDetailGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderDetailGridView1.DataSource = this.orderDetailsBindingSource;
            this.orderDetailGridView1.Location = new System.Drawing.Point(34, 657);
            this.orderDetailGridView1.Name = "orderDetailGridView1";
            this.orderDetailGridView1.RowHeadersWidth = 82;
            this.orderDetailGridView1.RowTemplate.Height = 30;
            this.orderDetailGridView1.Size = new System.Drawing.Size(1645, 171);
            this.orderDetailGridView1.TabIndex = 18;
            this.orderDetailGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDetailGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn1.HeaderText = "Goods";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 988);
            this.Controls.Add(this.orderDetailGridView1);
            this.Controls.Add(this.findingBox);
            this.Controls.Add(this.selectProperty);
            this.Controls.Add(this.search);
            this.Controls.Add(this.InputOrderbutton1);
            this.Controls.Add(this.OutputOrderbutton1);
            this.Controls.Add(this.ModifyOrderbutton1);
            this.Controls.Add(this.DeleteOrderbutton);
            this.Controls.Add(this.AddOrderbutton);
            this.Controls.Add(this.OrderGridView4);
            this.Controls.Add(this.GoodsGridView3);
            this.Controls.Add(this.ClientGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView ClientGridView2;
        private System.Windows.Forms.DataGridView GoodsGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.DataGridView OrderGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button AddOrderbutton;
        private System.Windows.Forms.Button DeleteOrderbutton;
        private System.Windows.Forms.Button ModifyOrderbutton1;
        private System.Windows.Forms.Button OutputOrderbutton1;
        private System.Windows.Forms.Button InputOrderbutton1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox selectProperty;
        private System.Windows.Forms.TextBox findingBox;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridView orderDetailGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

