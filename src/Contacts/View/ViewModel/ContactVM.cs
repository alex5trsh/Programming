using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class ContactVM: INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        private Contact _contact=new Contact();

        /// <summary>
        /// 
        /// </summary>
        private string _error;

        /// <summary>
        /// 
        /// </summary>
        private bool _isReadOnly;

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
        /// Возвращает и задает режим чтения для текстбоксов.
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
        /// 
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
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
                            if (Name.Length > 10)
                            {
                                _error = "Length of name should be less 100 symbols.";
                            }
                        }
                        break;
                    case "NumberPhone":
                        if (NumberPhone != null)
                        {
                            if (NumberPhone.Length > 100)
                            {
                                _error = "Length of phone number should be less 100 symbols.";
                            }
                            for (int i = 0; i < NumberPhone.Length; i++)
                            {
                                if (NumberPhone[i] != '+' && NumberPhone[i] != '-' && NumberPhone[i]
                                    != '(' && NumberPhone[i] != ')' && NumberPhone[i] != ' ' &&
                                    !(NumberPhone[i] >= '0' && NumberPhone[i] <= '9'))
                                {
                                    _error = "Phone number can contains only numbers and symbols '+()- '.";
                                }
                            }
                        }
                        break;
                    case "Email":
                        if (Email != null)
                        {
                            if (Email.Length > 100)
                            {
                                _error = "Length of email should be less 100 symbols.";
                            }
                            if (!Email.Contains("@"))
                            {
                                _error = "Email should contains symbol '@'.";
                            }
                        }
                        break;
                }
                return _error;
            }
        }

        /// <summary>
        /// 
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

        /// <summary>
        /// Событие на изменение какого-либо свойства класса <see cref="Contact"/>.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="prop">Название свойства, которое было изменено.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new ContactVM(this.Name, this.NumberPhone, this.Email);
        }
    }
}
