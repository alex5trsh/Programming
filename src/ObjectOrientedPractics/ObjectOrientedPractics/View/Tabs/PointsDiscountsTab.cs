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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PointsDiscountsTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items=new List<Item>() { new Item("Name", "Info", 100, Category.Product) ,
            new Item("Name", "Info", 100, Category.Product),new Item("Name", "Info", 100, Category.Product),
            new Item("Name", "Info", 100, Category.Product),new Item("Name", "Info", 100, Category.Product)};

        /// <summary>
        /// Баллы.
        /// </summary>
        PointsDiscount points=new PointsDiscount();

        /// <summary>
        /// Общая стоимость.
        /// </summary>
        double _cost=500;

        public PointsDiscountsTab()
        {
            InitializeComponent();
            ProductAmountNumberLabel.Text = Convert.ToString(_cost);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            InfoLabel.Text = points.Info;
            DiscoutAmountNumberLabel.Text= Convert.ToString(points.Calculate(_items));
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            double discount = points.Calculate(_items);
            points.Apply(_items); 
            DiscoutAmountNumberLabel.Text = "0";
            InfoLabel.Text = points.Info;
            ProductAmountNumberLabel.Text = Convert.ToString(_cost-discount);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            points.Update(_items);
            InfoLabel.Text = points.Info;
        }
    }
}
