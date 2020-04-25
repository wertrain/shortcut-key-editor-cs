using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortcutKeyEditor.MyControl
{
    public partial class KeySetControl : UserControl
    {
        public KeySetControl()
        {
            InitializeComponent();
        }

        public ListView ListViewCommands
        {
            get { return listViewCommands; }
        }
    }
}
