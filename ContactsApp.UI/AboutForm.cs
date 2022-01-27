using System.Windows.Forms;

namespace ContactsApp.UI
{
    /// <summary>
    /// Класс формы окна "О программе".
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
            labelVersion.Text = @"Версия: " + Application.ProductVersion;
        }
    }
}