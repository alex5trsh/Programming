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
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задает товары.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder currentOrder = new PriorityOrder();

        public PriorityOrdersTab()
        {
            InitializeComponent();

            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var value in statuses)
            {
                StatusComboBox.Items.Add(value);
            }

            string[] times = new string[]{"9:00 – 11:00","11:00 – 13:00","13:00 – 15:00","15:00 – 17:00",
                "17:00 – 19:00","19:00 – 21:00" };
            foreach (string value in times)
            {
                DeliveryTimeComboBox.Items.Add(value);
            }

            AddressControl.SwitchAccessTextBox(false);

            currentOrder.Address = new Address(222222, "Country", "City", "Street", "Building", "Apartment");
            Item newItem = new Item("Name", "Info", 150, Category.Product);
            currentOrder.Items = new List<Item>() { newItem };
            currentOrder.Cost = 150;
            currentOrder.OrderStatus = OrderStatus.New;
            PrintOrder();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderStatus newOrderStatus = (OrderStatus)(StatusComboBox.SelectedItem);
            currentOrder.OrderStatus = newOrderStatus;
            StatusComboBox.Enabled = false;

        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex >= 0)
            {
                string newDeliveryTime = Convert.ToString(DeliveryTimeComboBox.SelectedItem);
                currentOrder.TimeDelivery = newDeliveryTime;
                DeliveryTimeComboBox.Enabled = false;
            }

        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (Items.Count != 0)
            {
                currentOrder.Items.Add(Items[new Random().Next(Items.Count)]);
                FillOrderItemsListBox();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex >= 0 && OrderItemsListBox.Items.Count != 1)
            {
                currentOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
                FillOrderItemsListBox();
                OrderItemsListBox.SelectedIndex = -1;
            }

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {

            currentOrder = new PriorityOrder();
            currentOrder.Address = new Address(222222, "Country", "City", "Street", "Building", "Apartment");
            if (Items.Count != 0)
            {
                Item newItem = Items[new Random().Next(Items.Count)];
                currentOrder.Items = new List<Item>() { newItem };
                currentOrder.Cost = newItem.Cost;
            }
            currentOrder.OrderStatus = OrderStatus.New;
            PrintOrder();
            StatusComboBox.Enabled = true;
        }

        /// <summary>
        /// Заполняет ItemsListBox значениями из Items.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = currentOrder.Items;
            OrderItemsListBox.DisplayMember = nameof(Item.Name);

            Cart Cart = new Cart(currentOrder.Items);
            AmountNumberLabel.Text = Convert.ToString(Cart.Amount);
        }

        private void PrintOrder()
        {
            StatusComboBox.Text = Convert.ToString(currentOrder.OrderStatus);
            IDTextBox.Text = Convert.ToString(currentOrder.Id);
            CreatedTextBox.Text = currentOrder.Date;
            AddressControl.Address = currentOrder.Address;
            DeliveryTimeComboBox.Text = currentOrder.TimeDelivery;
            AmountNumberLabel.Text = Convert.ToString(currentOrder.Cost);
            FillOrderItemsListBox();

            StatusComboBox.Enabled = true;
            DeliveryTimeComboBox.Enabled = true;

        }
    }
}
