using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.Model;
using View.ViewModel;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
            DataObject.AddPastingHandler(PhoneNumberTextBox, TextBoxPaste);
        }


        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (e.Text != "+" && e.Text != "-" && e.Text!= "(" && e.Text != ")" && e.Text != " " 
                && !Int32.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPaste(object sender, DataObjectPastingEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isCorrectText = false;

            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                Regex pattern = new Regex(@"^(\+7)(\s)(\()([0-9]){3}(\))(\s)([0-9]){3}(\-)([0-9]){2}(\-)([0-9]){2}$");
                if (pattern.IsMatch(pasteText))
                    isCorrectText = true;
            }

            if (!isCorrectText)
            {
                e.CancelCommand();
            }
        }
    }
}
