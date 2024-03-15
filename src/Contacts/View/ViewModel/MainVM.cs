using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Хранит текущие свойства класса <see cref="Contact"/>, команды сохранения и выгрузки объекта.
    /// </summary>
    class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий объект класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Команда сохранения объекта.
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Команда выгрузки объекта.
        /// </summary>
        private ICommand _loadCommand;

        /// <summary>
        /// Возвращает команду сохранения объекта.
        /// </summary>
        public ICommand SaveCommand
        {
            get => _saveCommand;
        }

        /// <summary>
        /// Возвращает команду выгрузки объекта.
        /// </summary>
        public ICommand LoadCommand
        {
            get => _loadCommand;
        }

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name
        {
            get => _contact.Name;
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер.
        /// </summary>
        public string NumberPhone
        {
            get => _contact.NumberPhone;
            set
            {
                if (_contact.NumberPhone != value)
                {
                    _contact.NumberPhone = value;
                    OnPropertyChanged("NumberPhone");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает почту.
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// Событие на изменение какого-либо свойства класса <see cref="MainVM"/>.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
        }
    }

}
