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
    /// Хранит текущие свойства класса <see cref="ContactVM"/>, команды добавления, изменения и удаления объектов.
    /// </summary>
    class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий объект класса <see cref="Contact"/>.
        /// </summary>
        private ContactVM _contact;

        /// <summary>
        /// Доступ к кнопкам.
        /// </summary>
        private bool _isEnabled;

        /// <summary>
        /// Режим добавления нового контакта.
        /// </summary>
        private bool _isAddMode;

        /// <summary>
        /// Индекс текущего контакта.
        /// </summary>
        private int _currentIndex;

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
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает текущий объект класса <see cref="Contact"/>.
        /// </summary>
        public ContactVM Contact
        {
            get => _contact;
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged(nameof(Contact));
                    Reset();
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
        /// Дает возможность добавления нового контакта.
        /// </summary>
        private void Add()
        {
            Contact = new ContactVM();
            Contact.IsApplyVisible = true;
            Contact.IsReadOnly = false;
            IsEnabled = false;
            _isAddMode = true;
        }

        /// <summary>
        /// Предоставляет доступ к редактированию текущего контакта. 
        /// </summary>
        private void Edit()
        {
            if (this.Contact.Name != null && this.Contact.Email != null && 
                this.Contact.NumberPhone != null)
            {            
                _currentIndex = Contacts.IndexOf(Contact);
                Contact= (ContactVM)Contact.Clone();
                Contact.IsApplyVisible = true;
                Contact.IsReadOnly = false;
                IsEnabled = false;
                _isAddMode = false;
            }
        }

        /// <summary>
        /// Удаляет текущего контакта.
        /// </summary>
        private void Remove()
        {
            if (this.Contact.Name != null && this.Contact.Email != null && this.Contact.NumberPhone != null)
            {
                _currentIndex = Contacts.IndexOf(Contact);
                Contacts.Remove(Contact);
                int count = Contacts.Count;
                if (count == 0)
                {
                    Contact = new ContactVM();
                }
                else if(count==_currentIndex)
                {
                    Contact = Contacts[_currentIndex - 1];
                }
                else
                {
                    Contact = Contacts[_currentIndex];
                }
                ContactSerializer.SaveToFile(Contacts);
            }         
        }

        /// <summary>
        /// Сохраняет текущий контакт в списке.
        /// </summary>
        private void Apply()
        {
            if (this.Contact.Name != null && this.Contact.Email != null && this.Contact.NumberPhone != null)
            {
                if (_isAddMode)
                {
                    Contacts.Add(Contact);
                }
                else
                {             
                    Contacts.Insert(_currentIndex, Contact);
                    Contacts.RemoveAt(_currentIndex+1);
                }
                IsEnabled = true;
                Contact.IsApplyVisible = false;
                Contact.IsReadOnly = true;
                ContactSerializer.SaveToFile(Contacts);
            }          
        }

        /// <summary>
        /// Сбрасывает редактирование/добавление контакта.
        /// </summary>
        private void Reset()
        {
            if(Contact!= null)
            {
                IsEnabled = true;
                Contact.IsApplyVisible = false;
                Contact.IsReadOnly = true;
            }    
        }

        /// <summary>
        /// Событие на изменение какого-либо свойства класса <see cref="MainVM"/>.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="prop">Название свойства, которое было изменено.</param>
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
            _contact = new ContactVM();
            Contacts = ContactSerializer.LoadFromFile();
            Contact.IsApplyVisible = false;
            Contact.IsReadOnly = true;
            IsEnabled = true;
            AddCommand = new RelayCommand((param) => Add());
            EditCommand = new RelayCommand((param) => Edit());
            RemoveCommand = new RelayCommand((param) => Remove());
            ApplyCommand = new RelayCommand((param) => Apply());
        }
    }
}
