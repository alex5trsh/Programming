using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Хранит текущие свойства класса <see cref="Contact"/>, команды добавления, изменения и удаления объектов.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий объект класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Видимость кнопок.
        /// </summary>
        private bool _visibility;

        /// <summary>
        /// Доступ к текстбоксам.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Доступ к кнопкам.
        /// </summary>
        private bool _isEnabled;

        /// <summary>
        /// Добавление нового контакта.
        /// </summary>
        private bool _isNewContact;

        /// <summary>
        /// Возвращает команду добавления нового объекта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования текущего объекта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления текущего объекта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду сохранения измененного/нового объекта в списке.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает и задает коллекцию объектов класса <see cref="Contact"/>.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает текущий объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged(nameof(Contact));
                }
            }
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
                    OnPropertyChanged(nameof(Name));
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
                    OnPropertyChanged(nameof(NumberPhone));
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
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает видимость кнопок.
        /// </summary>
        public bool Visibility
        {
            get => _visibility;
            set
            {
                if (_visibility != value)
                {
                    _visibility = value;
                    OnPropertyChanged(nameof(Visibility));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает доступ к текстбоксам.
        /// </summary>
        public bool IsReadOnly 
        {
            get => _isReadOnly;
            set
            {
                if (_isReadOnly != value)
                {
                    _isReadOnly = value;
                    OnPropertyChanged(nameof(IsReadOnly));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает доступ к кнопкам.
        /// </summary>
        public bool IsEnabled 
        {
            get => _isEnabled;
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        /// <summary>
        /// Добавление нового контакта.
        /// </summary>
        private void Add()
        {
            Contact = new Contact();
            Visibility = true;
            IsReadOnly = false;
            IsEnabled = false;
            _isNewContact = true;
        }

        /// <summary>
        /// Редактирование текущего контакта.
        /// </summary>
        private void Edit()
        {
            if (this.Name != null && this.Email != null && this.NumberPhone != null)
            {
                Visibility = true;
                IsReadOnly = false;
                IsEnabled = false;
                _isNewContact = false;    
            }
        }

        /// <summary>
        /// Удаление текущего контакта.
        /// </summary>
        private void Remove()
        {
            if (this.Name != null && this.Email != null && this.NumberPhone != null)
            {
                int index = Contacts.IndexOf(Contact);
                Contacts.Remove(Contact);
                int count = Contacts.Count;
                if (count == 0)
                {
                    Contact = new Contact();
                }
                else
                {
                    Contact = Contacts[index];
                }
            }
            ContactSerializer.SaveToFile(Contacts);
        }

        /// <summary>
        /// Сохранение текущего контакта в списке.
        /// </summary>
        private void Apply()
        {
            if (this.Name != null && this.Email != null && this.NumberPhone != null)
            {
                if (_isNewContact)
                {
                    Contacts.Add(Contact);
                }
                IsEnabled = true;
                Visibility = false;
                IsReadOnly = true;
            }
            ContactSerializer.SaveToFile(Contacts);
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
            Contacts = ContactSerializer.LoadFromFile();
            Visibility = false;
            IsReadOnly = true;
            IsEnabled = true;
            AddCommand = new RelayCommand((param) => Add());
            EditCommand = new RelayCommand((param) => Edit());
            RemoveCommand = new RelayCommand((param) => Remove());
            ApplyCommand = new RelayCommand((param) => Apply());
        }
    }
}
