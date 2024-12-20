﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет методы за вывод элементов перечисления и индекса выбранного элемента.
    /// </summary>
    public partial class EnumerationsValuePanel : UserControl
    {
       
        public EnumerationsValuePanel()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.DisplayMember = nameof(Type.Name);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValueListBox.Items.Clear();
            IntValueTextBox.Clear();
            foreach (var enumValue in enumValues)
            {
                ValueListBox.Items.Add(enumValue);
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = Convert.ToString((int)ValueListBox.SelectedItem);
        }
    }
}
