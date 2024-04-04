using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace View.Converters
{
    /// <summary>
    /// Хранит методы по преобразованию значения типа <see cref="bool"/> к 
    /// типу <see cref="Visibility"/> и обратно.
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Преобразует значение типа <see cref="bool"/> к типу <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение, которое надо преобразовать.</param>
        /// <param name="targetType">Тип, к которому надо преобразовать значение.</param>
        /// <param name="parameter">Вспомогательный параметр.</param>
        /// <param name="culture">Текущая культура приложения.</param>
        /// <returns>Значение типа <see cref="Visibility"/>.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        /// <summary>
        /// Преобразует значение типа <see cref="Visibility"/> к типу <see cref="bool"/>.
        /// </summary>
        /// <param name="value">Значение, которое надо преобразовать.</param>
        /// <param name="targetType">Тип, к которому надо преобразовать значение.</param>
        /// <param name="parameter">Вспомогательный параметр.</param>
        /// <param name="culture">Текущая культура приложения.</param>
        /// <returns>Пустое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
