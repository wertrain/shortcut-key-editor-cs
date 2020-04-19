using System.Windows.Forms;

namespace ShortcutKeyEditor.Localize
{
    public class LocalizeUtil
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        public static void Localized(Control control)
        {
            control.Text = control.Text.Localize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columnHeader"></param>
        public static void Localized(ColumnHeader columnHeader)
        {
            columnHeader.Text = columnHeader.Text.Localize();
        }
    }
}
