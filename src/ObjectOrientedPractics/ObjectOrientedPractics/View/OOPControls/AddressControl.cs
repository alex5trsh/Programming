using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs.Controls
{
    /// <summary>
    /// Предоставляет методы вывода даных текущего элемента класса <see cref="Address"/> и его изменения.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает адрес. Выводит адрес на текстбоксах.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                UpdateAddressInfo(_address);
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newIndex = Convert.ToInt32(PostIndexTextBox.Text);
                if (Address.Index != newIndex)
                {
                    Address.Index = newIndex;
                }

                PostIndexTextBox.BackColor = Color.White;
                CountryTextBox.Enabled = true;
                CityTextBox.Enabled = true;
                StreetTextBox.Enabled = true;
                BuildingTextBox.Enabled = true;
                ApartmentTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (PostIndexTextBox.Enabled)
                {
                    PostIndexTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    CountryTextBox.Enabled = false;
                    CityTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    BuildingTextBox.Enabled = false;
                    ApartmentTextBox.Enabled = false;
                    ErrorLabel.Text = "Индекс должен состоять из 6 цифр!";
                    ErrorLabel.Visible = true;

                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newCountry = CountryTextBox.Text;
                if (Address.Country != newCountry)
                {
                    Address.Country = newCountry;
                }

                CountryTextBox.BackColor = Color.White;
                PostIndexTextBox.Enabled = true;
                CityTextBox.Enabled = true;
                StreetTextBox.Enabled = true;
                BuildingTextBox.Enabled = true;
                ApartmentTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (CountryTextBox.Enabled)
                {
                    CountryTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    PostIndexTextBox.Enabled = false;
                    CityTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    BuildingTextBox.Enabled = false;
                    ApartmentTextBox.Enabled = false;
                    ErrorLabel.Text = "Страна должна быть меньше 50 символов!";
                    ErrorLabel.Visible = true;
                }
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newCity = CityTextBox.Text;
                if (Address.City != newCity)
                {
                    Address.City = newCity;
                }

                CityTextBox.BackColor = Color.White;
                PostIndexTextBox.Enabled = true;
                CountryTextBox.Enabled = true;
                StreetTextBox.Enabled = true;
                BuildingTextBox.Enabled = true;
                ApartmentTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (CityTextBox.Enabled)
                {
                    CityTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    PostIndexTextBox.Enabled = false;
                    CountryTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    BuildingTextBox.Enabled = false;
                    ApartmentTextBox.Enabled = false;
                    ErrorLabel.Text = "Город должен быть меньше 50 символов!";
                    ErrorLabel.Visible = true;
                }
            }

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newStreet = StreetTextBox.Text;
                if (Address.Street != newStreet)
                {
                    Address.Street = newStreet;
                }

                StreetTextBox.BackColor = Color.White;
                PostIndexTextBox.Enabled = true;
                CityTextBox.Enabled = true;
                CountryTextBox.Enabled = true;
                BuildingTextBox.Enabled = true;
                ApartmentTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (StreetTextBox.Enabled)
                {
                    StreetTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    PostIndexTextBox.Enabled = false;
                    CityTextBox.Enabled = false;
                    CountryTextBox.Enabled = false;
                    BuildingTextBox.Enabled = false;
                    ApartmentTextBox.Enabled = false;
                    ErrorLabel.Text = "Улица должна быть меньше 100 символов!";
                    ErrorLabel.Visible = true;
                }
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newBuilding = BuildingTextBox.Text;
                if (Address.Building != newBuilding)
                {
                    Address.Building = newBuilding;
                }

                BuildingTextBox.BackColor = Color.White;
                PostIndexTextBox.Enabled = true;
                CityTextBox.Enabled = true;
                StreetTextBox.Enabled = true;
                CountryTextBox.Enabled = true;
                ApartmentTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (BuildingTextBox.Enabled)
                {
                    BuildingTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    PostIndexTextBox.Enabled = false;
                    CityTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    CountryTextBox.Enabled = false;
                    ApartmentTextBox.Enabled = false;
                    ErrorLabel.Text = "Номер дома должен быть меньше 10 символов!";
                    ErrorLabel.Visible = true;
                }
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newApartment = ApartmentTextBox.Text;
                if (Address.Apartment != newApartment)
                {
                    Address.Apartment = newApartment;
                }

                ApartmentTextBox.BackColor = Color.White;
                PostIndexTextBox.Enabled = true;
                CityTextBox.Enabled = true;
                StreetTextBox.Enabled = true;
                BuildingTextBox.Enabled = true;
                CountryTextBox.Enabled = true;
                ErrorLabel.Visible = false;
            }
            catch
            {
                if (ApartmentTextBox.Enabled)
                {
                    ApartmentTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    PostIndexTextBox.Enabled = false;
                    CityTextBox.Enabled = false;
                    StreetTextBox.Enabled = false;
                    BuildingTextBox.Enabled = false;
                    CountryTextBox.Enabled = false;
                    ErrorLabel.Text = "Номер квартиры должен быть меньше 10 символов!";
                    ErrorLabel.Visible = true;
                }
            }

        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="address">Название объекта, данные которого необходимо обновить.</param>
        private void UpdateAddressInfo(Address Address)
        {
            if (Address == null)
            {
                return;
            }
            if (Address.Index != 0)
            {
                PostIndexTextBox.Text = Convert.ToString(Address.Index);
            }
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }
         
        /// <summary>
        /// 
        /// </summary>
        public void ClearAddressTextBox()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        public void SwitchAccessTextBox(bool flag)
        {
            PostIndexTextBox.Enabled = flag;
            CountryTextBox.Enabled = flag;
            CityTextBox.Enabled = flag;
            StreetTextBox.Enabled = flag;
            BuildingTextBox.Enabled = flag;
            ApartmentTextBox.Enabled = flag;
        }
    }

}
