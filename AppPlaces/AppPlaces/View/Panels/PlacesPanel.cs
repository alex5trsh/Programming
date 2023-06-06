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
using AppPlaces.PlaceModel;

namespace AppPlaces.View.Panels
{
    /// <summary>
    /// Предоставляет методы вывода даных текущего элемента, его изменения, удаления, добавления,
    /// а также сортировки всех элементов.
    /// </summary>
    public partial class PlacesPanel : UserControl
    {
	    // TODO: модификаторы доступа
        /// <summary>
        /// Коллекция элементов класс <see cref="Place"/>.
        /// </summary>
        List<Place> _places = new List<Place>();

        /// <summary>
        /// Текущий элемент класса <see cref="Place"/>.
        /// </summary>
        Place _currentPlace= new Place();

		// TODO: _currentIndex
		/// <summary>
		/// Индекс текущего элемента.
		/// </summary>
		int _index;

        /// <summary>
        /// Флаг нажатия на кнопку <see cref="AddButton"/> или <see cref="EditButton"/>.
        /// True если одна из кнопок нажата, false если ни одна из кнопок не нажата.
        /// </summary>
        bool _isButtonClicked = false;


        /// <summary>
        /// Путь к файлу <see cref="_fileName"/>.
        /// </summary>
        private string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.
            ApplicationData)+"\\AppPlaces";

        /// <summary>
        /// Файл, хранящий объекты класса <see cref="Place"/>.
        /// </summary>
        private string _fileName = "Places.json";

        /// <summary>
        /// Копия текущего элемента класса <see cref="Place"/>.
        /// </summary>
        Place _copyPlace = new Place();


        public PlacesPanel()
        {
            InitializeComponent();

            _places =ProjectSerializer.LoadFromFile(_directoryPath, _fileName);
            foreach (var value in _places)
            {
                PlacesListBox.Items.Add(value.Category + " - " + value.Name);
            } 

            var categories = Enum.GetValues(typeof(Category));
            foreach (var value in categories)
            {
                CategoryComboBox.Items.Add(value);
            }

            ApplyButton.Visible = false;
            CancelButton.Visible = false;
            NameErrorLabel.Visible = false;
            AddressErrorLabel.Visible = false;
            CategoryErrorLabel.Visible = false;
            RatingErrorLabel.Visible = false;

            AccessTextBox(false);
        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "New Name";
            AddressTextBox.Text = "New Address";
            CategoryComboBox.SelectedIndex = 0;
            RatingTextBox.Text = "0";
            _index = -1;
            _isButtonClicked = true;

            PlacesListBox.Enabled = false;
            AccessTextBox(true);
            UnhideButtons(false);
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.Items.Count!=0 && PlacesListBox.SelectedIndex>=0)
            {
                _copyPlace.Name=_currentPlace.Name;
                _copyPlace.Address = _currentPlace.Address;
                _copyPlace.Category = _currentPlace.Category;
                _copyPlace.Rating = _currentPlace.Rating;

                _isButtonClicked = true;
                PlacesListBox.Enabled = false;
                AccessTextBox(true);
                UnhideButtons(false);
            }

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (_index == -1)
            {
                _places.Add(_currentPlace);
                PlacesListBox.Items.Add(_currentPlace.Category + " - " + _currentPlace.Name);
            }

            if (_index >= 0 && _currentPlace != _copyPlace)
            {
                _places[_index] = _currentPlace;
                PlacesListBox.Items[_index] = (_currentPlace.Category + " - "
                + _currentPlace.Name);
            }
            _copyPlace.Name = _currentPlace.Name;
            _copyPlace.Address = _currentPlace.Address;
            _copyPlace.Category = _currentPlace.Category;
            _copyPlace.Rating = _currentPlace.Rating;

