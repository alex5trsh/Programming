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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы вывода даных текущего элемента, его изменения, удаления, добавления.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий элемент класса <see cref="Item"/>.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Индекс текущего элемента.
        /// </summary>
        private int _currentIndex;

        /// <summary>
        /// Путь к файлу <see cref="_fileName"/>.
        /// </summary>
        private string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.
            ApplicationData) + "\\AppItems";

        /// <summary>
        /// Файл, хранящий объекты класса <see cref="Item"/>.
        /// </summary>
        private string _fileName = "Items.json";

        public ItemsTab()
        {
            InitializeComponent();

            _items = ProjectSerializer.LoadFromFile(_directoryPath, _fileName);
            FillItemsListBox();
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentIndex = ItemsListBox.SelectedIndex;
                _currentItem = _items[_currentIndex];

                UpdateItemInfo(_currentItem);
                SwitchAccessTextBox(true);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item _newItem = new Item("New Name", "New Description", 1);
            _items.Add(_newItem);
            FillItemsListBox();

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i] == _newItem)
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
                ItemsListBox.Items.RemoveAt(_currentIndex);
                _items.RemoveAt(_currentIndex);
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
                    ItemsListBox.Enabled = false;
                    SwitchVisibleButtons(false);
                }
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
        /// Заполняет ItemsListBox значениями из _items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Сохраняет все изменения при закрытии программы.
        /// </summary>
        public  void SaveAllChanges()
        {
            ProjectSerializer.SaveToFile(_items, _directoryPath, _fileName);
        }
    }
}
