using System;
using System.ComponentModel;
using System.Windows.Forms;
using ContactsApp.Models;

namespace ContactsApp.UI
{
    /// <summary>
    /// Главнео окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле проекта.
        /// </summary>
        private readonly Project _project;
        
        /// <summary>
        /// Поле списка контактов, привязанное к списку на форме.
        /// </summary>
        private BindingList<Contact> _contacts;
        
        /// <summary>
        /// Поле текущего выбранного контакта.
        /// </summary>
        private Contact _selectedContact;
        
        /// <summary>
        /// Поле поискового запроса.
        /// </summary>
        private string _searchQuery = "";
        
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public MainForm()
        {
            // Инициализация формы
            InitializeComponent();
            // Чтение файла проекта
            _project = ProjectManager.ReadProject();
            // В списке контактов будут отображаться фамилии
            contactsListBox.DisplayMember = nameof(Contact.LastName);
            // Обновление данных
            SetVisibleData();
        }

        /// <summary>
        /// Обновляет данные на экране: список контактов, выбранный контакт и
        /// детальную информацию о контакте.
        /// </summary>
        private void SetVisibleData()
        {
            // Повторное формирование списка на основе найденных по запросу контактов
            _contacts = new BindingList<Contact>(_project.Find(_searchQuery));
            // Привязка. Нужна для обновления данных.
            contactsListBox.DataSource = _contacts;
            // Если список пуст, то убрать выделение контакта
            if (contactsListBox.Items.Count == 0)
            {
                SelectContact(-1);
                return;
            }
            
            if (_selectedContact == null)
                return;
            
            // Выбрать либо текущий выбранный контакт в новом списке,
            // либо первый попавшийся
            SelectContact(!contactsListBox.Items.Contains(_selectedContact)
                ? 0
                : contactsListBox.Items.IndexOf(_selectedContact));
        }

        /// <summary>
        /// Выбирает контакт по индексу в списке, привязанном к форме.
        /// </summary>
        /// <param name="index">Индекс контакта.</param>
        private void SelectContact(int index)
        {
            // Если выбрано пустое место или индекс превышает фактическое количество контактов
            if (index == -1 || index > _project.Contacts.Count - 1)
            {
                // Стирание детальных данных
                SetDetails(false);
                SetEditButtons(false);
            }
            else
            {
                _selectedContact = _contacts[index];
                // Запись и отображение детальных данных
                SetDetails(true);
                SetEditButtons(true);
            }
        }
        
        /// <summary>
        /// Переключение видимости данных о контакте
        /// </summary>
        /// <param name="show"></param>
        private void SetDetails(bool show)
        {
            textBoxLastName.Text = show ? _selectedContact.LastName : "";
            textBoxFirstName.Text = show ? _selectedContact.FirstName : "";
            textBoxBirthday.Text = show ? _selectedContact.Birthday.ToString("D") : "";
            textBoxPhone.Text = show ? PhoneConverter.Mask(_selectedContact.PhoneNumber) : "";
            textBoxEmail.Text = show ? _selectedContact.Email : "";
            textBoxVk.Text = show ? _selectedContact.VkId : "";
        }

        /// <summary>
        /// Переключение работоспособности кнопок редактирования и удаления контакта
        /// </summary>
        /// <param name="enabled"></param>
        private void SetEditButtons(bool enabled)
        {
            buttonEdit.Enabled = enabled;
            buttonDelete.Enabled = enabled;
            editMenuItem.Enabled = enabled;
            deleteContactMenuItem.Enabled = enabled;
        }
        
        /// <summary>
        /// Отображение формы редактирования контакта
        /// </summary>
        /// <param name="contact">Редактируемый контакт. Передать null, если нужно создать новый.</param>
        /// <returns>Кортеж из Contact и DialogResult</returns>
        private (Contact, DialogResult) ShowEditDialog(Contact contact = null)
        {
            // Отключение формы на время редактирования контакта
            Enabled = false;
            // Создание формы редактирования и передача в неё контакта
            var editForm = new EditContactForm(contact ?? new Contact());
            (Contact, DialogResult) result;
            // Отображение формы редактирования с ожиданием результата
            using (editForm)
            {
                editForm.ShowDialog();
                result = (editForm.Contact, editForm.DialogResult);
            }
            // Включение формы
            Enabled = true;
            return result;
        }

        // Открывает форму добавления контакта и добавляет контакт в список.
        private void AddContact()
        {
            // Отображение формы редактирования
            var (contact, dialogResult) = ShowEditDialog();
            if (dialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(contact);
            }
            // Обновление данных
            SetVisibleData();
            _project.SaveProject();
        }
        
        /// <summary>
        /// Открывает форму редактирования для изменения выбранного контакта
        /// </summary>
        private void EditContact()
        {
            // Отображение формы редактирования
            var (contact, dialogResult) = ShowEditDialog((Contact)_selectedContact.Clone());
            if (dialogResult == DialogResult.OK)
            {
                // Поиск индекса выбранного контакта в текущем списке
                var index = _project.Contacts.IndexOf(_selectedContact);
                // Обновление данных о контакте
                _project.Contacts[index] = contact;
            }
            // Обновление данных
            SetVisibleData();
            _project.SaveProject();
        }

        /// <summary>
        /// Удаление выбранного контакта
        /// </summary>
        private void RemoveContact()
        {
            var index = contactsListBox.SelectedIndex;
            _project.Contacts.Remove(_selectedContact);
            if (index < contactsListBox.Items.Count)
                contactsListBox.SelectedIndex = index;
            SetVisibleData();
            _project.SaveProject();
        }
        
        /// <summary>
        /// Обрабатывает событие выбора контакта в списке.
        /// </summary>
        private void OnSelectedContactChanged(object sender, EventArgs e)
        {
            SelectContact(contactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Обрабатывает событие нажатия на кнопку добавления контакта.
        /// </summary>
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Обрабатывает событие нажатия на кнопку редактирования контакта.
        /// </summary>
        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Обрабатывает событие нажатия на кнопку удаления контакта.
        /// </summary>
        private void OnRemoveButtonClicked(object sender, EventArgs e)
        {
            RemoveContact();
        }

        /// <summary>
        /// Обрабатывает событие изменения строки поиска.
        /// </summary>
        private void OnQueryChanged(object sender, EventArgs e)
        {
            // Достаём текст из поля ввода
            var text = ((TextBox) sender).Text;
            _searchQuery = text ?? "";
            // Обновляем данные
            SetVisibleData();
        }
    }
}