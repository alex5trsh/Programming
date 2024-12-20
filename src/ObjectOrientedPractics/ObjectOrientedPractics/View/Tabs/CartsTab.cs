﻿using System;
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
    /// Предоставляет методы вывода данных класса <see cref="Cart"/> текущего элемента
    /// класса <see cref="Customer"/>, добавления в него элементов класса <see cref="Item"/>, их удаления
    /// и оформления в элемент класса <see cref="Order"/>.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Событие на создание элемента класса <see cref="Order"/>.
        /// </summary>
        public event EventHandler<EventArgs> OrderChanged;

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
        /// Текущие скидки, которые применяются к корзине.
        /// </summary>
        private List<IDiscount> _currentDiscounts = new List<IDiscount>();

        /// <summary>
        /// Текущий размер примененных скидок.
        /// </summary>
        private double _amountCurrentDiscounts;

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
            ItemsListBox.Enabled = false;
        }


        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                _currenCustomertIndex = CustomerComboBox.SelectedIndex;
                CurrentCustomer =Customers[_currenCustomertIndex];
                ItemsListBox.SelectedIndex = -1;
                ItemsListBox.Enabled = true;
                _currentDiscounts.Clear();
                FillCartListBox();
                FillDiscountsCheckedListBox();
                CalculateTheDiscount();
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
                CalculateTheDiscount();
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
                CalculateTheDiscount();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count != 0 && CustomerComboBox.SelectedIndex >= 0)
            {
                List<Item> newItems = new List<Item>();
                for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
                {
                    newItems.Add(CurrentCustomer.Cart.Items[i]);

                }
                ApplyTheDiscounts();

                if (CurrentCustomer.IsPriority == true)
                {
                    PriorityOrder newOrder = new PriorityOrder();
                    newOrder.Address = CurrentCustomer.Address;
                    newOrder.Items = newItems;
                    newOrder.Cost = CurrentCustomer.Cart.Amount;
                    newOrder.OrderStatus = OrderStatus.New;
                    newOrder.DiscountAmount = _amountCurrentDiscounts;

                    Customers.Remove(CurrentCustomer);
                    CurrentCustomer.Order.Add(newOrder);
                    CurrentCustomer.Cart.Items.Clear();
                    Customers.Insert(_currenCustomertIndex, CurrentCustomer);
                }
                else
                {
                    Order newOrder = new Order(CurrentCustomer.Address, newItems,
                              CurrentCustomer.Cart.Amount, OrderStatus.New,_amountCurrentDiscounts);
                    Customers.Remove(CurrentCustomer);
                    CurrentCustomer.Order.Add(newOrder);
                    CurrentCustomer.Cart.Items.Clear();
                    Customers.Insert(_currenCustomertIndex, CurrentCustomer);
                }
                OrderChanged?.Invoke(sender, EventArgs.Empty);
                FillCartListBox();
                CustomerComboBox.SelectedIndex = -1;
                ItemsListBox.SelectedIndex = -1;
                ItemsListBox.Enabled = false;
                FillDiscountsCheckedListBox();
                
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CartListBox != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                CalculateTheDiscount();
                ItemsListBox.SelectedIndex = -1;
                FillCartListBox();
            }
        }
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentDiscounts.Count != 0)
            {
                for (int i = 1; i < CurrentCustomer.Discounts.Count; i++)
                {
                    if (DiscountsCheckedListBox.GetItemChecked(i) == false)
                    {
                        _currentDiscounts.Remove(CurrentCustomer.Discounts[i]);
                    }
                    else if (_currentDiscounts.Contains(CurrentCustomer.Discounts[i]) == false)
                    {
                        _currentDiscounts.Add(CurrentCustomer.Discounts[i]);

                    }
                }
                CalculateTheDiscount();
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
            FillDiscountsCheckedListBox();
            CustomerComboBox.Text = null;
            ItemsListBox.Enabled = false;
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

        /// <summary>
        /// Заполняет DiscountsCheckedListBox значениями из CurrentCustomer.Discounts,
        /// присваивает всем элементам из DiscountsCheckedListBox значение Checked 
        /// и заполняет _currentDiscounts.
        /// </summary>
        private void FillDiscountsCheckedListBox()
        {
            if (CustomerComboBox.SelectedIndex >= 0)
            {
                DiscountsCheckedListBox.DataSource = null;
                DiscountsCheckedListBox.DataSource = CurrentCustomer.Discounts; ;
                DiscountsCheckedListBox.DisplayMember = nameof(IDiscount.Info);
                for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
                {
                    DiscountsCheckedListBox.SetItemCheckState(i, CheckState.Checked);
                    _currentDiscounts.Add(CurrentCustomer.Discounts[i]);
                }
            }
            else
            {
                DiscountsCheckedListBox.DataSource = null;
                DiscountsCheckedListBox.DisplayMember = " ";
                DiscountAmountNumberLabel.Text = "0,0";
                TotalNumberLabel.Text = "0,0";
            }
        }

        /// <summary>
        /// Рассчитывает предварительный размер скидки.
        /// </summary>
        private void CalculateTheDiscount()
        {
            if(CurrentCustomer.Cart!=null&&CustomerComboBox.SelectedIndex>=0)
            {
                _amountCurrentDiscounts = 0;
                for(int i=0;i<_currentDiscounts.Count;i++)
                {
                    _amountCurrentDiscounts += _currentDiscounts[i].Calculate(CurrentCustomer.Cart.Items);        
                }
                DiscountAmountNumberLabel.Text = Convert.ToString(_amountCurrentDiscounts);
                TotalNumberLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount - _amountCurrentDiscounts);

            }
        }
        
        /// <summary>
        /// Рассчитывает размер скидки и обновляет баллы/проценты.
        /// </summary>
        private void ApplyTheDiscounts()
        {
            _amountCurrentDiscounts = 0;
            for(int i=0; i<CurrentCustomer.Discounts.Count;i++)
            {
                if(DiscountsCheckedListBox.GetItemChecked(i))
                {
                    _amountCurrentDiscounts += CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Cart.Items);
                }
                CurrentCustomer.Discounts[i].Update(CurrentCustomer.Cart.Items);
            }
            
        }
    }
}
