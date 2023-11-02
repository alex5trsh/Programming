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

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        private Store _store=new Store();

        /// <summary>
        /// Путь к файлам <see cref="_itemsFileName"/> и <see cref="_customersFileName"/>.
        /// </summary>
        private string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.
            ApplicationData) + "\\AppStore";

        /// <summary>
        ///  Файл, хранящий объекты класса <see cref="Item"/>.
        /// </summary>
        private string _itemsFileName = "Items.json";

        /// <summary>
        /// Файл, хранящий объекты класса <see cref="Customer"/>.
        /// </summary>
        private string _customersFileName = "Customers.json";

        public MainForm()
        {
            InitializeComponent();
            _store.Customers = ProjectSerializer.LoadCustomerFromFile(_directoryPath, _customersFileName);
            _store.Items = ProjectSerializer.LoadItemFromFile(_directoryPath, _itemsFileName);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveItemToFile(ItemsTab.Items, _directoryPath, _itemsFileName);
            ProjectSerializer.SaveCustomerToFile(CustomersTab.Customers, _directoryPath,
                _customersFileName);
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            
            ItemsTab.Items = _store.Items;
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            
            CustomersTab.Customers = _store.Customers;
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex==2)
            {
                CartsTab.RefreshData();
            }    
        }
    }
}
