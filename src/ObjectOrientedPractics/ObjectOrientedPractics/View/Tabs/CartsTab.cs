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
    /// 
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает товары.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                FillItemsListBox();
            }
        }

        /// <summary>
        /// Возвращает и задает покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Возвращает и задает текущего покупателя.
        /// </summary>
        private Customer PrivateCustomer { get; set; }

        public CartsTab()
        {

            InitializeComponent();
            if (Customers != null)
            {
                foreach (var value in Customers)
                {
                    CustomerComboBox.Items.Add(value.FullName);
                }
            }
        }

        

        /// <summary>
        /// Заполняет ItemsListBox значениями из _items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
