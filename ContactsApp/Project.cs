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

        public List<Contact> Find(string substring) => Contacts
            .Where(i => i.LastName.StartsWith(substring))
            .ToList();
    }
}