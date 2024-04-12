using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Shapes;
using View.ViewModel;

namespace View.Model.Services
{
    /// <summary>
    /// Хранит методы по сериализации и десериализации данных. 
    /// </summary>
    class ContactSerializer
    {
        /// <summary>
        /// Путь до папки.
        /// </summary>
        private static string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Contacts";

        /// <summary>
        /// Название файла, в котором хранятся данные.
        /// </summary>
        private static string _fileName = "contacts.json";

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="contacts">Список контактов, которые необходимо сохранить.</param>
        public static void SaveToFile(ObservableCollection<ContactVM> contacts)
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            using (StreamWriter file = File.CreateText($"{_directoryPath}/{_fileName}"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, contacts);
            }
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns>Возвращает список контактов.</returns>
        public static ObservableCollection<ContactVM> LoadFromFile()
        {
            ObservableCollection<ContactVM> contacts = new ObservableCollection<ContactVM>();
            try
            {
                if (File.Exists($"{_directoryPath}/{_fileName}"))
                {
                    using (StreamReader file = File.OpenText($"{_directoryPath}/{_fileName}"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        contacts = (ObservableCollection<ContactVM>)serializer.Deserialize(file,
                            typeof(ObservableCollection<ContactVM>));
                    }
                    if (contacts == null)
                    {
                        contacts = new ObservableCollection<ContactVM>();
                    }
                }
            }
            catch
            {
                SaveToFile(contacts);
            }

            return contacts;
        }
    }
}
