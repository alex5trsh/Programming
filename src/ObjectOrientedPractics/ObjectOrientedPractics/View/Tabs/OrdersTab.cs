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
        private BindingList<Order> _orders=new BindingList<Order>();

        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает покупателей.
        /// </summary>
        public List<Customer> Customers { 
            get => _customers;
            set
            {
                _customers = value;
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
        }

        private void OrdersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StatusComboBox.Enabled = true;
            var selectedRow = OrdersDataGridView.SelectedCells[0].RowIndex;
            IDTextBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[0].Value);
            CreatedTextBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[1].Value);
            AddressControl.Address = (Address)(OrdersDataGridView.Rows[selectedRow].Cells[2].Value);
            AmountNumberLabel.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[3].Value);
            StatusComboBox.Text = Convert.ToString(OrdersDataGridView.Rows[selectedRow].Cells[4].Value);
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = _orders[selectedRow].Items;
            OrderItemsListBox.DisplayMember = nameof(Name);

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex >= 0)
            {
                var selectedRow = OrdersDataGridView.SelectedCells[0].RowIndex;
                OrderStatus newOrderStatus = (OrderStatus)(StatusComboBox.SelectedItem);
                for (int i = 0; i < Customers.Count; i++)
                {
                    for (int j = 0; j < Customers[i].Order.Count; j++)
                    {
                        if (Customers[i].Order[j] == _orders[selectedRow])
                        {
                            Customers[i].Order[j].OrderStatus = newOrderStatus;
                            break;
                        }

                    }
                }
                _orders[selectedRow].OrderStatus = newOrderStatus;
                StatusComboBox.Enabled = false;
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
        }  
    }
}
