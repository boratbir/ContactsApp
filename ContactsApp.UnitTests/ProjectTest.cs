using System;
using System.Collections.Generic;
using System.Linq;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Юнит-тесты класса Project
    /// </summary>
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;
        
        /// <summary>
        /// Инициализация
        /// </summary>
        [SetUp]
        public void Init()
        {
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

        /// <summary>
        /// Позитивный тест сортировки контактов.
        /// </summary>
        [Test(Description = "Позитивный тест сортировки контактов.")]
        public void SortGetPositive()
        {
            var expected = _project.Contacts
                .OrderBy(i => i.LastName)
                .ToList();
            var actual = _project.Find();
            Assert.AreEqual(expected, actual, "Список контактов неверно отсортирован.");
        }

        /// <summary>
        /// Негативный тест сортировки контактов. Список развёрнут.
        /// </summary>
        [Test(Description = "Негативный тест сортировки контактов. Список развёрнут.")]
        public void SortGetNegative()
        {
            var expected = _project.Contacts
                .OrderBy(i => i.LastName)
                .Reverse()
                .ToList();
            var actual = _project.Find();
            Assert.AreNotEqual(expected, actual, "Список контактов неверно отсортирован.");
        }

        /// <summary>
        /// Позитивный тест поиска контактов.
        /// </summary>
        [Test(Description = "Позитивный тест поиска контактов.")]
        public void FindGetPositive()
        {
            var query = "Первый";
            var expected = _project.Contacts
                .Where(i => i.LastName.StartsWith(query))
                .OrderBy(i => i.LastName)
                .ToList();
            Assert.AreEqual(expected, _project.Find(query), "Списки контактов не совпали.");
        }

        /// <summary>
        /// Негативный тест поиска контактов.
        /// </summary>
        [Test(Description = "Негативный тест поиска контактов.")]
        public void GetFindNegative()
        {
            var expected = new List<Contact>();
            var actual = _project.Find("1234");
            Assert.AreEqual(expected, actual, "Найдены значения, которые не должны быть найдены.");
        }

        /// <summary>
        /// Позитивный тест поиска именинников.
        /// </summary>
        [Test(Description = "Позитивный тест поиска именинников.")]
        public void GetBirthdaysPositive()
        {
            var date = DateTime.Today;
            var expected = _project.Contacts
                .Where(i => i.Birthday.Day == DateTime.Today.Day && i.Birthday.Month == date.Month)
                .OrderBy(i => i.LastName)
                .ToList();
            Assert.AreEqual(expected, _project.BirthdayPeople, "Списки именинников не совпадают");
        }
    }
}