            SortPlaces(_places);
            //TODO: в листбоксе должен выделяться созданный/измененный объект
            for (int i = 0; i < _places.Count; i++)
            {
                if (_places[i] == _copyPlace)
                {
                    PlacesListBox.SelectedIndex = i;
                }
            }
            ProjectSerializer.SaveToFile(_places, _directoryPath, _fileName);
            _isButtonClicked = false;
            PlacesListBox.Enabled = true;
            AccessTextBox(false);
            UnhideButtons(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0 && PlacesListBox != null)
            {
                // TODO: грамматическая ошибка
                int choosenIndex = PlacesListBox.SelectedIndex;
                PlacesListBox.Items.RemoveAt(choosenIndex);
                _places.RemoveAt(choosenIndex);
                ClearPlacesInfo();
                ProjectSerializer.SaveToFile(_places, _directoryPath, _fileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _isButtonClicked = false;
            PlacesListBox.Enabled = true;
            UnhideButtons(true);
            AccessTextBox(false);
            if (_index>=0)
            {
                _currentPlace.Name = _copyPlace.Name;
                _currentPlace.Address = _copyPlace.Address;
                _currentPlace.Category = _copyPlace.Category;
                _currentPlace.Rating = _copyPlace.Rating;
                PlacesListBox.SelectedIndex = _places.IndexOf(_currentPlace);
                UpdatePlaceInfo(_currentPlace);
            }
            else
            {
                ClearPlacesInfo();
                NameTextBox.BackColor = Color.White;
                AddressTextBox.BackColor = Color.White;
                CategoryComboBox.BackColor = Color.White;
                RatingTextBox.BackColor = Color.White;
                NameErrorLabel.Visible = false;
                AddressErrorLabel.Visible = false;
                CategoryErrorLabel.Visible = false;
                RatingErrorLabel.Visible = false;
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
            try
            {
                if (_currentPlace.Name != NameTextBox.Text)
                {
                    _currentPlace.Name = NameTextBox.Text;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                }
                
                NameTextBox.BackColor = Color.White;
                NameErrorLabel.Visible = false;
                
            }
            catch
            {
                ApplyButton.Visible = false;
                if (NameTextBox.Enabled == true)
                { 
                    NameTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameErrorLabel.Visible = true;
                }
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentPlace.Address != AddressTextBox.Text)
                {
                    _currentPlace.Address = AddressTextBox.Text;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                }

                AddressTextBox.BackColor = Color.White;
                AddressErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (AddressTextBox.Enabled == true)
                {
                    AddressTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    AddressErrorLabel.Visible = true;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentPlace.Category != (Category)Enum.Parse(typeof(Category),
                        CategoryComboBox.Text))
                {
                    _currentPlace.Category = (Category)Enum.Parse(typeof(Category),
                        CategoryComboBox.Text);
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                }
                CategoryComboBox.BackColor = Color.White;
                CategoryErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (CategoryComboBox.Enabled == true)
                {
                    CategoryComboBox.BackColor = Color.FromArgb(205, 92, 92);
                    CategoryErrorLabel.Visible = true;
                }
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
       {
            try
            {
                if (_currentPlace.Rating != Convert.ToDouble(RatingTextBox.Text))
                {
                    _currentPlace.Rating = Convert.ToDouble(RatingTextBox.Text);
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                }

                RatingTextBox.BackColor = Color.White;
                RatingErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (RatingTextBox.Enabled == true)
                {
                    RatingTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    RatingErrorLabel.Visible = true;
                }
                
            }
        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="place">Название объекта, данные которого необходимо обновить.</param>
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
        private void SortPlaces(List<Place> places)
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
                        places.RemoveAt(j);
                        places.Insert(j, places[i]);
                        places.RemoveAt(i);
                        places.Insert(i, temp);
                        PlacesListBox.Items[i] = (places[i].Category + " - "
                         + places[i].Name);
                        PlacesListBox.Items[j] = (places[j].Category + " - "
                         + places[j].Name);
                    }
					// TODO: else if {ваш код}
					else
					{
                        if (String.Compare(_firstCategory, _secondCategory) == 0)
                        {
                            string _firstName =places[i].Name;
                            string _secondName = places[j].Name;
                            if (String.Compare(_firstName, _secondName) > 0)
                            {
                                Place temp = places[j];
                                places.RemoveAt(j);
                                places.Insert(j, places[i]);
                                places.RemoveAt(i);
                                places.Insert(i,temp);
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

        /// <summary>
        /// Задает свойство видимости для кнопок.
        /// </summary>
        /// <param name="flag">Значение свойства видимости. Равно true или false.</param>
        private void UnhideButtons(bool flag)
        {
            AddButton.Visible = flag;
            EditButton.Visible = flag;
            DeleteButton.Visible = flag;
            ApplyButton.Visible = !flag;
            CancelButton.Visible = !flag;
        }

        /// <summary>
        /// Задает свойство доступа для текстбоков. 
        /// </summary>
        /// <param name="flag">Значение свойства доступа. Равно true или false.</param>
        private void AccessTextBox(bool flag)
        {
            NameTextBox.Enabled = flag;
            AddressTextBox.Enabled = flag;
            CategoryComboBox.Enabled = flag;
            RatingTextBox.Enabled = flag;
        }
        
    }
}
