﻿
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.QueryOrder = new System.Windows.Forms.Button();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.Notice = new System.Windows.Forms.Label();
            this.DetailsView = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.OrderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.orderBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderView
            // 
            this.OrderView.AutoGenerateColumns = false;
            this.OrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.orderIdDataGridViewTextBoxColumn, this.orderTImeDataGridViewTextBoxColumn, this.customerDataGridViewTextBoxColumn, this.totalMoneyDataGridViewTextBoxColumn});
            this.OrderView.DataSource = this.orderBindingSource;
            this.OrderView.Location = new System.Drawing.Point(12, 43);
            this.OrderView.Name = "OrderView";
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.Height = 27;
            this.OrderView.Size = new System.Drawing.Size(645, 191);
            this.OrderView.TabIndex = 0;
            this.OrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.OrderView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderView_CellDoubleClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // orderTImeDataGridViewTextBoxColumn
            // 
            this.orderTImeDataGridViewTextBoxColumn.DataPropertyName = "OrderTIme";
            this.orderTImeDataGridViewTextBoxColumn.HeaderText = "OrderTIme";
            this.orderTImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTImeDataGridViewTextBoxColumn.Name = "orderTImeDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(HomeWork5_1.Order);
            this.orderBindingSource.CurrentChanged += new System.EventHandler(this.orderBindingSource_CurrentChanged);
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
            this.CreateOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.CreateOrder.Location = new System.Drawing.Point(3, 50);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(137, 42);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "新建订单";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // QueryOrder
            // 
            this.QueryOrder.AutoSize = true;
            this.QueryOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
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
            this.UpdateOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
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
            this.DeleteOrder.Font = new System.Drawing.Font("华光综艺_CNKI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
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
            this.Notice.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.Notice.Location = new System.Drawing.Point(12, 442);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(0, 43);
            this.Notice.TabIndex = 2;
            // 
            // DetailsView
            // 
            this.DetailsView.AutoGenerateColumns = false;
            this.DetailsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.itemDataGridViewTextBoxColumn, this.itemCountsDataGridViewTextBoxColumn, this.orderDetailPriceDataGridViewTextBoxColumn, this.disCountDataGridViewTextBoxColumn});
            this.DetailsView.DataMember = "DetailsList";
            this.DetailsView.DataSource = this.orderBindingSource;
            this.DetailsView.Location = new System.Drawing.Point(12, 261);
            this.DetailsView.Name = "DetailsView";
            this.DetailsView.RowHeadersWidth = 51;
            this.DetailsView.RowTemplate.Height = 27;
            this.DetailsView.Size = new System.Drawing.Size(645, 230);
            this.DetailsView.TabIndex = 3;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // itemCountsDataGridViewTextBoxColumn
            // 
            this.itemCountsDataGridViewTextBoxColumn.DataPropertyName = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.HeaderText = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.Name = "itemCountsDataGridViewTextBoxColumn";
            // 
            // orderDetailPriceDataGridViewTextBoxColumn
            // 
            this.orderDetailPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.HeaderText = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.Name = "orderDetailPriceDataGridViewTextBoxColumn";
            this.orderDetailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disCountDataGridViewTextBoxColumn
            // 
            this.disCountDataGridViewTextBoxColumn.DataPropertyName = "DisCount";
            this.disCountDataGridViewTextBoxColumn.HeaderText = "DisCount";
            this.disCountDataGridViewTextBoxColumn.Name = "disCountDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 545);
            this.Controls.Add(this.DetailsView);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OrderView);
            this.Name = "Form1";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.OrderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.orderBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.DetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCountDataGridViewTextBoxColumn;

        #endregion
        private System.Windows.Forms.DataGridView OrderView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button QueryOrder;
        private System.Windows.Forms.Button UpdateOrder;
        private System.Windows.Forms.Button DeleteOrder;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView DetailsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
    }
}

