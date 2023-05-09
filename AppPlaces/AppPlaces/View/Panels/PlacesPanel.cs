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

namespace AppPlaces.View.Panels
{
    public partial class PlacesPanel : UserControl
    {
            
        List<Place> _places = new List<Place>();

        Place _currentPlace= new Place();

        public PlacesPanel()
        {
            InitializeComponent();

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

            ApplyButton.Visible = true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != null && AddressTextBox.Text != null
                && CategoryComboBox.Text!=null && RatingTextBox.Text!=null)
            {
                Place _newPlace = new Place();
                UpdatePlaceInfo(_newPlace);
                PlacesListBox.Items.Add(_newPlace.Category + " - " + _newPlace.Name);
                _places.Add(_newPlace);

                ApplyButton.Visible = false;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ///TODO:написать метод ChangePlace
            if(_currentPlace.Name !=NameTextBox.Text)
            {
                _currentPlace.Name = NameTextBox.Text;
            }

            if (_currentPlace.Address != AddressTextBox.Text)
            {
                _currentPlace.Address = AddressTextBox.Text;
            }

            if (_currentPlace.Category != (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text))
            {
                _currentPlace.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
            }

            if (_currentPlace.Rating != Convert.ToDouble(RatingTextBox.Text))
            {
                _currentPlace.Rating = Convert.ToDouble(RatingTextBox.Text);
            }

            PlacesListBox.Items[PlacesListBox.SelectedIndex] = (_currentPlace.Category + " - "
            + _currentPlace.Name);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0 && PlacesListBox != null)
            {
                int choosenIndex = PlacesListBox.SelectedIndex;
                PlacesListBox.Items.RemoveAt(choosenIndex);
                _places.RemoveAt(choosenIndex);
            }
        }

        private void PlacesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0)
            {
                int selectedIndex = PlacesListBox.SelectedIndex;
                _currentPlace = _places[selectedIndex];
                UpdatePlaceInfo(_currentPlace);
            }
        }

        /// <summary>
        /// Обновляет данные по указанному объекту в текстовых полях.
        /// </summary>
        /// <param name="rectangle">Название объекта, данные которого необходимо обновить.</param>
        private void UpdatePlaceInfo(Place place)
        {
            place.Name = NameTextBox.Text;
            place.Address = AddressTextBox.Text;
            place.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
            place.Rating = Convert.ToDouble(RatingTextBox.Text);
        }

        /// <summary>
        /// Очищает все текстовые поля со значениями объекта.
        /// </summary>
        private void ClearPlacesInfo()
        {
            NameTextBox.Clear();
            AddressTextBox.Clear();
            CategoryComboBox.Text = "";
            RatingTextBox.Clear();
        }


    }
}
