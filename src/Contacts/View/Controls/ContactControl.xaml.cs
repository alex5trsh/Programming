using Newtonsoft.Json.Linq;
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
       
        /// <summary>
        /// Дает вводить текст только с допустимыми символами.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Введенный текст.</param>
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!ValueValidator.CheckStringForRightSimbols(e.Text))
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Дает вставлять текст только с допустимыми символами.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Вставленный текст.</param>
        private void TextBoxPaste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string pasteText = e.DataObject.GetData(typeof(string)) as string;
                if (!ValueValidator.CheckStringForRightFormat(pasteText))
                {
                    e.CancelCommand();
                }
            }
        }
    }
}
