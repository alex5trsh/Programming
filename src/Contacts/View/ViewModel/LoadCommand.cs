using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Выгружает объект <see cref="Contact"></see> из файла.
    /// </summary>
    class LoadCommand : ICommand
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
        /// Выгружает объект класса <see cref="Contact"/> из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object? parameter)
        {
            Contact contact =ContactSerializer.LoadFromFile();
            DataContext.Name = contact.Name;
            DataContext.NumberPhone = contact.NumberPhone;
            DataContext.Email = contact.Email;
        }

        /// <summary>
        /// Конструктор класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="dataContext">Текущий источник данных.</param>
        public LoadCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
