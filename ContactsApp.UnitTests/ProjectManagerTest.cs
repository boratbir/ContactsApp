using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тест класса ProjectManager
    /// </summary>
    [TestFixture]
    public class ProjectManagerTest
    {
        /// <summary>
        /// Путь до папки AppData текущего пользователя.
        /// </summary>
        private static string AppDataFolder =>
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + '\\';

        /// <summary>
        /// Путь до папки приложения.
        /// </summary>
        private static string ContactsAppFolder =>
            AppDataFolder + @"ContactsApp\";

        /// <summary>
        /// Путь до файла приложения.
        /// </summary>
        private static string ProjectFilePath =>
            ContactsAppFolder + "Contacts.notes";

        /// <summary>
        /// Файл бэкапа.
        /// </summary>
        private static string BackupFile =>
            ProjectFilePath + ".backup";

        private Project _project;

        [SetUp]
        public void Init()
        {
            // Резервное копирование существующего файла контактов
            if (System.IO.File.Exists(ProjectFilePath))
                System.IO.File.Move(ProjectFilePath, BackupFile);
            System.IO.File.Delete(ProjectFilePath);
            
            // Инициализация
            _project = new Project();
            
            var c1 = new Contact()
            {
                LastName = "Первый",
                FirstName = "Контакт",
                Birthday = new DateTime(1991,2,1),
                Email = "kontakt1@mail.ru",
                VkId = "kontakt1",
                PhoneNumber = 72222222222
            };
            
            var c2 = new Contact()
            {
                LastName = "Второй",
                FirstName = "Контакт",
                Birthday = new DateTime(1992, 1, 27),
                Email = "kontakt2@mail.ru",
                VkId = "kontakt2",
                PhoneNumber = 71111111111
            };

            _project.Contacts.Add(c1);
            _project.Contacts.Add(c2);
        }

        [TearDown]
        public void TearDown()
        {
            if (System.IO.File.Exists(ProjectFilePath))
                System.IO.File.Delete(ProjectFilePath);
            // Восстановление из резервной копии
            if (System.IO.File.Exists(BackupFile))
            {
                System.IO.File.Move(BackupFile, ProjectFilePath);
                System.IO.File.Delete(BackupFile);
            }
        }
        
        /// <summary>
        /// Негативный тест. Загрузка ложных данных.
        /// </summary>
        [Test(Description = "Негативный тест. Загрузка ложных данных.")]
        public void ProjectManagerReadNegative()
        {
            Assert.Throws<Exception>(() =>
            {
                var text = "WRONG TEXT";
                File.WriteAllText(ProjectFilePath, text);
                ProjectManager.ReadProject();
            });
        }

        /// <summary>
        /// Позитивный тест записи и чтения проекта.
        /// </summary>
        [Test(Description = "Позитивный тест записи и чтения проекта.")]
        public void ProjectManagerSaveAndReadPositive()
        {
            _project.SaveProject();
            var actual = ProjectManager.ReadProject();
            var equals = actual.Equals(_project);
            Assert.IsTrue(equals, "Записанные и прочитанные данные не совпадают.");
        }
    }
}