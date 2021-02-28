using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class Form1
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
            this.answer = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.data2 = new System.Windows.Forms.TextBox();
            this.data1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.answer.Location = new System.Drawing.Point(135, 162);
            this.answer.Name = "answer";
            this.answer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.answer.Size = new System.Drawing.Size(354, 55);
            this.answer.TabIndex = 11;
            this.answer.Text = "0";
            this.answer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(135, 497);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(99, 55);
            this.divide.TabIndex = 12;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(12, 497);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(99, 55);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(135, 415);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(99, 55);
            this.minus.TabIndex = 14;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 415);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(99, 55);
            this.add.TabIndex = 15;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(12, 605);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(354, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "数据2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(12, 566);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(354, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "数据1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.calculate.Location = new System.Drawing.Point(393, 477);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(96, 215);
            this.calculate.TabIndex = 18;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // data2
            // 
            this.data2.Location = new System.Drawing.Point(12, 663);
            this.data2.Name = "data2";
            this.data2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data2.Size = new System.Drawing.Size(354, 25);
            this.data2.TabIndex = 19;
            // 
            // data1
            // 
            this.data1.Location = new System.Drawing.Point(12, 602);
            this.data1.Name = "data1";
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data1.Size = new System.Drawing.Size(354, 25);
            this.data1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 705);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.data2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.answer);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox data1;
        private System.Windows.Forms.TextBox data2;

        private System.Windows.Forms.Button calculate;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;


        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button add;

        private System.Windows.Forms.Label answer;

        #endregion
    }
}