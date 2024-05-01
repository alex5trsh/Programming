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
    /// Добавляет, изменяет, удаляет объекты <see cref="Contact"></see> из/в списка.
    /// </summary>
    //internal class RelayCommand: ICommand
    //{
    //    /// <summary>
    //    /// Команда, которая будет выполняться.
    //    /// </summary>
    //    private Action<object> _execute;

    //    /// <summary>
    //    /// Событие на изменение условий выполнения команды.
    //    /// </summary>
    //    public event EventHandler CanExecuteChanged
    //    {
    //        add { CommandManager.RequerySuggested += value; }
    //        remove { CommandManager.RequerySuggested -= value; }
    //    }

    //    /// <summary>
    //    /// Определяет может ли команда выполняться.
    //    /// </summary>
    //    /// <param name="parameter">Входной параметр для опредления выполнения команды.</param>
    //    /// <returns>Возвращает всегда true. </returns>
    //    public bool CanExecute(object? parameter)
    //    {
    //        return true;
    //    }

    //    /// <summary>
    //    /// Выполняет команду.
    //    /// </summary>
    //    /// <param name="parameter">Входной параметр для выполнения команды.</param>
    //    public void Execute(object parameter)
    //    {
    //        this._execute(parameter);
    //    }

    //    /// <summary>
    //    /// Присваивает команду, которая будет выполняться.
    //    /// </summary>
    //    /// <param name="execute">Команда, которую нужно выполнить.</param>
    //    public RelayCommand(Action<object> execute)
    //    {
    //        this._execute = execute;
    //    }
    //}
}
