using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы вывода данных текущего элемента класса <see cref="Order"/> и изменения статуса заказа.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Заказы.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                if (_customers != null)
                {
                    for (int i = 0; i < _customers.Count; i++)
                    {
                        for (int j = 0; j < _customers[i].Order.Count; j++)
                        {

                            _orders.Add(_customers[i].Order[j]);
                        }
                    }
                    OrdersDataGridView.DataSource = _orders;
                }

            }
        }

        /// <summary>
        /// Возвращает и задает выбранный заказ.
        /// </summary>
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                _selectedOrder = value;
                if (_selectedOrder != null)
                {
                    var orderType = _selectedOrder.GetType();
                    if (orderType == typeof(PriorityOrder))
                    {
                        _selectedPriorityOrder = (PriorityOrder)_selectedOrder;
                        Panel.Visible = true;
                        DeliveryTimeComboBox.Text = _selectedPriorityOrder.TimeDelivery;
                    }
                    else
                    {
                        _selectedPriorityOrder = null;
                        Panel.Visible = false;
                    }
                }
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
            AddressControl.SwitchAccessTextBox(false);
            UpdateOrders();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in statuses)
            {
                StatusComboBox.Items.Add(value);
            }
            StatusComboBox.Enabled = false;
            string[] times = new string[]{"9:00 – 11:00","11:00 – 13:00","13:00 – 15:00","15:00 – 17:00",
                "17:00 – 19:00","19:00 – 21:00" };
            foreach (string value in times)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }

            AddressControl.SwitchAccessTextBox(false);
            Panel.Visible = false;
        }

        private void OrdersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StatusComboBox.Enabled = true;
            var selectedRow = OrdersDataGridView.SelectedCells[0].RowIndex;
            SelectedOrder = _orders[selectedRow];

            IDTextBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[0].Value);
            CreatedTextBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[1].Value);
            AddressControl.Address = (Address)(OrdersDataGridView.Rows[selectedRow].Cells[2].Value);
            AmountNumberLabel.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[3].Value);
            StatusComboBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[4].Value);
            TotalNumberLabel.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[6].Value);
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = SelectedOrder.Items;
            OrderItemsListBox.DisplayMember = nameof(Name);

            if (_selectedPriorityOrder != null)
            {
                DeliveryTimeComboBox.Enabled = true;
                DeliveryTimeComboBox.Text = _selectedPriorityOrder.TimeDelivery;
            }

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex >= 0)
            {
                OrderStatus newOrderStatus = (OrderStatus)(StatusComboBox.SelectedItem);
                for (int i = 0; i < Customers.Count; i++)
                {
                    for (int j = 0; j < Customers[i].Order.Count; j++)
                    {
                        if (Customers[i].Order[j] == SelectedOrder)
                        {
                            Customers[i].Order[j].OrderStatus = newOrderStatus;
                            break;
                        }

                    }
                }
                SelectedOrder.OrderStatus = newOrderStatus;
            }

        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex >= 0)
            {
                string newDeliveryTime = Convert.ToString(DeliveryTimeComboBox.SelectedItem);
                for (int i = 0; i < Customers.Count; i++)
                {
                    for (int j = 0; j < Customers[i].Order.Count; j++)
                    {
                        if (Customers[i].Order[j] is PriorityOrder priorityOrder)
                        {
                            if (priorityOrder == _selectedPriorityOrder)
                            {

                                priorityOrder.TimeDelivery = newDeliveryTime;
                                break;
                            }
                        }

                    }
                }
                _selectedPriorityOrder.TimeDelivery = newDeliveryTime;

            }

        }

        /// <summary>
        /// Обновляет OrdersDataGridView заказами из _orders.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();
            if (Customers != null)
            {
                for (int i = 0; i < Customers.Count; i++)
                {
                    for (int j = 0; j < Customers[i].Order.Count; j++)
                    {

                        _orders.Add(Customers[i].Order[j]);
                    }
                }
                OrdersDataGridView.DataSource = _orders;
            }
        }

        /// <summary>
        /// Обновляет данные в OrdersTab.
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
            ClearBoxes();
        }

        /// <summary>
        /// Очищает все текстбоксы, комбобоксы и листбоксы 
        /// </summary>
        private void ClearBoxes()
        {
            AddressControl.SwitchAccessTextBox(false);
            AddressControl.ClearAddressTextBox();
            IDTextBox.Clear();
            CreatedTextBox.Clear();
            StatusComboBox.Text = null;
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DisplayMember = " ";
            AmountNumberLabel.Text = "0,0";
            DeliveryTimeComboBox.Text = null;
            TotalNumberLabel.Text = "0,0";
        }
    }
}
