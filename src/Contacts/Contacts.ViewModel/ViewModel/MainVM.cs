using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contacts.Model.Model;
using Model.Model.Services;
using Contacts.ViewModel.ViewModel;

namespace ViewModel.ViewModel
{
    /// <summary>
    /// Хранит текущие свойства класса <see cref="ContactVM"/>, команды добавления, изменения и удаления объектов.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Текущий объект класса <see cref="Contact"/>.
        /// </summary>     
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
        /// Возвращает и задает коллекцию объектов класса <see cref="ContactVM"/>.
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
                if (SetProperty(ref _contact, value))
                {
                    Reset();
                }
            }
        }

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
                Save();
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
                Save();
            }          
        }

        /// <summary>
        /// Сохраняет элементы коллекции <see cref="ContactVM"/>.
        /// </summary>
        private void Save()
        {
            ObservableCollection<Contact> savedContacts = new ObservableCollection<Contact>();
            for(int i=0; i<Contacts.Count; i++)
            {
                Contact currentContact = new Contact(Contacts[i].Name, Contacts[i].NumberPhone, 
                    Contacts[i].Email);
                savedContacts.Add(currentContact);
            }
            ContactSerializer.SaveToFile(savedContacts);
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
            Contacts = new ObservableCollection<ContactVM>();
            ObservableCollection<Contact> uploadedContacts = ContactSerializer.LoadFromFile();
            for(int i=0;i< uploadedContacts.Count;i++)
            {
                Contacts.Add(new ContactVM(uploadedContacts[i]));
            }
            Contact.IsApplyVisible = false;
            Contact.IsReadOnly = true;
            IsEnabled = true;
        }
    }
}
