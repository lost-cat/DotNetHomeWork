
namespace HomeWork8_1
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
            this.OrderBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.QueryOrder = new System.Windows.Forms.Button();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.Notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderBindSource
            // 
            this.OrderBindSource.DataMember = "DetailsList";
            this.OrderBindSource.DataSource = typeof(HomeWork5_1.Order);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.itemCountsDataGridViewTextBoxColumn,
            this.orderDetailPriceDataGridViewTextBoxColumn,
            this.disCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.OrderBindSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(671, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // itemCountsDataGridViewTextBoxColumn
            // 
            this.itemCountsDataGridViewTextBoxColumn.DataPropertyName = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.HeaderText = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCountsDataGridViewTextBoxColumn.Name = "itemCountsDataGridViewTextBoxColumn";
            // 
            // orderDetailPriceDataGridViewTextBoxColumn
            // 
            this.orderDetailPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.HeaderText = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDetailPriceDataGridViewTextBoxColumn.Name = "orderDetailPriceDataGridViewTextBoxColumn";
            this.orderDetailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disCountDataGridViewTextBoxColumn
            // 
            this.disCountDataGridViewTextBoxColumn.DataPropertyName = "DisCount";
            this.disCountDataGridViewTextBoxColumn.HeaderText = "DisCount";
            this.disCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.disCountDataGridViewTextBoxColumn.Name = "disCountDataGridViewTextBoxColumn";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CreateOrder);
            this.flowLayoutPanel1.Controls.Add(this.QueryOrder);
            this.flowLayoutPanel1.Controls.Add(this.UpdateOrder);
            this.flowLayoutPanel1.Controls.Add(this.DeleteOrder);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(736, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 423);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CreateOrder
            // 
            this.CreateOrder.AutoSize = true;
            this.CreateOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreateOrder.Location = new System.Drawing.Point(3, 50);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(137, 42);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "新建订单";
            this.CreateOrder.UseVisualStyleBackColor = true;
            // 
            // QueryOrder
            // 
            this.QueryOrder.AutoSize = true;
            this.QueryOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryOrder.Location = new System.Drawing.Point(3, 145);
            this.QueryOrder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.QueryOrder.Name = "QueryOrder";
            this.QueryOrder.Size = new System.Drawing.Size(137, 42);
            this.QueryOrder.TabIndex = 1;
            this.QueryOrder.Text = "查询订单";
            this.QueryOrder.UseVisualStyleBackColor = true;
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.AutoSize = true;
            this.UpdateOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdateOrder.Location = new System.Drawing.Point(3, 240);
            this.UpdateOrder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(137, 42);
            this.UpdateOrder.TabIndex = 2;
            this.UpdateOrder.Text = "修改订单";
            this.UpdateOrder.UseVisualStyleBackColor = true;
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.AutoSize = true;
            this.DeleteOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteOrder.Location = new System.Drawing.Point(3, 335);
            this.DeleteOrder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(137, 42);
            this.DeleteOrder.TabIndex = 3;
            this.DeleteOrder.Text = "删除订单";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Notice.Location = new System.Drawing.Point(12, 442);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(0, 44);
            this.Notice.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 495);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource OrderBindSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button QueryOrder;
        private System.Windows.Forms.Button UpdateOrder;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Label Notice;
    }
}

