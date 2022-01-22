using System;

namespace ContactsApp
{
    public class ProjectManager
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
    }
}