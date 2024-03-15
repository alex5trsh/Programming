using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

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
        /// <param name="contact">Объект контакта, который необходимо сохранить.</param>
        public static void SaveToFile(Contact contact)
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
            using (StreamWriter writer = new StreamWriter($"{_directoryPath}/{_fileName}"))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <returns>Возвращает объект контакта.</returns>
        public static Contact LoadFromFile()
        {
            Contact contact = new Contact();
            if (File.Exists($"{_directoryPath}/{_fileName}"))
            {
                using (StreamReader reader = new StreamReader($"{_directoryPath}/{_fileName}"))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
                }

                if (contact == null)
                {
                    contact = new Contact();
                }
            }

            return contact;
        }
    }
}
