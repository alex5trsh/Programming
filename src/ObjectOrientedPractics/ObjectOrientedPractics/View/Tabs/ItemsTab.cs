using ObjectOrientedPractics.Model;
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
        /// Событие на изменение, добавление, удаление элементов класса <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

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
                _displayedItems = _items;
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

        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>, которые выводятся в ItemsListBox.
        /// </summary>
        private List<Item> _displayedItems;

        public ItemsTab()
        {
            InitializeComponent();

            var categories = Enum.GetValues(typeof(Category));
            foreach (var value in categories)
            {
                CategoryComboBox.Items.Add(value);
            }

            var orders = new string[] { "Name" , "Cost(Ascending)", "Cost(Decreasing)" };
            foreach (var value in orders)
            {
                OrderByComboBox.Items.Add(value);
            }
            OrderByComboBox.SelectedIndex = 0;
            FillItemsListBox();
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentIndex = ItemsListBox.SelectedIndex;
                FillDisplayedItems();
                _currentItem= _displayedItems[_currentIndex];
                UpdateItemInfo(_currentItem);
                SwitchAccessTextBox(true);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                Item _newItem = new Item("New Name", "New Description", 1, Category.Clothes);
                _newItem.NameChanged += Item_NameChanged;
                _newItem.CostChanged += Item_CostChanged;
                _newItem.InfoChanged += Item_InfoChanged;
                Items.Add(_newItem);
                FillItemsListBox();

                for (int i = 0; i < _displayedItems.Count; i++)
                {
                    if (_displayedItems[i] == _newItem)
                    {
                        ItemsListBox.SelectedIndex = i;
                    }
                }

                SwitchAccessTextBox(true);
                SortItems();
                ItemsChanged?.Invoke(sender, EventArgs.Empty);
            }   
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox != null)
            {
                Items.Remove(_currentItem);
                _displayedItems.Remove(_currentItem);
                FillItemsListBox();
                ItemsListBox.SelectedIndex = -1;
                SwitchAccessTextBox(false);
                ClearItemsInfo();
                ItemsChanged?.Invoke(sender, EventArgs.Empty);
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
                FillDisplayedItems();
                SortItems();
                FillItemsListBox();
                ItemsListBox.SelectedIndex = _currentIndex;
                ItemsChanged?.Invoke(sender, EventArgs.Empty);
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
                FillDisplayedItems();
                SortItems();
                FillItemsListBox();
                ItemsListBox.SelectedIndex = _currentIndex;
                ItemsChanged?.Invoke(sender, EventArgs.Empty);
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
                ItemsChanged?.Invoke(sender, EventArgs.Empty);
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
                    ItemsChanged?.Invoke(sender, EventArgs.Empty);
                }
            }
            catch 
            { 

            }              
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            string newValue = FindTextBox.Text;
            Item selectedItem = _currentItem;
            FillDisplayedItems();
            FillItemsListBox();
            if (_displayedItems.Contains(selectedItem))
            {
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(selectedItem);
            }
            else
            {
                ItemsListBox.SelectedIndex = -1;
                SwitchAccessTextBox(false);
                ClearItemsInfo();
            }

        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            SortItems();

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
            ItemsListBox.DataSource = _displayedItems;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Проверяет есть ли в названии проверяемого объекта подстрока.
        /// </summary>
        /// <param name="item">Проверяемый объект.</param>
        /// <param name="name">Подстрока.</param>
        /// <returns>Возвращает true, если объект содержит подстроку. Возвращает false, если объект 
        /// не содержит подстроки.</returns>
        public static bool CompareName(Item item, object name)
        {
            return item.Name.Contains(Convert.ToString(name));
        }

        /// <summary>
        /// Заполняет _displayedItems.
        /// </summary>
        private void FillDisplayedItems()
        {
            if(FindTextBox.Text=="")
            {
                _displayedItems = Items;
            }
            else
            {
                _displayedItems = DataTools.FilterItems(Items, CompareName, FindTextBox.Text);
            }
        }

        /// <summary>
        /// Сортирует _displayedItems в зависимости от выбранного индекса в OrderByComboBox.
        /// </summary>
        private void SortItems()
        {
            if (Items != null)
            {
                Item selectedItem = _currentItem;
                FillDisplayedItems();
                if (OrderByComboBox.SelectedIndex == 0)
                {
                    DataTools.SortItems(_displayedItems, DataTools.SortByName);
                }

                if (OrderByComboBox.SelectedIndex == 1)
                {
                    DataTools.SortItems(_displayedItems, DataTools.SortByAscendingCost);
                }

                if (OrderByComboBox.SelectedIndex == 2)
                {
                    DataTools.SortItems(_displayedItems, DataTools.SortByDecreasingCost);
                }

                FillItemsListBox();
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(selectedItem);
            }

        }

        private void Item_NameChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Название товара изменено.",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
        );

        }

        private void Item_CostChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Стоимость товара изменена.",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
        );
        }

        private void Item_InfoChanged(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Информация о товаре изменена.",
        "Сообщение",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1
        );
        }
    }
}
