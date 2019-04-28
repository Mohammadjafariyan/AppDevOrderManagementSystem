using System;

namespace AppDevOrderManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevliverDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "درخواست جدید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.OrderDate,
            this.DeliverDate,
            this.DevliverDate,
            this.Delivered,
            this.Cost,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(848, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Rows.Add("1", "سایت فروشگاهی", "1397/12/21", "سایت","", "خیر", "3,500,000",  "ویرایش");

            //  this.dataGridView1.Rows.Add("1", "سایت فروشگاهی", "1397/12/21", "", "خیر", "3,500,000", "", "ویرایش");

            // 
            // Id
            // 
            this.Id.HeaderText = "کد";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Name
            // 
            this.Name.HeaderText = "عنوان سفارش";
            this.Name.Name = "Name";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "تاریخ درخواست";
            this.OrderDate.Name = "OrderDate";
            // 
            // DeliverDate
            // 
            this.DeliverDate.HeaderText = "نوع";
            this.DeliverDate.Name = "DeliverDate";
            // 
            // DevliverDate
            // 
            this.DevliverDate.HeaderText = "تاریخ تحویل";
            this.DevliverDate.Name = "DevliverDate";
            // 
            // Delivered
            // 
            this.Delivered.HeaderText = "تحویل داده شده";
            this.Delivered.Name = "Delivered";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "مبلغ";
            this.Cost.Name = "Cost";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "ویرایش";
            this.Edit.Name = "Edit";
            this.Edit.Text = "ویرایش";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 317);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void addFakeDateToGridView()
        {
       //     this.dataGridView1.Rows.Add("1", "", "", "", "", "", "",new System.Windows.Forms.Button());
        }
     
        #endregion
         
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevliverDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
    }
  
}

