﻿namespace DiscordExplorer
{
    partial class DiscordExplorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordExplorer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.LocalUser = new System.Windows.Forms.TabPage();
            this.Messages = new System.Windows.Forms.TabPage();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.MessagesData = new System.Windows.Forms.DataGridView();
            this.Files = new System.Windows.Forms.TabPage();
            this.Servers = new System.Windows.Forms.TabPage();
            this.Profiles = new System.Windows.Forms.TabPage();
            this.Menu.SuspendLayout();
            this.Strip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesData)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1310, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openToolStripMenuItem.Text = "&Open Cache";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenButtonClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // Strip
            // 
            this.Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.Strip.Location = new System.Drawing.Point(0, 684);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(1310, 22);
            this.Strip.TabIndex = 1;
            this.Strip.Text = "Strip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel1.Text = "Loading Cache...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar1.Value = 50;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LocalUser);
            this.TabControl.Controls.Add(this.Messages);
            this.TabControl.Controls.Add(this.Files);
            this.TabControl.Controls.Add(this.Servers);
            this.TabControl.Controls.Add(this.Profiles);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 1;
            this.TabControl.Size = new System.Drawing.Size(1310, 660);
            this.TabControl.TabIndex = 0;
            // 
            // LocalUser
            // 
            this.LocalUser.Location = new System.Drawing.Point(4, 24);
            this.LocalUser.Name = "LocalUser";
            this.LocalUser.Padding = new System.Windows.Forms.Padding(3);
            this.LocalUser.Size = new System.Drawing.Size(1302, 632);
            this.LocalUser.TabIndex = 0;
            this.LocalUser.Text = "Local User";
            // 
            // Messages
            // 
            this.Messages.BackColor = System.Drawing.SystemColors.Control;
            this.Messages.Controls.Add(this.SplitContainer);
            this.Messages.Location = new System.Drawing.Point(4, 24);
            this.Messages.Name = "Messages";
            this.Messages.Padding = new System.Windows.Forms.Padding(3);
            this.Messages.Size = new System.Drawing.Size(1302, 632);
            this.Messages.TabIndex = 0;
            this.Messages.Text = "Messages";
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(3, 3);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.MessagesData);
            this.SplitContainer.Panel1MinSize = 500;
            this.SplitContainer.Panel2MinSize = 200;
            this.SplitContainer.Size = new System.Drawing.Size(1296, 626);
            this.SplitContainer.SplitterDistance = 900;
            this.SplitContainer.SplitterIncrement = 5;
            this.SplitContainer.SplitterWidth = 20;
            this.SplitContainer.TabIndex = 0;
            this.SplitContainer.Text = "splitContainer1";
            // 
            // MessagesData
            // 
            this.MessagesData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MessagesData.BackgroundColor = System.Drawing.Color.White;
            this.MessagesData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MessagesData.DefaultCellStyle = dataGridViewCellStyle2;
            this.MessagesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesData.Location = new System.Drawing.Point(0, 0);
            this.MessagesData.Name = "MessagesData";
            this.MessagesData.ReadOnly = true;
            this.MessagesData.Size = new System.Drawing.Size(900, 626);
            this.MessagesData.TabIndex = 0;
            // 
            // Files
            // 
            this.Files.Location = new System.Drawing.Point(4, 24);
            this.Files.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(1302, 632);
            this.Files.TabIndex = 5;
            this.Files.Text = "Files";
            // 
            // Servers
            // 
            this.Servers.BackColor = System.Drawing.Color.Transparent;
            this.Servers.Location = new System.Drawing.Point(4, 24);
            this.Servers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Servers.Name = "Servers";
            this.Servers.Size = new System.Drawing.Size(1302, 632);
            this.Servers.TabIndex = 3;
            this.Servers.Text = "Servers/Guilds";
            // 
            // Profiles
            // 
            this.Profiles.Location = new System.Drawing.Point(4, 24);
            this.Profiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Profiles.Name = "Profiles";
            this.Profiles.Size = new System.Drawing.Size(1302, 632);
            this.Profiles.TabIndex = 4;
            this.Profiles.Text = "Profiles";
            // 
            // DiscordExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 706);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Strip);
            this.Controls.Add(this.Menu);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(699, 398);
            this.Name = "DiscordExplorer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Discord Explorer";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.Messages.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Strip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Messages;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.TabPage LocalUser;
        private System.Windows.Forms.TabPage Files;
        private System.Windows.Forms.TabPage Servers;
        private System.Windows.Forms.TabPage Profiles;
        private System.Windows.Forms.DataGridView MessagesData;
    }
}
