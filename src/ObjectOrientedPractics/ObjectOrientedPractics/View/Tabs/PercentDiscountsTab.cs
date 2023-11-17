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
    public partial class PercentDiscountsTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>() { new Item("Name", "Info", 100, Category.Product) ,
            new Item("Name", "Info", 100, Category.Product),new Item("Name", "Info", 100, Category.Product),
            new Item("Name", "Info", 100, Category.Product),new Item("Name", "Info", 100, Category.Product)};

        /// <summary>
        /// Текущий процент.
        /// </summary>
        PercentDiscount _percent = new PercentDiscount(Category.Product);

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        double _cost = 500;

        public PercentDiscountsTab()
        {
            InitializeComponent();
            ProductAmountNumberLabel.Text = Convert.ToString(_cost);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = _percent.Info;
            DiscoutAmountNumberLabel.Text = Convert.ToString(_percent.Calculate(_items));
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double discount = _percent.Calculate(_items);
            _percent.Apply(_items);
            DiscoutAmountNumberLabel.Text = "0";
            InfoLabel.Text = _percent.Info;
            ProductAmountNumberLabel.Text = Convert.ToString(_cost - discount);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            _percent.Update(_items);
            InfoLabel.Text = _percent.Info;
        }
        
    }
}
