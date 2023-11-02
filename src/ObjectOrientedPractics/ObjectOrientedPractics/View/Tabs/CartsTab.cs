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
    /// Предоставляет методы вывода данных класса <see cref="Cart"/> текущего элемента
    /// класса <see cref="Customer"/>, добавления в него элементов класса <see cref="Item"/>, их удаления
    /// и оформления в элемент класса <see cref="Order"/>.
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
        /// Текущий индекс покупателя.
        /// </summary>
        private int _currenCustomertIndex;

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Текущий индекс товара.
        /// </summary>
        private int _currentItemIndex;

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
        private Customer CurrentCustomer { get; set; }

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

            SwitchVisibleButtons(false);
        }


        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                _currenCustomertIndex = CustomerComboBox.SelectedIndex;
                CurrentCustomer =Customers[_currenCustomertIndex];
                ItemsListBox.SelectedIndex = -1;
                FillCartListBox();
                SwitchVisibleButtons(true);
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex>=0 & CustomerComboBox.SelectedIndex>=0)
            {
                _currentItemIndex = ItemsListBox.SelectedIndex;
                _currentItem = Items[_currentItemIndex];
                CurrentCustomer.Cart.Items.Add(_currentItem);
                FillCartListBox();
            }
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex >= 0 && CartListBox.Items.Count>1)
            {
                _currentItemIndex = ItemsListBox.SelectedIndex;
                CurrentCustomer.Cart.Items.RemoveAt(_currenCustomertIndex);
                ItemsListBox.SelectedIndex = -1;
                FillCartListBox();               
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox != null)
            {
                Order newOrder = new Order();
                newOrder.Items = CurrentCustomer.Cart.Items;
                newOrder.Address = CurrentCustomer.Address;
                newOrder.Cost = CurrentCustomer.Cart.Amount;
                newOrder.OrderStatus = OrderStatus.New;
                CurrentCustomer.Order.Add(newOrder);
                CurrentCustomer.Cart.Items.Clear();
                ItemsListBox.SelectedIndex = -1;
                FillCartListBox();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CartListBox != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                ItemsListBox.SelectedIndex = -1;
                FillCartListBox();
            }
        }

        /// <summary>
        /// Заполняет ItemsListBox значениями из Items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = nameof(Name);
        }

        /// <summary>
        /// Заполняет CartListBox значениями из CurrentCustomer.Cart.Items 
        /// и выводит конечную цену в AmountNumberLabel.
        /// </summary>
        private void FillCartListBox()
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                CartListBox.DataSource = null;
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = nameof(Name);
                AmountNumberLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount);
            }
            else
            {
                CartListBox.DataSource = null;
                CartListBox.DisplayMember=" ";
                AmountNumberLabel.Text = "0,0";
            }
        }

        /// <summary>
        /// Обновляет данные в CartsTab.
        /// </summary>
        public void RefreshData()
        {
            FillItemsListBox();
            CustomerComboBox.Items.Clear();
            foreach (var value in Customers)
            {
                CustomerComboBox.Items.Add(value.FullName);
            }
            UpdateCartListBox();
            CustomerComboBox.Text = null;

        }

        /// <summary>
        /// Обновляет информацию о товарах из корзины.
        /// </summary>
        private void UpdateCartListBox()
        {
            if(Customers.Count!=0)
            {
                for(int i=0; i<Customers.Count;i++)
                {
                    for (int j = 0; j < Customers[i].Cart.Items.Count; j++)
                    {
                        string nameItem = Customers[i].Cart.Items[j].Name;
                        Category categoryItem = Customers[i].Cart.Items[j].Category;
                        string infoItem = Customers[i].Cart.Items[j].Info;
                        double costItem = Customers[i].Cart.Items[j].Cost;
                        bool isItemExist = false;
                        for (int k = 0; k < Items.Count; k++)
                        {
                            if (Items[k].Name == nameItem && Items[k].Category == categoryItem
                              && Items[k].Info == infoItem && Items[k].Cost == costItem)
                            {
                                isItemExist = true;
                                break;
                            }
                            else
                            {
                                if (Items[k].Name == nameItem && Items[k].Category == categoryItem)
                                {
                                    Customers[i].Cart.Items.RemoveAt(j);
                                    Customers[i].Cart.Items.Insert(j, Items[k]);
                                    isItemExist = true;
                                    break;
                                }
                            }
                        }
                        if (isItemExist == false)
                        {
                            Customers[i].Cart.Items.RemoveAt(j);
                        }

                    }
                }
            }
            FillCartListBox();
        }

        /// <summary>
        /// Задает свойство видимости для кнопок.
        /// </summary>
        /// <param name="flag">Значение свойства видимости. Равно true или false.</param>
        private void SwitchVisibleButtons(bool flag)
        {
            AddToCartButton.Visible = flag;
            ClearCartButton.Visible = flag;
            RemoveItemButton.Visible = flag;
            CreateOrderButton.Visible = flag;
        }


    }
}
