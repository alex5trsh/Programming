using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Contacts.Model.Model;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Reflection.Metadata;

namespace Contacts.ViewModel.ViewModel
{
    /// <summary>
    /// Хранит текущие свойства класса <see cref="Contact"/> и  их проверку на корректность.
    /// </summary>
    public partial class ContactVM : ObservableObject, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Сообщение об ошибке.
        /// </summary>
        private string _error;

        /// <summary>
        /// Режим чтения для текстбоксов.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly;

        /// <summary>
        /// Видимость кнопки Apply.
        /// </summary>
        [ObservableProperty]
        private bool _isApplyVisible;

        /// <summary>
        /// Имя.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        [ObservableProperty]
        private string _numberPhone;

        /// <summary>
        /// Почта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Меняет значение <see cref="Contact.Name"/> у элемента после изменения данного свойства.
        /// </summary>
        /// <param name="oldValue">Старое значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnNameChanged(string? oldValue, string newValue)
        {
            _contact.Name = newValue;
        }

        /// <summary>
        /// Меняет значение <see cref="Contact.NumberPhone"/> у элемента после изменения данного свойства.
        /// </summary>
        /// <param name="oldValue">Старое значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnNumberPhoneChanged(string? oldValue, string newValue)
        {
            _contact.NumberPhone = newValue;
        }

        /// <summary>
        ///Меняет значение <see cref="Contact.Email"/> у элемента после изменения данного свойства.
        /// </summary>
        /// <param name="oldValue">Старое значение.</param>
        /// <param name="newValue">Новое значение.</param>
        partial void OnEmailChanged(string? oldValue, string newValue)
        {
            _contact.Email = newValue;
        }

        /// <summary>
        /// Проверяет значение на наличие ошибок.
        /// </summary>
        /// <param name="columnName">Имя свойства значения, которое нужно проверить.</param>
        /// <returns>Возвращает сообщение об ошибке.</returns>
        public string this[string columnName]
        {
            get
            {
                _error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (Name != null)
                        {
                            if (!ValueValidator.CheckStringForMaxLength(Name, 100))
                            {
                                _error = "Length of name should be less 100 symbols.";
                            }     
                        }
                        break;
                    case "NumberPhone":
                        if (NumberPhone != null)
                        {
                            if (!ValueValidator.CheckStringForMaxLength(NumberPhone, 100))
                            {
                                _error = "Length of phone number should be less 100 symbols.";
                            }

                            if (!ValueValidator.CheckStringForRightFormat(NumberPhone))
                            {
                                _error = "Phone number can contains only numbers and symbols '+()- '.";
                            }
                        }
                        break;
                    case "Email":
                        if (Email != null)
                        {
                            if (!ValueValidator.CheckStringForMaxLength(Email, 100))
                            {
                                _error = "Length of email should be less 100 symbols.";
                            }
                            if (!ValueValidator.CheckStringForSignContent(Email, "@"))
                            {
                                _error = "Email should contains symbol '@'.";
                            }
                        }
                        break;
                }

                if (_error != String.Empty)
                {
                    IsApplyVisible = false;
                }
                else if(Name!=null && NumberPhone != null && Email != null)
                {
                    IsApplyVisible = true;
                }

                return _error;
            }
        }

        /// <summary>
        /// Возвращает сообщение об ошибке.
        /// </summary>
        public string Error
        {
            get => _error;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="numberPhone">Номер.</param>
        public ContactVM(string name, string numberPhone, string email)
        {
            Name = name;
            NumberPhone = numberPhone;
            Email = email;
        }
        public ContactVM(Contact contact)
        {
            Name = contact.Name;
            NumberPhone = contact.NumberPhone;
            Email = contact.Email;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public ContactVM()
        {

        }

        /// <inheritdoc />
        public object Clone()
        {
            return new ContactVM(this.Name, this.NumberPhone, this.Email);
        }
    }
}
