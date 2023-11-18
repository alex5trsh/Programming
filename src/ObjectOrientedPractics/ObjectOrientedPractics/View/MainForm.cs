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
            if (MainTabControl.SelectedIndex==2)
            {
                CartsTab.RefreshData();
            }

            if (MainTabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }

            if (MainTabControl.SelectedIndex == 4)
            {
                priorityOrdersTab.Items = _store.Items;
            }
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            OrdersTab.Customers= _store.Customers;
        }

        private void priorityOrdersTab_Load(object sender, EventArgs e)
        {
            priorityOrdersTab.Items = _store.Items;
        }
    }
}
