using System.Text.RegularExpressions;
using ContactsApp.Models;

namespace ContactsApp.UI
{
    public static class PhoneConverter
    {
        /// <summary>
        /// Преобразует номер телефона из числа в форматированную строку
        /// </summary>
        /// <param name="number">Номер телефона в числовом виде</param>
        /// <returns>Форматированный номер телефона</returns>
        public static string Mask(long number) => number != 0
            ? number.ToString("+0 (000) 000-0000")
            : "+7 (___) ___-____";
        

        /// <summary>
        /// Преобразует номер телефона из форматированной строки в число
        /// </summary>
        /// <param name="phoneText">Форматированный номер телефона</param>
        /// <returns>Номер телефона в числовом виде</returns>
        public static long Unmask(string phoneText)
        {
            var phone = new Regex(@"\D").Replace(phoneText, "");
            return long.Parse(phone);
        }
    }
}