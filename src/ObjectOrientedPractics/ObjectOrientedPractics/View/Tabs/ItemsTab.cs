﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы вывода данных текущего элемента класса <see cref="Item"/>,
    /// его изменения, удаления, добавления.
    /// </summary>
    public partial class ItemsTab : UserControl
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
                FillItemsListBox();
            }
        }

        /// <summary>
        /// Текущий элемент класса <see cref="Item"/>.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Индекс текущего элемента.
        /// </summary>
        private int _currentIndex;

        public ItemsTab()
        {
            InitializeComponent();

            var categories = Enum.GetValues(typeof(Category));
            foreach (var value in categories)
            {
                CategoryComboBox.Items.Add(value);
            }
            FillItemsListBox();
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentIndex = ItemsListBox.SelectedIndex;
                _currentItem = Items[_currentIndex];

                UpdateItemInfo(_currentItem);
                SwitchAccessTextBox(true);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item _newItem = new Item("New Name", "New Description", 1, Category.Clothes);
            Items.Add(_newItem);
            FillItemsListBox();

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] == _newItem)
                {
                    ItemsListBox.SelectedIndex = i;
                }
            }

            SwitchAccessTextBox(true);     
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox != null)
            {
                Items.RemoveAt(_currentIndex);
                FillItemsListBox();
                ItemsListBox.SelectedIndex = -1;
                SwitchAccessTextBox(false);
                ClearItemsInfo(); 
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newCost = Convert.ToDouble(CostTextBox.Text);
                if (_currentItem.Cost != newCost)
                {
                    _currentItem.Cost = newCost;
                }

                CostTextBox.BackColor = Color.White;
                NameTextBox.Enabled = true;
                InfoTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
                ItemsListBox.Enabled = true;
                SwitchVisibleButtons(true);
            }
            catch
            {
                if (CostTextBox.Enabled)
                {
                    CostTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameTextBox.Enabled = false;
                    InfoTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
                    ItemsListBox.Enabled = false;
                    SwitchVisibleButtons(false);
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newName = NameTextBox.Text;
                if (_currentItem.Name != newName)
                {
                    _currentItem.Name = newName;
                }

                NameTextBox.BackColor = Color.White;
                CostTextBox.Enabled = true;
                InfoTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
                ItemsListBox.Enabled = true;
                SwitchVisibleButtons(true);
                FillItemsListBox();
            }
            catch
            {
                if (NameTextBox.Enabled)
                {
                    NameTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    CostTextBox.Enabled = false;
                    InfoTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
                    ItemsListBox.Enabled = false;
                    SwitchVisibleButtons(false);
                }
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newInfo = InfoTextBox.Text;
                if (_currentItem.Info != newInfo)
                {
                    _currentItem.Info = newInfo;
                }

                InfoTextBox.BackColor = Color.White;
                NameTextBox.Enabled = true;
                CostTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
                ItemsListBox.Enabled = true;
                SwitchVisibleButtons(true);
            }
            catch
            {
                if (InfoTextBox.Enabled)
                {
                    InfoTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameTextBox.Enabled = false;
                    CostTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
                    ItemsListBox.Enabled = false;
                    SwitchVisibleButtons(false);
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Category newCategory = (Category)Enum.Parse(typeof(Category),
                            CategoryComboBox.Text);
                if (_currentItem.Category != newCategory)
                {
                    _currentItem.Category = newCategory;
                }
            }
            catch 
            { 

            }              
        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="item">Название объекта, данные которого необходимо обновить.</param>
        private void UpdateItemInfo(Item item)
        {
            IdTextBox.Text = Convert.ToString(item.Id);
            CostTextBox.Text = Convert.ToString(item.Cost);
            NameTextBox.Text =item.Name;
            InfoTextBox.Text =item.Info;
            CategoryComboBox.Text = Convert.ToString(item.Category);
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями объекта.
        /// </summary>
        private void ClearItemsInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CategoryComboBox.Text = null;
        }

        /// <summary>
        /// Задает свойство доступа для текстбоков.
        /// </summary>
        /// <param name="flag">Значение свойства доступа. Равно true или false.</param>
        private void SwitchAccessTextBox(bool flag)
        {
            CostTextBox.Enabled = flag;
            NameTextBox.Enabled = flag;
            InfoTextBox.Enabled = flag;
            CategoryComboBox.Enabled = flag;
        }

        /// <summary>
        /// Задает свойство видимости для кнопок.
        /// </summary>
        /// <param name="flag">Значение свойства видимости. Равно true или false.</param>
        private void SwitchVisibleButtons(bool flag)
        {
            AddButton.Visible = flag;
            RemoveButton.Visible = flag;
        }

        /// <summary>
        /// Заполняет ItemsListBox значениями из Items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }
    }
}
