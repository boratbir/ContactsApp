using System;

namespace ContactsApp.Models
{
    /// <summary>
    /// Содержит информацию о контакте
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Минимально допустимая дата рождения.
        /// </summary>
        private static readonly DateTime MinDate =
            new DateTime(1900, 1, 1);

        /// <summary>
        /// Максимально допустимая длина строк.
        /// </summary>
        private const int MaxTextLength = 50;

        /// <summary>
        /// Поле фамилии.
        /// </summary>
        private string _lastName = string.Empty;

        /// <summary>
        /// Поле имени.
        /// </summary>
        private string _firstName = string.Empty;

        /// <summary>
        /// Поле даты рождения.
        /// </summary>
        private DateTime _birthday = DateTime.Today;

        /// <summary>
        /// Поле ID ВК.
        /// </summary>
        private string _vkId = string.Empty;

        /// <summary>
        /// Поле адреса электронной почты.
        /// </summary>
        private string _email = string.Empty;

        /// <summary>
        /// Поле номера телефона.
        /// </summary>
        private PhoneNumber _phoneNumber = new PhoneNumber();

        /// <summary>
        /// Имя контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Длина имени больше 50 символов.</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Имя не может быть длиннее 50 символов.");
                _firstName = value;
            }
        }

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Длина фамилии больше 50 символов.</exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Фамилия не может быть длиннее 50 символов.");
                _lastName = value;
            }
        }

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Дата рождения ранее 1.1.1900.</exception>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value < MinDate || value > DateTime.Now)
                    throw new ArgumentException("Дата рождения не должна быть" +
                                                "ранее 1.1.1900 или позже сегодняшнего дня.");
                _birthday = value;
            }
        }

        /// <summary>
        /// E-Mail контакта.
        /// </summary>
        /// <exception cref="ArgumentException">Длина E-Mail длинее 50 символов.</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("Адрес e-mail не может быть длинее 50 символов.");
                _email = value;
            }
        }

        /// <summary>
        /// ID ВК контакта.
        /// </summary>
        /// <exception cref="ArgumentException">ID ВК длиннее 50 символов.</exception>
        public string VkId
        {
            get => _vkId;
            set
            {
                if (!TextIsCorrect(value))
                    throw new ArgumentException("ID ВК не может быть длинее 50 символов.");
                _vkId = value;
            }
        }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        /// <exception cref="ArgumentException">Номер телефона не соответствует российскому стандарту.</exception>
        public long PhoneNumber
        {
            get => _phoneNumber.Number;
            set => _phoneNumber.Number = value;
        }
        
        /// <summary>
        /// Проверяет длину текста.
        /// </summary>
        /// <param name="text">Строка текста.</param>
        /// <returns>Истина, если длина строки меньше или равна максимально допустимой,
        /// иначе ложь.</returns>
        private static bool TextIsCorrect(string text) => 
            text != null && text.Length <= MaxTextLength;
    }
}