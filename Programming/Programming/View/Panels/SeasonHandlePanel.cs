using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonHandlePanel : UserControl
    {
        public SeasonHandlePanel()
        {
            InitializeComponent();

            var seasons = Enum.GetValues(typeof(Season));
            foreach (var value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //EnumsTabPage.BackColor = Color.White;
            //WriteTextBox.BackColor = Color.White;
            //
            //EnumsListBox.BackColor = Color.White;
            //ValueListBox.BackColor = Color.White;
            //IntValueTextBox.BackColor = Color.White;
            //TypeValueTextBox.BackColor = Color.White;
            SeasonsComboBox.BackColor = Color.White;
            var selectedSeason = SeasonsComboBox.SelectedItem;
            switch (selectedSeason)
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
                    MessageBox.Show(
                        "О,тает снег!",
                        "Spring",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );

                    //Основной фон
                    //this.BackColor = Color.FromArgb(71, 167, 106);
                    //EnumsTabPage.BackColor = Color.FromArgb(71, 167, 106);
                    //WriteTextBox.BackColor = Color.FromArgb(71, 167, 106);
                    //Фон боксов
                    //EnumsListBox.BackColor = Color.FromArgb(168, 228, 160);
                    //ValueListBox.BackColor = Color.FromArgb(168, 228, 160);
                    //IntValueTextBox.BackColor = Color.FromArgb(168, 228, 160);
                    //TypeValueTextBox.BackColor = Color.FromArgb(168, 228, 160);
                    //SeasonsComboBox.BackColor = Color.FromArgb(168, 228, 160);
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
                    MessageBox.Show(
                        "Листья падают!",
                        "Autumn",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign
                        );

                    //Основной фон
                    //this.BackColor = Color.FromArgb(237, 118, 14);
                    //EnumsTabPage.BackColor = Color.FromArgb(237, 118, 14);
                    //WriteTextBox.BackColor = Color.FromArgb(237, 118, 14);
                    //Фон боксов
                    //EnumsListBox.BackColor = Color.FromArgb(255, 204, 153);
                    //ValueListBox.BackColor = Color.FromArgb(255, 204, 153);
                    //IntValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    //TypeValueTextBox.BackColor = Color.FromArgb(255, 204, 153);
                    //SeasonsComboBox.BackColor = Color.FromArgb(255, 204, 153);
                    break;
            }

        }
    }
}
