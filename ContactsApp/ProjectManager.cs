using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using File = System.IO.File;

namespace ContactsApp
{
    /// <summary>
    /// Менеджер проекта, с помощью которого осуществляется чтение и запись
    /// списка контактов на диск.
    /// </summary>
    public static class ProjectManager
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
        /// Читает текст из файла.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Текст в кодировке UTF8.</returns>
        /// <exception cref="Exception">Произошла ошибка чтения.</exception>
        private static string ReadFile(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    return "";
                }
                var bytes = File.ReadAllBytes(path);
                var text = Encoding.UTF8.GetString(bytes);
                return text;
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось прочитать файл проекта.", e);
            }
        }

        /// <summary>
        /// Записывает текст в файл. Если файла нет, то он будет создан.
        /// Если есть, то его содержимое будет перезаписано.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <param name="path">Путь до файла.</param>
        /// <exception cref="Exception">Произошла ошибка записи.</exception>
        private static void WriteFile(string text, string path)
        {
            try
            {
                var bytes = Encoding.UTF8.GetBytes(text);
                File.WriteAllBytes(path, bytes);
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось записать файл.", e);
            }
        }
        
        /// <summary>
        /// Загружает проект из файла.
        /// </summary>
        /// <returns>Объект проекта со списком контактов.</returns>
        /// <exception cref="Exception">Произошла ошибка чтения файла проекта.</exception>
        public static Project ReadProject()
        {
            try
            {
                // Папка проекта создаётся, если её не существует.
                Directory.CreateDirectory(ContactsAppFolder);
                var text = ReadFile(ProjectFilePath);
                var project = JsonConvert.DeserializeObject<Project>(text);
                return project ?? new Project();
            }
            catch (Exception e)
            {
                throw new Exception("Произошла ошибка чтения списка контактов.", e);
            }
        }

        /// <summary>
        /// Сохраняет проект в файл.
        /// </summary>
        /// <param name="project">Объект проекта.</param>
        /// <exception cref="Exception">Бросается при ошибке сохранения.</exception>
        public static void SaveProject(this Project project)
        {
            try
            {
                var text = JsonConvert.SerializeObject(project);
                WriteFile(text, ProjectFilePath);
            }
            catch (Exception e)
            {
                throw new Exception("Не удалось записать файл проекта.", e);
            }
        }
    }
}