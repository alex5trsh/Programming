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
        /// <summary>
        /// Коллекция элементов класс <see cref="Place"/>.
        /// </summary>
        private List<Place> _places = new List<Place>();

        /// <summary>
        /// Текущий элемент класса <see cref="Place"/>.
        /// </summary>
        private Place _currentPlace= new Place();

        /// <summary>
		/// Индекс текущего элемента.
		/// </summary>
		private int _currentIndex;

        /// <summary>
        /// Флаг нажатия на кнопку <see cref="AddButton"/> или <see cref="EditButton"/>.
        /// True если одна из кнопок нажата, false если ни одна из кнопок не нажата.
        /// </summary>
        private bool _isButtonClicked = false;


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
        private Place _copyPlace = new Place();


        public PlacesPanel()
        {
            InitializeComponent();

            _places =ProjectSerializer.LoadFromFile(_directoryPath, _fileName);
            foreach (var value in _places)
            {
                PlacesListBox.Items.Add(ToString(value));
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

            SwitchAccessTextBox(false);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "New Name";
            AddressTextBox.Text = "New Address";
            CategoryComboBox.SelectedIndex = 0;
            RatingTextBox.Text = "0";
            _currentIndex = -1;
            _isButtonClicked = true;

            PlacesListBox.Enabled = false;
            SwitchAccessTextBox(true);
            SwitchVisibleButtons(false);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.Items.Count!=0 && PlacesListBox.SelectedIndex>=0)
            {
                _isButtonClicked = true;
                PlacesListBox.Enabled = false;
                SwitchAccessTextBox(true);
                SwitchVisibleButtons(false);
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Place _changedPlace = _copyPlace.Clone();
            if (_currentIndex == -1)
            {
                _places.Add(_changedPlace) ;
                PlacesListBox.Items.Add(ToString(_changedPlace));
            }

            if (_currentIndex >= 0 && _changedPlace != _currentPlace)
            {
                _places[_currentIndex] = _changedPlace;
                PlacesListBox.Items[_currentIndex] = ToString(_changedPlace);
            }

            SortPlaces(_places);
            for (int i = 0; i < _places.Count; i++)
            {
                if (_places[i] == _changedPlace)
                {
                    PlacesListBox.SelectedIndex = i;
                }
            }

            ProjectSerializer.SaveToFile(_places, _directoryPath, _fileName);
            _isButtonClicked = false;
            PlacesListBox.Enabled = true;
            SwitchAccessTextBox(false);
            SwitchVisibleButtons(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0 && PlacesListBox != null)
            {
                int chosenIndex = PlacesListBox.SelectedIndex;
                PlacesListBox.Items.RemoveAt(chosenIndex);
                _places.RemoveAt(chosenIndex);
                ClearPlacesInfo();
                ProjectSerializer.SaveToFile(_places, _directoryPath, _fileName);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _isButtonClicked = false;
            PlacesListBox.Enabled = true;
            SwitchVisibleButtons(true);
            SwitchAccessTextBox(false);
            if (_currentIndex >= 0)
            {
                PlacesListBox.SelectedIndex = _places.IndexOf(_currentPlace);
                UpdatePlaceInfo(_currentPlace);
            }
            else
            {
                ClearPlacesInfo();
                PlacesListBox.SelectedIndex = -1;
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
                _currentIndex = PlacesListBox.SelectedIndex;
                _currentPlace = _places[_currentIndex];
                _copyPlace.Name = _currentPlace.Name;
                _copyPlace.Address = _currentPlace.Address;
                _copyPlace.Category = _currentPlace.Category;
                _copyPlace.Rating = _currentPlace.Rating;

                UpdatePlaceInfo(_copyPlace);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                string newName = NameTextBox.Text;
                if (_copyPlace.Name != newName)
                {
                    _copyPlace.Name = newName;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    AddressTextBox.Enabled = true;
                    CategoryComboBox.Enabled = true;
                    RatingTextBox.Enabled = true;
                }

                NameTextBox.BackColor = Color.White;
                NameErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                // TODO: Можно убрать true – if (NameTextBox.Enabled) и так везде(+)
                if (NameTextBox.Enabled)
                {
                    NameTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    NameErrorLabel.Visible = true;
                    AddressTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
                    RatingTextBox.Enabled = false;
                }
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string newAddress = AddressTextBox.Text;
                if (_copyPlace.Address != newAddress)
                {
                    _copyPlace.Address = newAddress;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    NameTextBox.Enabled = true;
                    CategoryComboBox.Enabled = true;
                    RatingTextBox.Enabled = true;
                }

                AddressTextBox.BackColor = Color.White;
                AddressErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (AddressTextBox.Enabled)
                {
                    AddressTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    AddressErrorLabel.Visible = true;
                    NameTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
                    RatingTextBox.Enabled = false;
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: вынести в переменную парс и так везде(+)
                Category newCategory = (Category)Enum.Parse(typeof(Category),
                        CategoryComboBox.Text);
                if (_copyPlace.Category != newCategory)
                {
                    _copyPlace.Category = newCategory;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    NameTextBox.Enabled = true;
                    AddressTextBox.Enabled = true;
                    RatingTextBox.Enabled = true;
                }

                CategoryComboBox.BackColor = Color.White;
                CategoryErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (CategoryComboBox.Enabled)
                {
                    CategoryComboBox.BackColor = Color.FromArgb(205, 92, 92);
                    CategoryErrorLabel.Visible = true;
                    NameTextBox.Enabled = false;
                    AddressTextBox.Enabled = false;
                    RatingTextBox.Enabled = false;
                }
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double newRating = Convert.ToDouble(RatingTextBox.Text);
                if (_copyPlace.Rating != newRating)
                {
                    _copyPlace.Rating = newRating;
                }

                if (_isButtonClicked == true)
                {
                    ApplyButton.Visible = true;
                    NameTextBox.Enabled = true;
                    AddressTextBox.Enabled = true;
                    CategoryComboBox.Enabled = true;
                }

                RatingTextBox.BackColor = Color.White;
                RatingErrorLabel.Visible = false;
            }
            catch
            {
                ApplyButton.Visible = false;
                if (RatingTextBox.Enabled)
                {
                    RatingTextBox.BackColor = Color.FromArgb(205, 92, 92);
                    RatingErrorLabel.Visible = true;
                    NameTextBox.Enabled = false;
                    AddressTextBox.Enabled = false;
                    CategoryComboBox.Enabled = false;
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
            CategoryComboBox.Text = null;
            RatingTextBox.Clear();
        }

        /// <summary>
        /// Сортирует все объекты в PlacesListBox по <see Category,
        /// а внутри Category сортирует по Name.
        /// </summary>
        /// <param name="places">Коллекция, содержащая объекты, которые необходимо 
        /// отсортировать. </param>
        private void SortPlaces(List<Place> places)
        {
            for (int i = 0; i < places.Count; i++)
            {
                for (int j = i + 1; j < places.Count; j++)
                {
                    // TODO: RSDN naming(+)
                    string firstCategory = Convert.ToString(places[i].Category);
                    string secondCategory = Convert.ToString(places[j].Category);
                    // TODO: string.Compare и так везде(+)
                    if (string.Compare(firstCategory, secondCategory) > 0)
                    {
                        // TODO: дубль(+)
                        SwapPlaces(places, i, j);
                        // TODO: переопределить метод ToString в Place и использовать его(+)
                        PlacesListBox.Items[i] = ToString(places[i]);
                        PlacesListBox.Items[j] = ToString(places[j]);
                    }
                    else if (string.Compare(firstCategory, secondCategory) == 0)
                    {
                        string firstName = places[i].Name;
                        string secondName = places[j].Name;
                        if (string.Compare(firstName, secondName) > 0)
                        {
                            // TODO: дубль(+)
                            SwapPlaces(places, i, j);
                            PlacesListBox.Items[i] = ToString(places[i]);
                            PlacesListBox.Items[j] = ToString(places[j]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Задает свойство видимости для кнопок.
        /// </summary>
        /// <param name="flag">Значение свойства видимости. Равно true или false.</param>
        // TODO: SwitchVisibleButtons(bool flag)(+)
        private void SwitchVisibleButtons(bool flag)
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
        // TODO: SwitchAccessTextBox(+)
        private void SwitchAccessTextBox(bool flag)
        {
            NameTextBox.Enabled = flag;
            AddressTextBox.Enabled = flag;
            CategoryComboBox.Enabled = flag;
            RatingTextBox.Enabled = flag;
        }

        /// <summary>
        /// Меняет местами 2 элемента в коллекции.
        /// </summary>
        /// <param name="places">Коллекция, в которой нужно поменять 2 элемента 
        /// местами.</param>
        /// <param name="firstIndex">Первый элемент.</param>
        /// <param name="secondIndex">Второй элемент.</param>
        private void SwapPlaces(List<Place> places, int firstIndex, int secondIndex )
        {
            Place temp = places[secondIndex];
            places.RemoveAt(secondIndex);
            places.Insert(secondIndex, places[firstIndex]);
            places.RemoveAt(firstIndex);
            places.Insert(firstIndex, temp);

        }


        /// <summary>
        /// Создает строку для PlacesListBox.
        /// </summary>
        /// <param name="place">Элемент класса <see cref="Place"/>, по которой нужно
        /// создать строку.</param>
        /// <returns>Возвращает строку со значениями Category и Name указанного 
        /// элемента. </returns>
        private string ToString(Place place)
        {
            string line= place.Category + " - "+ place.Name;

            return line;
        }
    }
}
