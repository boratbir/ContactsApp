using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ContactsApp.Models;

namespace ContactsApp
{
    /// <summary>
    /// Класс проекта. Хранит в себе список контактов.
    /// </summary>
    public class Project : IEquatable<Project>
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
        public List<Contact> Find(string substring = "") => Contacts
            .Where(i => i.LastName.StartsWith(substring))
            .OrderBy(k => k.LastName)
            .ToList();

        /// <summary>
        /// Возвращает список именинников.
        /// </summary>
        public List<Contact> BirthdayPeople => Contacts?
            .Where(i => 
                i.Birthday.Day == DateTime.Today.Day && 
                i.Birthday.Month == DateTime.Today.Month)
            .OrderBy(k => k.LastName)
            .ToList();

        public bool Equals(Project other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Contacts.SequenceEqual(other.Contacts);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Project) obj);
        }

        public override int GetHashCode()
        {
            return (Contacts != null ? Contacts.GetHashCode() : 0);
        }
    }
}