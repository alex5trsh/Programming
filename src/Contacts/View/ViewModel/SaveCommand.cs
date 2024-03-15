using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Сохраняет объект <see cref="Contact"></see> в файл.
    /// </summary>
    class SaveCommand : ICommand
    {
        /// <summary>
        /// Возвращает и задает текущий источник данных.
        /// </summary>
        public MainVM DataContext { get; set; }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Сохраняет объект класса <see cref="Contact"/> в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            string name = DataContext.Name;
            string numberPhone = DataContext.NumberPhone;
            string email = DataContext.Email;
            Contact contact = new Contact(name, numberPhone, email);
            ContactSerializer.SaveToFile(contact);
        }

        /// <summary>
        /// Конструктор класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="dataContext">Текущий источник данных.</param>
        public SaveCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
