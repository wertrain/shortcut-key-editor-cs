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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormKeySettings()
        {
            InitializeComponent();

            Localize();
        }

        /// <summary>
        /// 
        /// </summary>
        void Localize()
        {
            LocalizeUtil.Localized(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_new_shortcut_KeyDown(object sender, KeyEventArgs e)
        {
            var textbox = sender as TextBox;
            InputKeys = ModifierKeys | e.KeyCode;
            textbox.Text = KeyUtil.KeysToString(InputKeys);
        }

        /// <summary>
        /// 入力されているキー
        /// </summary>
        private Keys InputKeys { get; set; }
    }
}
