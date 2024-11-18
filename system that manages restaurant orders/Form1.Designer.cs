namespace system_that_manages_restaurant_orders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDescription = new TextBox();
            label1 = new Label();
            btnAddOrder = new Button();
            btnCompleteOrder = new Button();
            btnCancelOrder = new Button();
            lstPendingOrders = new ListBox();
            lstCancelledOrders = new ListBox();
            lstOrderHistory = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 15F);
            txtDescription.Location = new Point(74, 42);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(762, 72);
            txtDescription.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(74, 11);
            label1.Name = "label1";
            label1.Size = new Size(246, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter the order description";
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(181, 139);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(103, 39);
            btnAddOrder.TabIndex = 2;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnCompleteOrder
            // 
            btnCompleteOrder.Location = new Point(385, 139);
            btnCompleteOrder.Name = "btnCompleteOrder";
            btnCompleteOrder.Size = new Size(103, 39);
            btnCompleteOrder.TabIndex = 3;
            btnCompleteOrder.Text = "Complete Order";
            btnCompleteOrder.UseVisualStyleBackColor = true;
            btnCompleteOrder.Click += btnCompleteOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(589, 139);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(103, 39);
            btnCancelOrder.TabIndex = 4;
            btnCancelOrder.Text = "Cancel Order";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // lstPendingOrders
            // 
            lstPendingOrders.FormattingEnabled = true;
            lstPendingOrders.ItemHeight = 15;
            lstPendingOrders.Location = new Point(12, 293);
            lstPendingOrders.Name = "lstPendingOrders";
            lstPendingOrders.Size = new Size(250, 214);
            lstPendingOrders.TabIndex = 5;
            // 
            // lstCancelledOrders
            // 
            lstCancelledOrders.FormattingEnabled = true;
            lstCancelledOrders.ItemHeight = 15;
            lstCancelledOrders.Location = new Point(338, 293);
            lstCancelledOrders.Name = "lstCancelledOrders";
            lstCancelledOrders.Size = new Size(250, 214);
            lstCancelledOrders.TabIndex = 6;
            // 
            // lstOrderHistory
            // 
            lstOrderHistory.FormattingEnabled = true;
            lstOrderHistory.ItemHeight = 15;
            lstOrderHistory.Location = new Point(664, 293);
            lstOrderHistory.Name = "lstOrderHistory";
            lstOrderHistory.Size = new Size(250, 214);
            lstOrderHistory.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 257);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 8;
            label2.Text = "Pending Orders";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 263);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 9;
            label3.Text = "Cancelled Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(664, 263);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "Order History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 540);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstOrderHistory);
            Controls.Add(lstCancelledOrders);
            Controls.Add(lstPendingOrders);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnCompleteOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private Label label1;
        private Button btnAddOrder;
        private Button btnCompleteOrder;
        private Button btnCancelOrder;
        private ListBox lstPendingOrders;
        private ListBox lstCancelledOrders;
        private ListBox lstOrderHistory;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
