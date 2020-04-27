using System.Windows.Forms;

using ShortcutKeyEditor.Localize;

namespace ShortcutKeyEditor.MyControl
{
    public partial class KeySetControl : UserControl
    {
        public KeySetControl()
        {
            InitializeComponent();

            LocalizeUtil.Localized(this);
        }

        public ListView ListViewCommands
        {
            get { return listViewCommands; }
        }
    }
}
