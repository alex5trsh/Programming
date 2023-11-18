using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет методы вывода доступных текущему покупателю скидок и добавления новых скидок.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Выбранная категория для скидки.
        /// </summary>
        public Category category;

        /// <summary>
        /// Флаг для проверки выбора какой-либо категории.
        /// </summary>
        public bool isCategorySelect;

        /// <summary>
        /// Категории на которые есть скидки.
        /// </summary>
        public List<Category> existingCategories;

        public AddDiscountForm(List<Category> categoriesFromKeyForm)
        {
            InitializeComponent();

            var categories = Enum.GetValues(typeof(Category));
            existingCategories = categoriesFromKeyForm;

            if (existingCategories!= null)
            {
                foreach (var value in categories)
                {
                    if (existingCategories.Contains((Category)value) == false)
                    {
                        CategoryComboBox.Items.Add(value);
                    }
                }
            }
            else
            {
                foreach (var value in categories)
                {
                    CategoryComboBox.Items.Add(value);
                }

            }

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(CategoryComboBox.SelectedItem!=null)
            {
                category = (Category)CategoryComboBox.SelectedItem;
                isCategorySelect = true;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            isCategorySelect = false;
            this.Close();
        }      
    }
}
