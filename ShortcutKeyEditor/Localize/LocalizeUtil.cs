﻿using System.Windows.Forms;

namespace ShortcutKeyEditor.Localize
{
    public class LocalizeUtil
    {
        /// <summary>
        /// コントロールとその子をローカライズする
        /// </summary>
        /// <param name="control"></param>
        public static void Localized (Control control)
        {
            control.Text = control.Text.Localize();
            foreach (var child in control.Controls)
            {
                if (child is Control)
                {
                    var childControl = child as Control;
                    Localized(childControl);
                }

                if (child is ListView)
                {
                    var childListView = child as ListView;
                    foreach (ColumnHeader column in childListView.Columns)
                    {
                        column.Text = column.Text.Localize();
                    }
                }
            }
        }
    }
}
