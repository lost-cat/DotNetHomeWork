using System.ComponentModel;
using HomeWork5_1.entities;

namespace HomeWork8_1
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDetail1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCount1 = new System.Windows.Forms.NumericUpDown();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.detailView = new System.Windows.Forms.DataGridView();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "顾客姓名";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Location = new System.Drawing.Point(140, 9);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(117, 25);
            this.TextBoxCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "配送地址";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(140, 67);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(117, 25);
            this.textBoxAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "明细表";
            // 
            // comboBoxDetail1
            // 
            this.comboBoxDetail1.FormattingEnabled = true;
            this.comboBoxDetail1.Location = new System.Drawing.Point(17, 180);
            this.comboBoxDetail1.Name = "comboBoxDetail1";
            this.comboBoxDetail1.Size = new System.Drawing.Size(81, 23);
            this.comboBoxDetail1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "商品名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(137, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "数量";
            // 
            // numericUpDownCount1
            // 
            this.numericUpDownCount1.Location = new System.Drawing.Point(137, 178);
            this.numericUpDownCount1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount1.Name = "numericUpDownCount1";
            this.numericUpDownCount1.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownCount1.TabIndex = 8;
            this.numericUpDownCount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.AutoSize = true;
            this.ButtonSubmit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSubmit.Location = new System.Drawing.Point(20, 486);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(89, 38);
            this.ButtonSubmit.TabIndex = 13;
            this.ButtonSubmit.Text = "提交";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(140, 486);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 38);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // detailView
            // 
            this.detailView.AutoGenerateColumns = false;
            this.detailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.itemCountsDataGridViewTextBoxColumn,
            this.orderDetailPriceDataGridViewTextBoxColumn,
            this.disCountDataGridViewTextBoxColumn});
            this.detailView.DataSource = this.orderDetailsBindingSource;
            this.detailView.Location = new System.Drawing.Point(12, 234);
            this.detailView.Name = "detailView";
            this.detailView.RowHeadersWidth = 51;
            this.detailView.RowTemplate.Height = 27;
            this.detailView.Size = new System.Drawing.Size(550, 220);
            this.detailView.TabIndex = 15;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(OrderDetails);
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemCountsDataGridViewTextBoxColumn
            // 
            this.itemCountsDataGridViewTextBoxColumn.DataPropertyName = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.HeaderText = "ItemCounts";
            this.itemCountsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCountsDataGridViewTextBoxColumn.Name = "itemCountsDataGridViewTextBoxColumn";
            this.itemCountsDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailPriceDataGridViewTextBoxColumn
            // 
            this.orderDetailPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.HeaderText = "OrderDetailPrice";
            this.orderDetailPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDetailPriceDataGridViewTextBoxColumn.Name = "orderDetailPriceDataGridViewTextBoxColumn";
            this.orderDetailPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDetailPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // disCountDataGridViewTextBoxColumn
            // 
            this.disCountDataGridViewTextBoxColumn.DataPropertyName = "DisCount";
            this.disCountDataGridViewTextBoxColumn.HeaderText = "DisCount";
            this.disCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.disCountDataGridViewTextBoxColumn.Name = "disCountDataGridViewTextBoxColumn";
            this.disCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.AutoSize = true;
            this.buttonAddDetail.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddDetail.Location = new System.Drawing.Point(356, 174);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(99, 29);
            this.buttonAddDetail.TabIndex = 16;
            this.buttonAddDetail.Text = "添加明细";
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            this.buttonAddDetail.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 567);
            this.Controls.Add(this.buttonAddDetail);
            this.Controls.Add(this.detailView);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.numericUpDownCount1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDetail1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "新建订单";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDetail1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCount1;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView detailView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.Button buttonAddDetail;
    }
}