using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тест класса Contact
    /// </summary>
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        /// <summary>
        /// Конструктор теста Contact
        /// </summary>
        [SetUp]
        public void Init()
        {
            // Создание нового пустого контакта
            _contact = new Contact();
        }

        /// <summary>
        /// Позитивный тест геттера LastName.
        /// </summary>
        [Test(Description = "Позитивный тест геттера LastName.")]
        public void LastNameGetPositive()
        {
            var lastName = "ФАМИЛИЯ";
            _contact.LastName = lastName;
            var actual = _contact.LastName;
            Assert.AreEqual(lastName, _contact.LastName, "Геттер LastName вернул неправильное значение");
        }

        /// <summary>
        /// Негативный тест сеттера LastName. Присваивается длинная фамилия.
        /// </summary>
        [Test(Description = "Негативный тест сеттера LastName. Присваивается длинная фамилия.")]
        public void LastNameSetTooLongValue()
        {
            var value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.Throws<ArgumentException>(() => { _contact.LastName = value; });
        }
        
        /// <summary>
        /// Позитивный тест геттера FirstName.
        /// </summary>
        [Test(Description = "Позитивный тест геттера FirstName.")]
        public void FirstNameGetPositive()
        {
            var firstName = "ИМЯ";
            _contact.FirstName = firstName;
            Assert.AreEqual(firstName, _contact.FirstName, "Геттер FirstName вернул неправильное значение");
        }

        /// <summary>
        /// Негативный тест сеттера FirstName. Присваивается длинное имя.
        /// </summary>
        [Test(Description = "Негативный тест сеттера FirstName. Присваивается длинное имя.")]
        public void FirstNameSetTooLongValue()
        {
            var value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.Throws<ArgumentException>(() => { _contact.FirstName = value; });
        }
        
        /// <summary>
        /// Позитивный тест геттера Email.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email.")]
        public void EmailGetPositive()
        {
            var mail = "МЫЛО СОБАКА ЯНДЕКС РУ";
            _contact.Email = mail;
            Assert.AreEqual(mail, _contact.Email, "Геттер Email вернул неправильное значение.");
        }
        
        /// <summary>
        /// Негативный тест сеттера Email. Присваивается слишком длинный Email.
        /// </summary>
        [Test(Description = "Негативный тест сеттера Email. Присваивается слишком длинный Email.")]
        public void EmailSetTooLongValue()
        {
            var value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.Throws<ArgumentException>(() => { _contact.Email = value; });
        }
        
        /// <summary>
        /// Позитивный тест геттера ID ВК.
        /// </summary>
        [Test(Description = "Позитивный тест геттера ID ВК.")]
        public void VkIdGetPositive()
        {
            var id = "ID VK";
            _contact.VkId = id;
            Assert.AreEqual(id, _contact.VkId, "Геттер VkId вернул неправильное значение.");
        }
        
        /// <summary>
        /// Негативный тест сеттера Email. Присваивается слишком длинный Email.
        /// </summary>
        [Test(Description = "Негативный тест сеттера Email. Присваивается слишком длинный Email.")]
        public void VkIdSetTooLongValue()
        {
            var value = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.Throws<ArgumentException>(() => { _contact.VkId = value; });
        }
        
        /// <summary>
        /// Позитивный тест геттера PhoneNumber.
        /// </summary>
        [Test(Description = "Позитивный тест геттера PhoneNumber.")]
        public void PhoneNumberGetPositive()
        {
            var phone = 71234567890;
            _contact.PhoneNumber = phone;
            Assert.AreEqual(phone, _contact.PhoneNumber, "Геттер PhoneNumber вернул неправильное значение.");
        }
        
        /// <summary>
        /// Позитивный тест геттера Birthday.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday.")]
        public void BirthdayGetPositive()
        {
            var date = new DateTime(1950,1,1);
            _contact.Birthday = date;
            Assert.AreEqual(date, _contact.Birthday, "Геттер Birthday вернул неправильное значение.");
        }

        /// <summary>
        /// Негативный тест сеттера Birthday. Присваивается некорректная дата.
        /// </summary>
        /// <param name="incorrect">Неправильная дата.</param>
        /// <param name="message">Ошибка</param>
        [TestCase("1.1.5000",
            "Слишком большая дата.",
            TestName = "Негативный тест сеттера Birthday: слишком большая дата.")]
        [TestCase("1.1.1000",
            "Слишком маленькая дата.",
            TestName = "Негативный тест сеттера Birthday: слишком маленькая дата.")]

        
        
        public void BirthdaySetNegative(string incorrect, string message)
        {
            var date = DateTime.Parse(incorrect);
            Assert.Throws<ArgumentException>(() => _contact.Birthday = date);
        }
    }
}