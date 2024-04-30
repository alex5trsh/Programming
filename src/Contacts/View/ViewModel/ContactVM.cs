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
using View.Model;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Reflection.Metadata;

namespace View.ViewModel
{
    /// <summary>
    /// Хранит текущие свойства класса <see cref="Contact"/> и  их проверку на корректность.
    /// </summary>
    public class ContactVM : ObservableObject, ICloneable, IDataErrorInfo
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
        private bool _isReadOnly;

        /// <summary>
        /// Видимость кнопки Apply.
        /// </summary>
        private bool _isApplyVisible;

        //public ContactVM(Contact contact) => this._contact = contact;

        /// <summary>
        /// Возвращает и задает имя. 
        /// </summary>
        public string Name
        {
            get => _contact.Name;
            set => SetProperty(_contact.Name, value, _contact, (u, n) => u.Name = n);
            //set
            //{
            //    if (_contact.Name != value)
            //    {
            //        _contact.Name = value;
            //        OnPropertyChanged(nameof(Name));
            //    }
            //}
        }

        /// <summary>
        /// Возвращает и задает номер.
        /// </summary>
        public string NumberPhone
        {
            get => _contact.NumberPhone;
            set => SetProperty(_contact.NumberPhone, value, _contact, (u, n) => u.NumberPhone = n);
            //set => SetProperty(ref _contact.NumberPhone, value);
            //set
            //{
            //    if (_contact.NumberPhone != value)
            //    {
            //        _contact.NumberPhone = value;
            //        OnPropertyChanged(nameof(NumberPhone));
            //    }
            //}
        }

        /// <summary>
        /// Возвращает и задает почту. 
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set => SetProperty(_contact.Email, value, _contact, (u, n) => u.Email = n);
            //set => SetProperty(ref _contact.Email, value);
            //set
            //{
            //    if (_contact.Email != value)
            //    {
            //        _contact.Email = value;
            //        OnPropertyChanged(nameof(Email));
            //    }
            //}
        }

        /// <summary>
        /// Возвращает и задает режим чтения для текстбоксов.
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set => SetProperty(ref _isReadOnly, value);
            //set
            //{
            //    if (_isReadOnly != value)
            //    {
            //        _isReadOnly = value;
            //        OnPropertyChanged(nameof(IsReadOnly));
            //    }
            //}
        }

        /// <summary>
        /// Возвращает и задает видимость кнопки Apply.
        /// </summary>
        public bool IsApplyVisible
        {
            get => _isApplyVisible;
            set => SetProperty(ref _isApplyVisible, value);
            //set
            //{
            //    if (_isApplyVisible != value)
            //    {
            //        _isApplyVisible = value;
            //        OnPropertyChanged(nameof(IsApplyVisible));
            //    }
            //}
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

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public ContactVM()
        {

        }

        ///// <summary>
        ///// Событие на изменение какого-либо свойства класса <see cref="Contact"/>.
        ///// </summary>
        //public event PropertyChangedEventHandler? PropertyChanged;

        ///// <summary>
        ///// Вызывает событие <see cref="PropertyChanged"/>.
        ///// </summary>
        ///// <param name="prop">Название свойства, которое было изменено.</param>
        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}

        /// <inheritdoc />
        public object Clone()
        {
            return new ContactVM(this.Name, this.NumberPhone, this.Email);
        }
    }
}
