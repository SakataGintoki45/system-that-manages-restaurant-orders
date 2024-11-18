namespace system_that_manages_restaurant_orders
{
    public partial class Form1 : Form
    {
        private Queue<Order> pendingOrders = new Queue<Order>();
        private Stack<Order> cancelledOrders = new Stack<Order>();
        private LinkedList<Order> orderHistory = new LinkedList<Order>();
        private int orderIdCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a valid order description.");
                return;
            }

            Order newOrder = new Order
            {
                Id = orderIdCounter++,
                Description = description
            };

            pendingOrders.Enqueue(newOrder);

            txtDescription.Clear();
            UpdateUI();
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (pendingOrders.Count == 0)
            {
                MessageBox.Show("No orders to complete.");
                return;
            }

            Order completedOrder = pendingOrders.Dequeue();
            orderHistory.AddLast(completedOrder);

            UpdateUI();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (pendingOrders.Count == 0)
            {
                MessageBox.Show("No orders to cancel.");
                return;
            }

            Order cancelledOrder = pendingOrders.Dequeue();
            cancelledOrders.Push(cancelledOrder);

            UpdateUI();
        }

        private void UpdateUI()
        {
            lstPendingOrders.Items.Clear();
            lstCancelledOrders.Items.Clear();
            lstOrderHistory.Items.Clear();

            foreach (Order order in pendingOrders)
                lstPendingOrders.Items.Add(order);

            foreach (Order order in cancelledOrders)
                lstCancelledOrders.Items.Add(order);

            foreach (Order order in orderHistory)
                lstOrderHistory.Items.Add(order);
        }
    }
}
