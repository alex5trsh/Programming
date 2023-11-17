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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы вывода данных текущего элемента класса <see cref="Customer"/>,
    /// его изменения, удаления, добавления.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Customer"/>.
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
                FillCustomersListBox();
            }
        }

        /// <summary>
        /// Текущий элемент класса <see cref="Customer"/>.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Индекс текущего элемента.
        /// </summary>
        private int _currentIndex;

        public CustomersTab()
        {
            InitializeComponent();

            FillCustomersListBox();
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CustomersListBox.SelectedIndex >= 0)
            {
                _currentIndex = CustomersListBox.SelectedIndex;
                _currentCustomer = Customers[_currentIndex];

                UpdateCustomerInfo(_currentCustomer);
                SwitchAccessTextBox(true);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer _newCustomer = new Customer("FullName Name MiddleName", new BindingList<Order>());
            Customers.Add(_newCustomer);
            FillCustomersListBox();

            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i] == _newCustomer)
                {
                    CustomersListBox.SelectedIndex = i;
                }
            }

            SwitchAccessTextBox(true);  
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex >= 0 && CustomersListBox != null)
            {
                Customers.RemoveAt(_currentIndex);
                FillCustomersListBox();
                CustomersListBox.SelectedIndex = -1;
                SwitchAccessTextBox(false);
                ClearCustomersInfo();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newName = NameTextBox.Text;
                if (_currentCustomer.FullName != newName)
                {
                    _currentCustomer.FullName = newName;
                }

                NameTextBox.BackColor = Color.White;
                CustomersListBox.Enabled = true;
                IsPriorityCheckBox.Enabled = true;
                AddressControl.SwitchAccessTextBox(true);
                SwitchVisibleButtons(true);   
                FillCustomersListBox();
            }
            catch
            {
                if (NameTextBox.Enabled)
                {
                    NameTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    CustomersListBox.Enabled = false;
                    IsPriorityCheckBox.Enabled = false;
                    AddressControl.SwitchAccessTextBox(false);
                    SwitchVisibleButtons(false);
                }
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPriorityCheckBox.Checked == true)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }

        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="customer">Название объекта, данные которого необходимо обновить.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IdTextBox.Text = Convert.ToString(customer.Id);
            NameTextBox.Text = customer.FullName;
            AddressControl.Address = customer.Address;
            IsPriorityCheckBox.Checked = customer.IsPriority;
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями объекта.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            AddressControl.ClearAddressTextBox();
            IsPriorityCheckBox.Checked = false;
        }

        /// <summary>
        /// Задает свойство доступа для текстбоков.
        /// </summary>
        /// <param name="flag">Значение свойства доступа. Равно true или false.</param>
        private void SwitchAccessTextBox(bool flag)
        {
            NameTextBox.Enabled = flag;
            AddressControl.SwitchAccessTextBox(flag);
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
        /// Заполняет CustomersListBox значениями из Customers.
        /// </summary>
        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = Customers;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }     
    }
}
