//using Programming.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Colors),typeof(EducationForm), typeof(Genre),typeof(Manufactures), typeof(Season),typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            var seasons = Enum.GetValues(typeof(Season));
            foreach(var Value in seasons)
            {
                SeasonsComboBox.Items.Add(Value);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValueListBox.Items.Clear();
            IntValueTextBox.Clear();
            foreach (var enumValue in enumValues)
            { ValueListBox.Items.Add(enumValue); }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = Convert.ToString((int)ValueListBox.SelectedItem+1);
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {   var WrittingValue = TypeValueTextBox.Text;
            if (Enum.TryParse(WrittingValue, out Weekday GettingValue))
                //!!!
                { WriteTextBox.Text = ($"Это день недели ({ GettingValue}={ (int)GettingValue + 1})"); }
            else
                { WriteTextBox.Text = "Нет такого дня недели"; }

        }

           
        private void GoButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            EnumsTabPage.BackColor = Color.White;
            WriteTextBox.BackColor = Color.White;
            //
            EnumsListBox.BackColor = Color.White;
            ValueListBox.BackColor = Color.White;
            IntValueTextBox.BackColor = Color.White;
            TypeValueTextBox.BackColor = Color.White;
            SeasonsComboBox.BackColor = Color.White;
            var SelectedSeason = SeasonsComboBox.SelectedItem;
            switch (SelectedSeason)
            {
                case Season.Winter:
                    MessageBox.Show(
                        "Бррр, Холодно!!!",
                        "Winter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );
                    break;
                case Season.Spring:
                    //Фон
                    this.BackColor = ColorTranslator.FromHtml("#47A76A") ;
                    EnumsTabPage.BackColor = ColorTranslator.FromHtml("#47A76A");
                    WriteTextBox.BackColor = ColorTranslator.FromHtml("#47A76A");
                    //
                    EnumsListBox.BackColor = ColorTranslator.FromHtml("#A8E4A0");
                    ValueListBox.BackColor = ColorTranslator.FromHtml("#A8E4A0");
                    IntValueTextBox.BackColor = ColorTranslator.FromHtml("#A8E4A0");
                    TypeValueTextBox.BackColor = ColorTranslator.FromHtml("#A8E4A0");
                    SeasonsComboBox.BackColor = ColorTranslator.FromHtml("#A8E4A0");
                    break;
                case Season.Summer:
                    MessageBox.Show(
                        "Ура! Лето!",
                        "Summer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );
                    break;
                case Season.Autumn:
                    //Фон
                    this.BackColor = Color.FromArgb(237,118,14);
                    EnumsTabPage.BackColor = Color.FromArgb(237, 118, 14);
                    WriteTextBox.BackColor = Color.FromArgb(237, 118, 14);
                    //
                    EnumsListBox.BackColor = Color.FromArgb(255, 204, 153);
                    ValueListBox.BackColor = Color.FromArgb(255, 204, 153);
                    IntValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    TypeValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    SeasonsComboBox.BackColor = Color.FromArgb(255, 204, 153);
                    break;
            }
            

        }

      
    }
}
