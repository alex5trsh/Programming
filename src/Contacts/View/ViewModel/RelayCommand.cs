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
    /// Выгружает  и сохраняет объект <see cref="Contact"></see> из/в файла.
    /// </summary>
    internal class RelayCommand: ICommand
    {
        /// <summary>
        /// Команда, которая будет выполняться.
        /// </summary>
        private Action<object> _execute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }

        public RelayCommand(Action<object> execute)
        {
            this._execute = execute;
        }
    }
}
