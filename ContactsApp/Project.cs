using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        public List<Contact> Contacts { get; } = new List<Contact>();

        /// <summary>
        /// Осуществляет поиск по контактам.
        /// </summary>
        /// <param name="substring">Подстрока для поиска по фамилиям.</param>
        /// <returns>Список контактов, чья фамилия начинается с заданной подстроки.</returns>
        public List<Contact> Find(string substring) => Contacts
            .Where(i => i.LastName.StartsWith(substring))
            .ToList();
    }
}