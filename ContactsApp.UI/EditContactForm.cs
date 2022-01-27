using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactsApp.Models;

namespace ContactsApp.UI
{
    /// <summary>
    /// Форма редактирования данных о контакте
    /// </summary>
    public partial class EditContactForm : Form
    {
        private Dictionary<Control, Control> _controlsMap;
        
        /// <summary>
        /// Словарь соответствий контролов для отображения ErrorProvider на Label'ах, соответствующих
        /// элементам, на которых произошла ошибка.
        /// </summary>
        private Dictionary<Control, Control> ControlsMap => 
            _controlsMap ?? 
            (_controlsMap = new Dictionary<Control, Control>()
            {
                {textBoxLastName, labelLastName},
                {textBoxFirstName, labelFirstName},
                {dateTimePickerBirthday, labelBirthday},
                {maskedTextBoxPhone, labelPhone},
                {textBoxEmail, labelEmail},
                {textBoxIdVk, labelIdVk}
            });

        /// <summary>
        /// Редактируемый контакт
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="contact">Контакт для изменения.</param>
        public EditContactForm(Contact contact)
        {
            // Инициализация формы
            InitializeComponent();

            Contact = contact;
            // Привязка значений элементов управления к значениям свойств контакта
            SetBindings();
            
            // Установка значений
            textBoxLastName.Text = Contact.LastName;
            textBoxFirstName.Text = Contact.FirstName;
            dateTimePickerBirthday.Value = Contact.Birthday;
            maskedTextBoxPhone.Text = PhoneConverter.Mask(Contact.PhoneNumber);
            textBoxEmail.Text = Contact.Email;
            textBoxIdVk.Text = Contact.VkId;
            
            // Проверка полей на валидность
            CheckFields();
        }

        /// <summary>
        /// Привязка значений полей формы к значениям свойств контакта.
        /// Это позволяет автоматизировать валидацию.
        /// </summary>
        private void SetBindings()
        {
            // Привязка фамилии
            BindText(textBoxLastName, nameof(Contact.LastName));
            // Привязка имени
            BindText(textBoxFirstName, nameof(Contact.FirstName));
            // Привязка почты
            BindText(textBoxEmail, nameof(Contact.Email));
            // Привязка ID ВК
            BindText(textBoxIdVk, nameof(Contact.VkId));
            // Привязка даты рождения
            BindDatePicker();
            // Привязка телефона
            BindPhone();
        }

        /// <summary>
        /// Привязка текстовых полей.
        /// </summary>
        /// <param name="control">Текстовое поле на форме.</param>
        /// <param name="contactPropertyName">Название свойства контакта.</param>
        private void BindText(Control control, string contactPropertyName)
        {
            control.DataBindings
                .Add(
                    nameof(control.Text), 
                    Contact, 
                    contactPropertyName, 
                    true, 
                    DataSourceUpdateMode.OnPropertyChanged);
            control.DataBindings[0].BindingComplete += OnBindingComplete;
        }

        /// <summary>
        /// Привязка поля даты рождения.
        /// </summary>
        private void BindDatePicker()
        {
            dateTimePickerBirthday.DataBindings
                .Add(
                    nameof(dateTimePickerBirthday.Value), 
                    Contact, 
                    nameof(Contact.Birthday),
                    true, 
                    DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerBirthday.DataBindings[0].BindingComplete += OnBindingComplete;
        }
        
        /// <summary>
        /// Привязка номера телефона.
        /// </summary>
        private void BindPhone()
        {
            maskedTextBoxPhone.DataBindings
                .Add(
                    nameof(maskedTextBoxPhone.Text), 
                    Contact, 
                    nameof(Contact.PhoneNumber),
                    true, 
                    DataSourceUpdateMode.OnPropertyChanged);
            maskedTextBoxPhone.DataBindings[0].Format += OnPhoneFormatted;
            maskedTextBoxPhone.DataBindings[0].Parse += OnPhoneParsed;
            maskedTextBoxPhone.DataBindings[0].BindingComplete += OnBindingComplete;
        }
        
        /// <summary>
        /// Закрытие диалогового окна с известным результатом.
        /// </summary>
        /// <param name="result">Результат.</param>
        private void CloseDialog(DialogResult result)
        {
            DialogResult = result;
            Close();
        }

        /// <summary>
        /// Установка ошибки в элемент управления.
        /// </summary>
        /// <param name="control">Поле формы.</param>
        /// <param name="message">Сообщение об ошибке.</param>
        private void SetError(Control control, string message)
        {
            Console.WriteLine(message);
            errorProvider.SetError(ControlsMap[control], message);
            buttonOk.Enabled = false;
            buttonCancel.Enabled = false;
        }

        /// <summary>
        /// Убирает ошибку из элемента управления.
        /// </summary>
        /// <param name="control">Поле формы.</param>
        private void RemoveError(Control control)
        {
            errorProvider.SetError(ControlsMap[control], "");
            buttonCancel.Enabled = true;
            CheckFields();
        }

        /// <summary>
        /// Проверка полей на содержание в них ошибок
        /// </summary>
        private void CheckFields()
        {
            buttonOk.Enabled = !(FieldsAreEmpty() || OnFieldsInvalidated());
        }

        /// <summary>
        /// Проверка полей на пустоту
        /// </summary>
        /// <returns></returns>
        private bool FieldsAreEmpty() =>
            string.IsNullOrEmpty(textBoxLastName.Text) ||
            string.IsNullOrEmpty(textBoxFirstName.Text);
            //!PhoneNumber.IsValid(PhoneConverter.Unmask(maskedTextBoxPhone.Text)));
        

        /// <summary>
        /// Проверяет поля на корректность значений
        /// </summary>
        /// <returns></returns>
        private bool OnFieldsInvalidated() => ControlsMap
            .Select(i => i.Value)
            .Any(k => !string.IsNullOrEmpty(errorProvider.GetError(k)));

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК.
        /// </summary>
        private void OnOkButtonClicked(object sender, EventArgs e)
        {
            CloseDialog(DialogResult.OK);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки отмены.
        /// </summary>
        private void OnCancelButtonClicked(object sender, EventArgs e)
        {
            CloseDialog(DialogResult.Cancel);
        }

        /// <summary>
        /// Обработчик события завершения привязки. Используется для валидации данных, введённых в поле формы.
        /// </summary>
        private void OnBindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.Exception != null)
            {
                SetError(((Binding)sender).Control, e.Exception.Message);
            }
            else
                RemoveError(((Binding)sender).Control);
        }

        /// <summary>
        /// Обработчик события форматирования телефона, преобразует число телефона в строку.
        /// </summary>
        private void OnPhoneFormatted(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Mask((long)e.Value);
        }

        /// <summary>
        /// Обработчик события парсинга телефона, преобразует строку телефона в число.
        /// </summary>
        private void OnPhoneParsed(object sender, ConvertEventArgs e)
        {
            e.Value = PhoneConverter.Unmask((string) e.Value);
        }
    }
}