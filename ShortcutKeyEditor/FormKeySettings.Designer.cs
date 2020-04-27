namespace ShortcutKeyEditor
{
    partial class FormKeySettings
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKeySettings));
            this.listViewCommands = new System.Windows.Forms.ListView();
            this.columnHeaderCommandName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCommandKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxCommandDescription = new System.Windows.Forms.GroupBox();
            this.labelCommandDescription = new System.Windows.Forms.Label();
            this.groupBoxCurrentShortcut = new System.Windows.Forms.GroupBox();
            this.labelCurrentShortcut = new System.Windows.Forms.Label();
            this.buttonRemoveShortcut = new System.Windows.Forms.Button();
            this.buttonSetToDefault = new System.Windows.Forms.Button();
            this.groupBoxNewShortcut = new System.Windows.Forms.GroupBox();
            this.textbox_new_shortcut = new System.Windows.Forms.TextBox();
            this.buttonAssignShortcut = new System.Windows.Forms.Button();
            this.buttonAddShortcut = new System.Windows.Forms.Button();
            this.groupBoxShortcutUsed = new System.Windows.Forms.GroupBox();
            this.labelShortcutUsed = new System.Windows.Forms.Label();
            this.buttonSetAllToDefault = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControlCommands = new System.Windows.Forms.TabControl();
            this.tabPageBase = new System.Windows.Forms.TabPage();
            this.groupBoxCommandDescription.SuspendLayout();
            this.groupBoxCurrentShortcut.SuspendLayout();
            this.groupBoxNewShortcut.SuspendLayout();
            this.groupBoxShortcutUsed.SuspendLayout();
            this.tabControlCommands.SuspendLayout();
            this.tabPageBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCommands
            // 
            this.listViewCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCommandName,
            this.columnHeaderCommandKeys});
            this.listViewCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCommands.HideSelection = false;
            this.listViewCommands.Location = new System.Drawing.Point(3, 3);
            this.listViewCommands.Name = "listViewCommands";
            this.listViewCommands.Size = new System.Drawing.Size(543, 128);
            this.listViewCommands.TabIndex = 0;
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
            // groupBoxCommandDescription
            // 
            this.groupBoxCommandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCommandDescription.Controls.Add(this.labelCommandDescription);
            this.groupBoxCommandDescription.Location = new System.Drawing.Point(3, 163);
            this.groupBoxCommandDescription.Name = "groupBoxCommandDescription";
            this.groupBoxCommandDescription.Size = new System.Drawing.Size(555, 63);
            this.groupBoxCommandDescription.TabIndex = 2;
            this.groupBoxCommandDescription.TabStop = false;
            this.groupBoxCommandDescription.Text = "Command Description";
            // 
            // labelCommandDescription
            // 
            this.labelCommandDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCommandDescription.Location = new System.Drawing.Point(8, 18);
            this.labelCommandDescription.Name = "labelCommandDescription";
            this.labelCommandDescription.Size = new System.Drawing.Size(539, 36);
            this.labelCommandDescription.TabIndex = 0;
            // 
            // groupBoxCurrentShortcut
            // 
            this.groupBoxCurrentShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCurrentShortcut.Controls.Add(this.labelCurrentShortcut);
            this.groupBoxCurrentShortcut.Controls.Add(this.buttonRemoveShortcut);
            this.groupBoxCurrentShortcut.Controls.Add(this.buttonSetToDefault);
            this.groupBoxCurrentShortcut.Location = new System.Drawing.Point(3, 231);
            this.groupBoxCurrentShortcut.Name = "groupBoxCurrentShortcut";
            this.groupBoxCurrentShortcut.Size = new System.Drawing.Size(555, 50);
            this.groupBoxCurrentShortcut.TabIndex = 3;
            this.groupBoxCurrentShortcut.TabStop = false;
            this.groupBoxCurrentShortcut.Text = "Current Shortcut";
            // 
            // labelCurrentShortcut
            // 
            this.labelCurrentShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentShortcut.Location = new System.Drawing.Point(10, 23);
            this.labelCurrentShortcut.Name = "labelCurrentShortcut";
            this.labelCurrentShortcut.Size = new System.Drawing.Size(365, 12);
            this.labelCurrentShortcut.TabIndex = 2;
            // 
            // buttonRemoveShortcut
            // 
            this.buttonRemoveShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveShortcut.Location = new System.Drawing.Point(475, 17);
            this.buttonRemoveShortcut.Name = "buttonRemoveShortcut";
            this.buttonRemoveShortcut.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveShortcut.TabIndex = 1;
            this.buttonRemoveShortcut.Text = "Remove";
            this.buttonRemoveShortcut.UseVisualStyleBackColor = true;
            // 
            // buttonSetToDefault
            // 
            this.buttonSetToDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetToDefault.Location = new System.Drawing.Point(394, 17);
            this.buttonSetToDefault.Name = "buttonSetToDefault";
            this.buttonSetToDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonSetToDefault.TabIndex = 0;
            this.buttonSetToDefault.Text = "Default";
            this.buttonSetToDefault.UseVisualStyleBackColor = true;
            // 
            // groupBoxNewShortcut
            // 
            this.groupBoxNewShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNewShortcut.Controls.Add(this.textbox_new_shortcut);
            this.groupBoxNewShortcut.Controls.Add(this.buttonAssignShortcut);
            this.groupBoxNewShortcut.Controls.Add(this.buttonAddShortcut);
            this.groupBoxNewShortcut.Location = new System.Drawing.Point(3, 283);
            this.groupBoxNewShortcut.Name = "groupBoxNewShortcut";
            this.groupBoxNewShortcut.Size = new System.Drawing.Size(555, 50);
            this.groupBoxNewShortcut.TabIndex = 4;
            this.groupBoxNewShortcut.TabStop = false;
            this.groupBoxNewShortcut.Text = "New Shortcut";
            // 
            // textbox_new_shortcut
            // 
            this.textbox_new_shortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_new_shortcut.Enabled = false;
            this.textbox_new_shortcut.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textbox_new_shortcut.Location = new System.Drawing.Point(10, 19);
            this.textbox_new_shortcut.Name = "textbox_new_shortcut";
            this.textbox_new_shortcut.ReadOnly = true;
            this.textbox_new_shortcut.ShortcutsEnabled = false;
            this.textbox_new_shortcut.Size = new System.Drawing.Size(365, 19);
            this.textbox_new_shortcut.TabIndex = 2;
            this.textbox_new_shortcut.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textbox_new_shortcut_PreviewKeyDown);
            // 
            // buttonAssignShortcut
            // 
            this.buttonAssignShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAssignShortcut.Location = new System.Drawing.Point(475, 17);
            this.buttonAssignShortcut.Name = "buttonAssignShortcut";
            this.buttonAssignShortcut.Size = new System.Drawing.Size(75, 23);
            this.buttonAssignShortcut.TabIndex = 1;
            this.buttonAssignShortcut.Text = "Assign";
            this.buttonAssignShortcut.UseVisualStyleBackColor = true;
            // 
            // buttonAddShortcut
            // 
            this.buttonAddShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddShortcut.Location = new System.Drawing.Point(394, 17);
            this.buttonAddShortcut.Name = "buttonAddShortcut";
            this.buttonAddShortcut.Size = new System.Drawing.Size(75, 23);
            this.buttonAddShortcut.TabIndex = 0;
            this.buttonAddShortcut.Text = "Add";
            this.buttonAddShortcut.UseVisualStyleBackColor = true;
            // 
            // groupBoxShortcutUsed
            // 
            this.groupBoxShortcutUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxShortcutUsed.Controls.Add(this.labelShortcutUsed);
            this.groupBoxShortcutUsed.Location = new System.Drawing.Point(3, 336);
            this.groupBoxShortcutUsed.Name = "groupBoxShortcutUsed";
            this.groupBoxShortcutUsed.Size = new System.Drawing.Size(555, 50);
            this.groupBoxShortcutUsed.TabIndex = 5;
            this.groupBoxShortcutUsed.TabStop = false;
            this.groupBoxShortcutUsed.Text = "Shortcut used by:";
            // 
            // labelShortcutUsed
            // 
            this.labelShortcutUsed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShortcutUsed.Location = new System.Drawing.Point(10, 23);
            this.labelShortcutUsed.Name = "labelShortcutUsed";
            this.labelShortcutUsed.Size = new System.Drawing.Size(537, 12);
            this.labelShortcutUsed.TabIndex = 3;
            // 
            // buttonSetAllToDefault
            // 
            this.buttonSetAllToDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSetAllToDefault.Location = new System.Drawing.Point(3, 391);
            this.buttonSetAllToDefault.Name = "buttonSetAllToDefault";
            this.buttonSetAllToDefault.Size = new System.Drawing.Size(173, 23);
            this.buttonSetAllToDefault.TabIndex = 6;
            this.buttonSetAllToDefault.Text = "Set All To Default";
            this.buttonSetAllToDefault.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(348, 391);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(102, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(456, 391);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabControlCommands
            // 
            this.tabControlCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCommands.Controls.Add(this.tabPageBase);
            this.tabControlCommands.Location = new System.Drawing.Point(2, 2);
            this.tabControlCommands.Name = "tabControlCommands";
            this.tabControlCommands.SelectedIndex = 0;
            this.tabControlCommands.Size = new System.Drawing.Size(557, 160);
            this.tabControlCommands.TabIndex = 1;
            this.tabControlCommands.SelectedIndexChanged += new System.EventHandler(this.tabControlCommands_SelectedIndexChanged);
            // 
            // tabPageBase
            // 
            this.tabPageBase.Controls.Add(this.listViewCommands);
            this.tabPageBase.Location = new System.Drawing.Point(4, 22);
            this.tabPageBase.Name = "tabPageBase";
            this.tabPageBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBase.Size = new System.Drawing.Size(549, 134);
            this.tabPageBase.TabIndex = 0;
            this.tabPageBase.Text = "Commands";
            this.tabPageBase.UseVisualStyleBackColor = true;
            // 
            // FormKeySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 418);
            this.Controls.Add(this.tabControlCommands);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonSetAllToDefault);
            this.Controls.Add(this.groupBoxShortcutUsed);
            this.Controls.Add(this.groupBoxNewShortcut);
            this.Controls.Add(this.groupBoxCurrentShortcut);
            this.Controls.Add(this.groupBoxCommandDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKeySettings";
            this.Text = "Shortcut Key Settings";
            this.Load += new System.EventHandler(this.FormKeySettings_Load);
            this.groupBoxCommandDescription.ResumeLayout(false);
            this.groupBoxCurrentShortcut.ResumeLayout(false);
            this.groupBoxNewShortcut.ResumeLayout(false);
            this.groupBoxNewShortcut.PerformLayout();
            this.groupBoxShortcutUsed.ResumeLayout(false);
            this.tabControlCommands.ResumeLayout(false);
            this.tabPageBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCommandDescription;
        private System.Windows.Forms.Label labelCommandDescription;
        private System.Windows.Forms.ListView listViewCommands;
        private System.Windows.Forms.ColumnHeader columnHeaderCommandName;
        private System.Windows.Forms.ColumnHeader columnHeaderCommandKeys;
        private System.Windows.Forms.GroupBox groupBoxCurrentShortcut;
        private System.Windows.Forms.GroupBox groupBoxNewShortcut;
        private System.Windows.Forms.GroupBox groupBoxShortcutUsed;
        private System.Windows.Forms.Button buttonSetAllToDefault;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRemoveShortcut;
        private System.Windows.Forms.Button buttonSetToDefault;
        private System.Windows.Forms.Button buttonAssignShortcut;
        private System.Windows.Forms.Button buttonAddShortcut;
        private System.Windows.Forms.TextBox textbox_new_shortcut;
        private System.Windows.Forms.TabControl tabControlCommands;
        private System.Windows.Forms.TabPage tabPageBase;
        private System.Windows.Forms.Label labelCurrentShortcut;
        private System.Windows.Forms.Label labelShortcutUsed;
    }
}

