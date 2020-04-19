using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShortcutKeyEditor.Localize;

namespace ShortcutKeyEditor
{
    public partial class FormKeySettings : Form
    {
        public FormKeySettings()
        {
            InitializeComponent();

            Localize();
        }

        void Localize()
        {
            LocalizeUtil.Localized(this);
            LocalizeUtil.Localized(groupBoxCommands);
            LocalizeUtil.Localized(groupBoxCommandDescription);
            LocalizeUtil.Localized(columnHeaderCommandName);
            LocalizeUtil.Localized(columnHeaderCommandKeys);
            LocalizeUtil.Localized(groupBoxCurrentShortcut);
            LocalizeUtil.Localized(buttonSetToDefault);
            LocalizeUtil.Localized(buttonRemoveShortcut);
            LocalizeUtil.Localized(groupBoxNewShortcut);
            LocalizeUtil.Localized(buttonAddShortcut);
            LocalizeUtil.Localized(buttonAssignShortcut);
            LocalizeUtil.Localized(groupBoxShortcutUsed);
            LocalizeUtil.Localized(buttonSetAllToDefault);
            LocalizeUtil.Localized(buttonOk);
            LocalizeUtil.Localized(buttonCancel);
        }
    }
}
