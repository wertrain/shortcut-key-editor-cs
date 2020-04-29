using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShortcutKeyEditor.Layout;
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
        }

        /// <summary>
        /// 入力されているキー
        /// </summary>
        private Keys InputKeys { get; set; }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKeySettings_Load(object sender, EventArgs e)
        {
            tabControlCommands.TabPages.Clear();

            var layout = LayoutLoader.Load(@".\layout.xml");
            foreach (var layoutTab in layout.Tabs)
            {
                var listview = new ListView();
                listview.Dock = DockStyle.Fill;
                listview.HideSelection = false;
                listview.FullRowSelect = true;
                listview.View = View.Details;

                var columnsHeaderCommands = new ColumnHeader();
                columnsHeaderCommands.Text = "Commands";
                columnsHeaderCommands.Width = 300;
                listview.Columns.Add(columnsHeaderCommands);
                var columnsHeaderShortcutKeys = new ColumnHeader();
                columnsHeaderShortcutKeys.Text = "Shortcut Key(s)";
                columnsHeaderShortcutKeys.Width = 140;
                listview.Columns.Add(columnsHeaderShortcutKeys);

                foreach (var layoutKeySet in layoutTab.KeySets)
                {
                    var item = new ListViewItem(layoutKeySet.Label);
                    var subItem = new ListViewItem.ListViewSubItem();
                    subItem.Text = string.Join(", ", layoutKeySet.KeyTexts);
                    item.SubItems.Add(subItem);
                    item.Tag = layoutKeySet;
                    listview.Items.Add(item);
                    listview.SelectedIndexChanged += listViewCommands_SelectedIndexChanged;
                }

                var tabPage = new TabPage();
                tabPage.Text = layoutTab.Label;
                tabPage.Controls.Add(listview);
                tabPage.Tag = listview;

                tabControlCommands.TabPages.Add(tabPage);
            }

            LocalizeUtil.Localized(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listview = sender as ListView;

            if (listview.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = null;
                foreach (ListViewItem item in listview.SelectedItems)
                {
                    selectedItem = item;
                    break;
                }

                var layoutKeySet = selectedItem.Tag as LayoutParam.KeySet;
                labelCommandDescription.Text = layoutKeySet.Description;
                labelCurrentShortcut.Text = string.Join(", ", layoutKeySet.KeyTexts);

                textbox_new_shortcut.Enabled = true;
            }
            else
            {
                textbox_new_shortcut.Enabled = false;
                textbox_new_shortcut.Text = string.Empty;
                labelShortcutUsed.Text = string.Empty;
                labelCurrentShortcut.Text = string.Empty;
                labelCommandDescription.Text = string.Empty;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textbox_new_shortcut_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var textbox = sender as TextBox;
            InputKeys = ModifierKeys | e.KeyCode;
            string inputKeyText = KeyUtil.KeysToString(InputKeys);
            textbox.Text = inputKeyText;

            var selectedTab = tabControlCommands.SelectedTab;
            ListView listview = selectedTab.Tag as ListView;

            if (listview.SelectedItems.Count == 0)
            {
                return;
            }
            var selectedItem = listview.SelectedItems[0];
            var selectedKeyTexts = (selectedItem.Tag as LayoutParam.KeySet).KeyTexts;

            foreach (ListViewItem item in listview.Items)
            {
                var usedKeys = item.SubItems[1].Text.Split(',');
                foreach (var usedKey in usedKeys)
                {
                    if (selectedKeyTexts.Contains(inputKeyText))
                    {
                        continue;
                    }

                    if (inputKeyText == usedKey)
                    {
                        labelShortcutUsed.Text = item.Text;
                        return;
                    }
                }
            }

            labelShortcutUsed.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;

            var selectedTab = tabControl.SelectedTab;
            ListView listview = selectedTab?.Tag as ListView;
            listview?.SelectedItems.Clear();

            textbox_new_shortcut.Enabled = false;
            textbox_new_shortcut.Text = string.Empty;
            labelShortcutUsed.Text = string.Empty;
            labelCurrentShortcut.Text = string.Empty;
            labelCommandDescription.Text = string.Empty;
        }
    }
}
