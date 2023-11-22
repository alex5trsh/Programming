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

        public MainForm()
        {
            InitializeComponent();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;

            ItemsTab.ItemsChanged += Tabs_RefreshData;
            CustomersTab.CustomersChanged += Tabs_RefreshData;
            CartsTab.OrderChanged += Tabs_RefreshData;
        }

        private void Tabs_RefreshData(object sender, EventArgs e)
        {
            CartsTab.RefreshData();
            OrdersTab.RefreshData();
        }
    }
}
