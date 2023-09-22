using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы по сериализации и десериализации данных. 
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="items">Данные, которые необходимо сохранить.</param>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>. </param>
        /// <param name="fileName">Файл, в котором будут сохранены данные.</param>
        public static void SaveToFile(List<Item> items, string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string itemsString = JsonSerializer.Serialize(items);
            File.WriteAllText($"{directoryPath}/{fileName}", itemsString);
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <param name="directoryPath">Путь к файлу <see cref="fileName"/>.</param>
        /// <param name="fileName">Файл, из которого будут загружены данные.</param>
        /// <returns>Возвращает коллекцию загруженных данных.</returns>
        public static List<Item> LoadFromFile(string directoryPath, string fileName)
        {
            List<Item> items = new List<Item>();
            if (File.Exists($"{directoryPath}/{fileName}"))
            {
                var itemsString = File.ReadAllText($"{directoryPath}/{fileName}");
                items = JsonSerializer.Deserialize<List<Item>>(itemsString);
            }

            return items;
        }
    }
}
