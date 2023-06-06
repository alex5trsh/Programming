using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppPlaces.PlaceModel
{
    /// <summary>
    /// Хранит методы по сериализации и десериализации данных. 
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="places">Данные, которые необходимо сохранить.</param>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>. </param>
        /// <param name="fileName">Файл, в котором будут сохранены данные.</param>
        public static void SaveToFile(List<Place> places, string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // TODO: лишние табы(+)
            string _placesString = JsonSerializer.Serialize(places);
            File.WriteAllText($"{directoryPath}/{fileName}", _placesString);
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>.</param>
        /// <param name="fileName">Файл, из которого будут загружены данные.</param>
        /// <returns>Возвращает коллекцию загруженных данных.</returns>
        public static List<Place> LoadFromFile(string directoryPath, string fileName)
        {
            List<Place> places = new List<Place>();
            if (File.Exists($"{directoryPath}/{fileName}"))
            {
                var _placesString = File.ReadAllText($"{directoryPath}/{fileName}");
                places = JsonSerializer.Deserialize<List<Place>>(_placesString);
            }

            return places;
        }
    }

}
