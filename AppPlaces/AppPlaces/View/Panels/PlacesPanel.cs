using PlacesApp.PlaceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace AppPlaces.View.Panels
{
    /// <summary>
    /// Предоставляет методы вывода даных текущего элемента, его изменения, удаления, добавления,
    /// а также сортировки всех элементов.
    /// </summary>
    public partial class PlacesPanel : UserControl
    {
        /// <summary>
        /// Коллекция элементов класс <see cref="Place"/>.
        /// </summary>
        List<Place> _places = new List<Place>();

        /// <summary>
        /// Текущий элемент класса <see cref="Place"/>.
        /// </summary>
        Place _currentPlace= new Place();

        /// <summary>
        /// Индекс текущего элемента.
        /// </summary>
        int _index;

        /// <summary>
        /// Флаг нажатия на кнопку <see cref="AddButton"/> или <see cref="EditButton"/>. 
        /// Должен быть равен 1 или 0.
        /// </summary>
        int _flagClickedButton=0;

        /// <summary>
        /// Файл, хранящий объекты класса <see cref="Place"/>.
        /// </summary>
        string filePlaces = "Places.json";

        public PlacesPanel()
        {
            InitializeComponent();

            if (File.Exists(filePlaces))
            {
                    var _placesString = File.ReadAllText(filePlaces);
                    _places = JsonSerializer.Deserialize<List<Place>>(_placesString);

                    foreach (var value in _places)
                    {
                        PlacesListBox.Items.Add(value.Category + " - " + value.Name);
                    } 
            }

            var categories = Enum.GetValues(typeof(Category));
            foreach (var value in categories)
            {
                CategoryComboBox.Items.Add(value);
            }

            ApplyButton.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearPlacesInfo();
            _index = -1;
            _currentPlace = new Place();

            ApplyButton.Visible = true;
            _flagClickedButton = 1;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Place _copyPlace = new Place(_currentPlace.Name, _currentPlace.Address,
            _currentPlace.Category, _currentPlace.Rating);
            _currentPlace.Name = _copyPlace.Name;
            _currentPlace.Address = _copyPlace.Address;
            _currentPlace.Category = _copyPlace.Category;
            _currentPlace.Rating = _copyPlace.Rating;

            ApplyButton.Visible = true;
            _flagClickedButton = 1;

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if(_index==-1)
            {
                _places.Add(_currentPlace);
                PlacesListBox.Items.Add(_currentPlace.Category + " - " + _currentPlace.Name);
                string _placesString = JsonSerializer.Serialize(_places);
                File.WriteAllText(filePlaces, _placesString);

                ApplyButton.Visible = false;
                _flagClickedButton = 0;

            }

            if (_index>=0)
            {
                _places[_index] = _currentPlace;
                PlacesListBox.Items[_index] = (_currentPlace.Category + " - "
                + _currentPlace.Name);
                string _placesString = JsonSerializer.Serialize(_places);
                File.WriteAllText(filePlaces, _placesString);


                ApplyButton.Visible = false;
                _flagClickedButton = 0;
            }

            SortedPlaces(_places);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0 && PlacesListBox != null)
            {
                int choosenIndex = PlacesListBox.SelectedIndex;
                PlacesListBox.Items.RemoveAt(choosenIndex);
                _places.RemoveAt(choosenIndex);
                ClearPlacesInfo();
                string _placesString = JsonSerializer.Serialize(_places);
                File.WriteAllText(filePlaces, _placesString);
            }
        }


        private void PlacesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0)
            {
                _index = PlacesListBox.SelectedIndex;
                _currentPlace = _places[_index];
                UpdatePlaceInfo(_currentPlace);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_flagClickedButton == 1)
            {
                try
                {
                    if (_currentPlace.Name != NameTextBox.Text)
                    {
                        _currentPlace.Name = NameTextBox.Text;
                    }

                    NameTextBox.BackColor = Color.White;
                }
                catch
                {
                    NameTextBox.BackColor = Color.Red;
                }
            }

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_flagClickedButton == 1)
            {
                try
                {
                    if (_currentPlace.Address != AddressTextBox.Text)
                    {
                        _currentPlace.Address = AddressTextBox.Text;
                    }

                    AddressTextBox.BackColor = Color.White;
                }
                catch
                {
                    AddressTextBox.BackColor = Color.Red;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flagClickedButton == 1)
            {
                try
                {
                    if (_currentPlace.Category != (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text))
                    {
                        _currentPlace.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                    }

                    CategoryComboBox.BackColor = Color.White;
                }
                catch
                {
                    CategoryComboBox.BackColor = Color.Red;
                }
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_flagClickedButton == 1)
            {
                try
                {
                    if (_currentPlace.Rating != Convert.ToDouble(RatingTextBox.Text))
                    {
                        _currentPlace.Rating = Convert.ToDouble(RatingTextBox.Text);
                    }

                    RatingTextBox.BackColor = Color.White;
                }
                catch
                {
                    RatingTextBox.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="rectangle">Название объекта, данные которого необходимо обновить.</param>
        private void UpdatePlaceInfo(Place place)
        {
            NameTextBox.Text = place.Name;
            AddressTextBox.Text = place.Address;
            CategoryComboBox.Text = Convert.ToString(place.Category);
            RatingTextBox.Text = Convert.ToString(place.Rating);
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями объекта.
        /// </summary>
        private void ClearPlacesInfo()
        {
            NameTextBox.Clear();
            AddressTextBox.Clear();
            CategoryComboBox.Text=null;
            RatingTextBox.Clear();
        }

        /// <summary>
        /// Сортирует все объекты в <see cref="PlacesListBox"/> по <see cref="Place.Category"/>,
        /// а внутри <see cref="Place.Category"/> сортирует по <see cref="Place.Name"/>.
        /// </summary>
        /// <param name="places">Коллекция, содержащая объекты, которые необходимо 
        /// отсортировать. </param>
        private void SortedPlaces(List<Place> places)
        { 
            for (int i = 0; i < places.Count; i++)
            {
                for (int j = i+1; j < places.Count; j++)
                {
                    string _firstCategory = Convert.ToString(places[i].Category);
                    string _secondCategory = Convert.ToString(places[j].Category);
                    if (String.Compare(_firstCategory, _secondCategory) > 0)
                    {
                        Place temp = places[j];
                        places[j] = places[i];
                        places[i] = temp;
                        PlacesListBox.Items[i] = (places[i].Category + " - "
                         + places[i].Name);
                        PlacesListBox.Items[j] = (places[j].Category + " - "
                         + places[j].Name);
                    }
                    else
                    {
                        if (String.Compare(_firstCategory, _secondCategory) == 0)
                        {
                            string _firstName =places[i].Name;
                            string _secondName = places[j].Name;
                            if (String.Compare(_firstName, _secondName) > 0)
                            {
                                Place temp = places[j];
                                places[j] = places[i];
                                places[i] = temp;
                                PlacesListBox.Items[i] = (places[i].Category + " - "
                                 + places[i].Name);
                                PlacesListBox.Items[j] = (places[j].Category + " - "
                                 + places[j].Name);
                            }
                        }
                    }
                }
            }
                    
            
        }
        //
        
    }
}
