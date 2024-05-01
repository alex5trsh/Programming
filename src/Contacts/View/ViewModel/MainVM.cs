using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий объект класса <see cref="Contact"/>.
        /// </summary>
        [ObservableProperty]
        private ContactVM _contact;

        /// <summary>
        /// Доступ к кнопкам.
        /// </summary>
        [ObservableProperty]
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
        //public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования текущего объекта.
        /// </summary>
        //public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления текущего объекта.
        /// </summary>
        //public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду сохранения измененного/нового объекта в списке.
        /// </summary>
        //public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает и задает коллекцию объектов класса <see cref="Contact"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает текущий объект класса <see cref="Contact"/>.
        /// </summary>
        //public ContactVM Contact
        //{
        //    get => _contact;
        //    set
        //    {
        //        if (SetProperty(ref _contact, value))
        //        {
        //            Reset();
        //        }
        //    }
        //}

        //не работает applyVisible
        partial void OnContactChanged(ContactVM oldValue, ContactVM newValue)
        {
            if(oldValue!=newValue)
            {
                Reset();
            }
        }

        /// <summary>
        /// Возвращает и задает доступ к кнопкам.
        /// </summary>
        //public bool IsEnabled 
        //{
        //    get => _isEnabled;
        //    set => SetProperty(ref _isEnabled, value);
        //}

        /// <summary>
        /// Дает возможность добавления нового контакта.
        /// </summary>
        [RelayCommand]
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
        [RelayCommand]
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
        [RelayCommand]
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
        [RelayCommand]
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
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contact = new ContactVM();
            Contacts = ContactSerializer.LoadFromFile();
            Contact.IsApplyVisible = false;
            Contact.IsReadOnly = true;
            IsEnabled = true;
            //AddCommand = new RelayCommand(Add);
            //EditCommand = new RelayCommand(Edit);
            //RemoveCommand = new RelayCommand(Remove);
            //ApplyCommand = new RelayCommand(Apply);
        }
    }
}
