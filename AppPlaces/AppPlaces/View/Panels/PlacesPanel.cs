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

namespace AppPlaces.View.Panels
{
    public partial class PlacesPanel : UserControl
    {
        string path = "C:/Users/User/source/repos/Programming/AppPlaces/AppPlaces/Places.txt";

        List<Place> _places = new List<Place>();

        Place _currentPlace= new Place();

        int _index;

        int _flagClickedButton=0;

        public PlacesPanel()
        {
            InitializeComponent();


            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] _splitLine = line.Split(' ');
                    string _originalName = _splitLine[0];
                    string _originalAddress = _splitLine[1];
                    Category _originalCategory = (Category)Enum.Parse(typeof(Category), _splitLine[2]);
                    double _originalRating = Convert.ToDouble(_splitLine[3]);
                    Place _originalPlace = new Place(_originalName, _originalAddress,
                        _originalCategory, _originalRating);
                    _places.Add(_originalPlace);
                    PlacesListBox.Items.Add(_originalPlace.Category + " - " + _originalPlace.Name);
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
            _currentPlace.Category,_currentPlace.Rating);
            _currentPlace.Name = _copyPlace.Name;
            _currentPlace.Address = _copyPlace.Address;
            _currentPlace.Category = _copyPlace.Category;
            _currentPlace.Rating = _copyPlace.Rating;

            ApplyButton.Visible = true;
            _flagClickedButton = 1;

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
           
            //    using (StreamWriter writer = new StreamWriter(path, true))
            //    {
            //        writer.WriteLine(_newPlace.Name + " " + _newPlace.Address + " " + _newPlace.Category
            //            + " " + _newPlace.Rating);
            //    }
            if(_index==-1)
            {
                _places.Add(_currentPlace);
                PlacesListBox.Items.Add(_currentPlace.Category + " - " + _currentPlace.Name);

                ApplyButton.Visible = false;
                _flagClickedButton = 0;

            }
            if (_index>=0)
            {
                _places[_index] = _currentPlace;
                PlacesListBox.Items[_index] = (_currentPlace.Category + " - "
                + _currentPlace.Name);
                

                ApplyButton.Visible = false;
                _flagClickedButton = 0;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PlacesListBox.SelectedIndex >= 0 && PlacesListBox != null)
            {
                int choosenIndex = PlacesListBox.SelectedIndex;
                PlacesListBox.Items.RemoveAt(choosenIndex);
                _places.RemoveAt(choosenIndex);
                ClearPlacesInfo();
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
        //может быть так что текстбоксы изменяют без нажатия кнопки edit или add

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
            CategoryComboBox.Text = null;
            RatingTextBox.Clear();
        }

        
    }
}
