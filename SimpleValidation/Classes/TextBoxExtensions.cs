using System.Windows.Forms;

namespace SimpleValidation.Classes
{
    /// <summary>
    /// Extension methods for <see cref="TextBox"/>
    /// </summary>
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Toggle plain text or hide text with password character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="show"></param>
        public static void ToggleShow(this TextBox sender, bool show = true)
        {
            sender.PasswordChar = show ?
                '\0' :
                '\u25CF';
        }
    }
}