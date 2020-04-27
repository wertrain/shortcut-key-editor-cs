namespace ShortcutKeyEditor.MyControl
{
    partial class KeySetControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewCommands = new System.Windows.Forms.ListView();
            this.columnHeaderCommandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCommandKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewCommands
            // 
            this.listViewCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCommandName,
            this.columnHeaderCommandKeys});
            this.listViewCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCommands.HideSelection = false;
            this.listViewCommands.Location = new System.Drawing.Point(0, 0);
            this.listViewCommands.MultiSelect = false;
            this.listViewCommands.Name = "listViewCommands";
            this.listViewCommands.Size = new System.Drawing.Size(491, 232);
            this.listViewCommands.TabIndex = 1;
            this.listViewCommands.UseCompatibleStateImageBehavior = false;
            this.listViewCommands.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCommandName
            // 
            this.columnHeaderCommandName.Text = "Commands";
            this.columnHeaderCommandName.Width = 300;
            // 
            // columnHeaderCommandKeys
            // 
            this.columnHeaderCommandKeys.Text = "Shortcut Key(s)";
            this.columnHeaderCommandKeys.Width = 140;
            // 
            // KeySetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCommands);
            this.Name = "KeySetControl";
            this.Size = new System.Drawing.Size(491, 232);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommands;
        private System.Windows.Forms.ColumnHeader columnHeaderCommandName;
        private System.Windows.Forms.ColumnHeader columnHeaderCommandKeys;
    }
}
