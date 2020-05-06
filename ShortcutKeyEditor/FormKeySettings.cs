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
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKeySettings_Load(object sender, EventArgs e)
        {
            tabControlCommands.TabPages.Clear();

            var settings = ShortcutKeyManager.ShortcutKeyManager.LoadSettings("shortcutkeys.xml");
            if (settings == null) settings = new Dictionary<string, ShortcutKeyManager.ShortcutKeyManager.KeyParam>();

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
                    var settingsId = layoutTab.Id + SettingsIdNameSeparator + layoutKeySet.Id;
                    var item = new ListViewItem(layoutKeySet.Label);
                    var subItem = new ListViewItem.ListViewSubItem();
                    if (settings.ContainsKey(settingsId)) subItem.Text = string.Join(", ", settings[settingsId].KeyTexts);
                    else subItem.Text = string.Join(", ", layoutKeySet.KeyTexts);
                    item.SubItems.Add(subItem);
                    item.Tag = layoutKeySet;
                    listview.Items.Add(item);
                    listview.SelectedIndexChanged += listViewCommands_SelectedIndexChanged;
                }

                var tabPage = new TabPage();
                tabPage.Name = layoutTab.Id;
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

            bool selected = listview.SelectedItems.Count > 0;
            textboxNewShortcut.Enabled = selected;

            updateSelectedItem();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textboxNewShortcut_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var textbox = sender as TextBox;
            var inputKeys = ModifierKeys | e.KeyCode;
            textbox.Text = ShortcutKeyManager.ShortcutKeyManager.KeysToString(inputKeys);

            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            labelShortcutUsed.Text = string.Empty;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem selectedItem in listview.SelectedItems)
            {
                foreach (ListViewItem item in listview.Items)
                {
                    foreach (var usedKey in GetShortcutKeys(item))
                    {
                        if (selectedItem == item) continue;

                        if (textbox.Text == usedKey)
                        {
                            labelShortcutUsed.Text = item.Text;
                            return;
                        }
                    }
                }
            }            
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

            textboxNewShortcut.Enabled = false;
            textboxNewShortcut.Text = string.Empty;
            labelShortcutUsed.Text = string.Empty;
            labelCurrentShortcut.Text = string.Empty;
            labelCommandDescription.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetToDefault_Click(object sender, EventArgs e)
        {
            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem item in listview.SelectedItems)
            {
                var layoutKeySet = item.Tag as LayoutParam.KeySet;
                var defaultText = string.Join(", ", layoutKeySet.KeyTexts);
                item.SubItems[1].Text = defaultText;
            }
            updateSelectedItem();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveShortcut_Click(object sender, EventArgs e)
        {
            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem item in listview.SelectedItems)
            {
                item.SubItems[1].Text = string.Empty;
            }
            labelCurrentShortcut.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddShortcut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxNewShortcut.Text)) return;
            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem selectedItem in listview.SelectedItems)
            {
                var keys = GetShortcutKeys(selectedItem);
                if (keys.Contains(textboxNewShortcut.Text)) break;

                var newKeys = new StringBuilder(selectedItem.SubItems[1].Text);
                if (newKeys.Length > 0) newKeys.Append(", ");
                newKeys.Append(textboxNewShortcut.Text);
                selectedItem.SubItems[1].Text = newKeys.ToString();
                textboxNewShortcut.Text = string.Empty;
                removeDuplicateKey(selectedItem);
                break;
            }
            updateSelectedItem();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssignShortcut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxNewShortcut.Text)) return;
            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem selectedItem in listview.SelectedItems)
            {
                selectedItem.SubItems[1].Text = textboxNewShortcut.Text;
                textboxNewShortcut.Text = string.Empty;
                removeDuplicateKey(selectedItem);
                break;
            }
            updateSelectedItem();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAllToDefault_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabControlCommands.TabPages)
            {
                var listview = tabPage.Tag as ListView;
                foreach (ListViewItem item in listview.Items)
                {
                    var layoutKeySet = item.Tag as LayoutParam.KeySet;
                    item.SubItems[1].Text = string.Join(", ", layoutKeySet.KeyTexts);
                }
            }
            updateSelectedItem();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            var keyParams = new List<ShortcutKeyManager.ShortcutKeyManager.KeyParam>();
            foreach (TabPage tabPage in tabControlCommands.TabPages)
            {
                var listview = tabPage.Tag as ListView;
                foreach (ListViewItem item in listview.Items)
                {
                    var layoutKeySet = item.Tag as LayoutParam.KeySet;
                    var keyParam = new ShortcutKeyManager.ShortcutKeyManager.KeyParam();
                    keyParam.Id = tabPage.Name + SettingsIdNameSeparator + layoutKeySet.Id;
                    keyParam.KeyTexts = GetShortcutKeys(item);
                    keyParams.Add(keyParam);
                }
            }

            var hashset = new HashSet<string>();
            foreach (var keyParam in keyParams)
            {
                if (!hashset.Add(keyParam.Id))
                {
                    MessageBox.Show(
                        keyParam.Id + " が重複して登録されています。",
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (ShortcutKeyManager.ShortcutKeyManager.WriteSettings(@"./shortcutkeys.xml", keyParams))
            {
                Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private List<string> GetShortcutKeys(ListViewItem item)
        {
            return item.SubItems[1].Text.Split(',').Select(p => p.Trim()).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        private void updateSelectedItem()
        {
            labelCurrentShortcut.Text = string.Empty;
            labelCommandDescription.Text = string.Empty;
            labelShortcutUsed.Text = string.Empty;

            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem selectedItem in listview.SelectedItems)
            {
                var layoutKeySet = selectedItem.Tag as LayoutParam.KeySet;
                labelCommandDescription.Text = layoutKeySet.Description;
                labelCurrentShortcut.Text = selectedItem.SubItems[1].Text;
                break;
            }
        }

        /// <summary>
        /// 指定されたアイテムの持つショートカットキーと重複しているアイテムのショートカットキーを削除
        /// </summary>
        /// <param name="sourceItem">重複チェック対象のアイテム</param>
        private void removeDuplicateKey(ListViewItem sourceItem)
        {
            var tabPage = tabControlCommands.SelectedTab;
            if (tabPage == null) return;

            var checkKeys = GetShortcutKeys(sourceItem);

            var listview = tabPage.Tag as ListView;
            foreach (ListViewItem item in listview.Items)
            {
                if (sourceItem == item) continue;

                var keys = GetShortcutKeys(item);
                ;
                if (keys.RemoveAll(i => checkKeys.Contains(i)) > 0)
                {
                    item.SubItems[1].Text = string.Join(", ", keys);
                }
            }
        }

        /// <summary>
        /// 設定名のセパレータ
        /// </summary>
        private static char SettingsIdNameSeparator = '@';
    }
}
