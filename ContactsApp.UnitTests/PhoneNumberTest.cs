using System;
using ContactsApp.Models;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    /// <summary>
    /// Тест класса PhoneNumber
    /// </summary>
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _phoneNumber;
        
        [SetUp]
        public void Init()
        {
            // Создание нового пустого номера телефона
            _phoneNumber = new PhoneNumber();
        }
        
        /// <summary>
        /// Позитивный тест геттера Number.
        /// </summary>
        [Test(Description = "Позитивный тест геттера Number.")]
        public void NumberGetPositive()
        {
            var num = 78005553535;
            _phoneNumber.Number = num;
            Assert.AreEqual(num,_phoneNumber.Number, "Геттер Number вернул неверное значение.");
        }

        /// <summary>
        /// Негативный тест сеттера Number.
        /// </summary>
        /// <param name="num">Номер телефона.</param>
        /// <param name="message">Ошибка.</param>
        [TestCase("1111111112323233",
            "Присвоение слишком большого значения.",
            TestName = "Негативный тест сеттера Number. Слишком большое число.")]
        [TestCase("1",
            "Присвоение слишком маленького значения.",
            TestName = "Негативный тест сеттера Number. Слишком большое число.")]
        [TestCase("-100",
            "Присвоение отрицательного значения.",
            TestName = "Негативный тест сеттера Number. Отрицательное число.")]
        [TestCase("0",
            "Присвоение нуля.",
            TestName = "Негативный тест сеттера Number. Ноль.")]
        [Test(Description = "Негативный тест сеттера Number.")]
        public void NumberSetNegative(string num, string message)
        {
            var phone = long.Parse(num);
            Assert.Throws<ArgumentException>(() => { _phoneNumber.Number = phone; });
        }
    }
}