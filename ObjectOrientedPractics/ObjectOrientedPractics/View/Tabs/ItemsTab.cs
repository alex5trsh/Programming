using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий элемент класса <see cref="Item"/>.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Индекс текущего элемента.
        /// </summary>
        private int _currentIndex;

        /// <summary>
        /// Копия текущего элемента класса <see cref="Place"/>.
        /// </summary>
        private Item _copyItem = new Item();

        /// <summary>
        /// Флаг нажатия на кнопку <see cref="AddButton"/>.
        /// True если кнопка нажата, false если не нажата.
        /// </summary>
        private bool _isButtonClicked = false;

        public ItemsTab()
        {
            InitializeComponent();

            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentIndex = ItemsListBox.SelectedIndex;
                _currentItem = _items[_currentIndex];
                //TODO:изменять счетчик
                //_copyItem.Id = _currentItem.Id;
                _copyItem.Cost = _currentItem.Cost;
                _copyItem.Name = _currentItem.Name;
                _copyItem.Info = _currentItem.Info;

                UpdateItemInfo(_copyItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            IdTextBox.Text = "0";
            CostTextBox.Text = "0";
            NameTextBox.Text = "New Name";
            InfoTextBox.Text = "New Description";
            _currentIndex = -1;

            SwitchAccessTextBox(true);
            SwitchVisibleButtons(false);
            _isButtonClicked = true;
            ApplyButton.Visible = true;
            CancelButton.Visible = true;
            ItemsListBox.Enabled = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0 && ItemsListBox != null)
            {
                ItemsListBox.Items.RemoveAt(_currentIndex);
                _items.RemoveAt(_currentIndex);
                ClearItemsInfo();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Item _changedItem = _copyItem.Clone();
            if (_currentIndex == -1)
            {
                _items.Add(_changedItem);
                ItemsListBox.Items.Add(_changedItem);
            }

            if (_currentIndex >= 0 && _changedItem != _currentItem)
            {
                _items[_currentIndex] = _changedItem;
                //ItemsListBox.Items[_currentIndex] = ToString(_copyItem);
                ItemsListBox.Items[_currentIndex] = _changedItem;
            }

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i] == _changedItem)
                {
                    ItemsListBox.SelectedIndex = i;
                }
            }

            _isButtonClicked = false;
            ItemsListBox.Enabled = true;
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _isButtonClicked = false;
            ItemsListBox.Enabled = true;
            SwitchVisibleButtons(true);
            SwitchAccessTextBox(false);
            ClearItemsInfo();
            ItemsListBox.SelectedIndex = -1;
            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            InfoTextBox.BackColor = Color.White;
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count != 0 && ItemsListBox.SelectedIndex >= 0)
            {
                _isButtonClicked = true;
                ItemsListBox.Enabled = false;
                SwitchAccessTextBox(true);
                SwitchVisibleButtons(false);
            }

        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newCost = Convert.ToDouble(CostTextBox.Text);
                if (_copyItem.Cost != newCost)
                {
                    _copyItem.Cost = newCost;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    NameTextBox.Enabled = true;
                    InfoTextBox.Enabled = true;
                }

                CostTextBox.BackColor = Color.White;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (CostTextBox.Enabled)
                {
                    CostTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameTextBox.Enabled = false;
                    InfoTextBox.Enabled = false;
                }
            }

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newName = NameTextBox.Text;
                if (_copyItem.Name != newName)
                {
                    _copyItem.Name = newName;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    CostTextBox.Enabled = true;
                    InfoTextBox.Enabled = true;
                }

                NameTextBox.BackColor = Color.White;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (NameTextBox.Enabled)
                {
                    NameTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    CostTextBox.Enabled = false;
                    InfoTextBox.Enabled = false;
                }
            }

        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newInfo = InfoTextBox.Text;
                if (_copyItem.Info != newInfo)
                {
                    _copyItem.Info = newInfo;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    NameTextBox.Enabled = true;
                    CostTextBox.Enabled = true;
                    
                }

                InfoTextBox.BackColor = Color.White;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (InfoTextBox.Enabled)
                {
                    InfoTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameTextBox.Enabled = false;
                    CostTextBox.Enabled = false;
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
            EditButton.Visible = flag;
            RemoveButton.Visible = flag;
            ApplyButton.Visible = !flag;
            CancelButton.Visible = !flag;
        }


    }
}
