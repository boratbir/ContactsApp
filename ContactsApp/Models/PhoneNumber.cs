using System;

namespace ContactsApp.Models
{
    /// <summary>
    /// Номер телефона контакта.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Поле номера телефона.
        /// </summary>
        private long _phoneNumber = 70000000000;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        /// <exception cref="ArgumentException">Номер телефона не соответствует российскому формату.</exception>
        public long Number
        {
            get => _phoneNumber;
            set
            {
                if (value < 70000000000 || value > 79999999999)
                    throw new ArgumentException("Номер должен состоять из 11 цифр и начинаться с 7.");
                _phoneNumber = value;
            }
        }
    }
}