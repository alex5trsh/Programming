using System;
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
    // TODO: XML (+)
    /// <summary>
    /// Предоставляет методы за распознавание введенного текста как объекта 
    /// перечисления <see cref="Weekday"/>.
    /// </summary>
    public partial class WeekdayParsingPanel : UserControl
    {
        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var writtingValue = TypeValueTextBox.Text;
            if (Enum.TryParse(writtingValue, out Weekday gettingValue))
            {
                WriteTextBox.Text = ($"Это день недели ({ gettingValue}={ (int)gettingValue + 1})");
            }
            else
            {
                WriteTextBox.Text = "Нет такого дня недели";
            }
        }
    }
}
