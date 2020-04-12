using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Записная_книжка.Properties;

namespace Записная_книжка
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //  private void InitializeComponent()
        //  {
        //      this.components = new System.ComponentModel.Container();
        //      this.topMenu = new System.Windows.Forms.MenuStrip();
        //      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        //      this.newTable = new System.Windows.Forms.ToolStripMenuItem();
        //      this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        //      this.work = new System.Windows.Forms.TextBox();
        //      this.label1 = new System.Windows.Forms.Label();
        //      this.infoLabel = new System.Windows.Forms.Label();
        //      this.panel1 = new System.Windows.Forms.Panel();
        //      this.db = new Записная_книжка.DBView();
        //      this.trayExit = new System.Windows.Forms.ContextMenuStrip(this.components);
        //      this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        //      this.send = new System.Windows.Forms.Button();
        //      this.AllTables = new System.Windows.Forms.ComboBox();
        //      this.deleteTable = new System.Windows.Forms.ContextMenuStrip(this.components);
        //      this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        //      this.deleteMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
        //      this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        //      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
        //      this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        //      this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        //      this.topMenu.SuspendLayout();
        //      ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
        //      this.trayExit.SuspendLayout();
        //      this.deleteTable.SuspendLayout();
        //      this.deleteMessage.SuspendLayout();
        //      this.SuspendLayout();
        //      // 
        //      // topMenu
        //      // 
        //      this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        //      this.выходToolStripMenuItem,
        //      this.newTable,
        //      this.отчётToolStripMenuItem});
        //      this.topMenu.Location = new System.Drawing.Point(0, 0);
        //      this.topMenu.Name = "topMenu";
        //      this.topMenu.Size = new System.Drawing.Size(383, 24);
        //      this.topMenu.TabIndex = 1;
        //      this.topMenu.Text = "menuStrip1";
        //      // 
        //      // выходToolStripMenuItem
        //      // 
        //      this.выходToolStripMenuItem.Image = global::Записная_книжка.Properties.Resources.exit;
        //      this.выходToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
        //      this.выходToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
        //      this.выходToolStripMenuItem.Text = "Выход";
        //      this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
        //      // 
        //      // newTable
        //      // 
        //      this.newTable.Image = global::Записная_книжка.Properties.Resources.add;
        //      this.newTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //      this.newTable.Name = "newTable";
        //      this.newTable.Size = new System.Drawing.Size(135, 20);
        //      this.newTable.Text = "Добавить таблицу";
        //      this.newTable.Click += new System.EventHandler(this.NewTable_Click);
        //      // 
        //      // отчётToolStripMenuItem
        //      // 
        //      this.отчётToolStripMenuItem.Image = global::Записная_книжка.Properties.Resources.floppy_disk_save_button;
        //      this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
        //      this.отчётToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
        //      this.отчётToolStripMenuItem.Text = "Отчёт";
        //      this.отчётToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //      this.отчётToolStripMenuItem.Click += new System.EventHandler(this.ОтчётToolStripMenuItem_Click);
        //      // 
        //      // work
        //      // 
        //      this.work.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
        //      | System.Windows.Forms.AnchorStyles.Right)));
        //      this.work.Location = new System.Drawing.Point(10, 459);
        //      this.work.Multiline = true;
        //      this.work.Name = "work";
        //      this.work.Size = new System.Drawing.Size(283, 83);
        //      this.work.TabIndex = 3;
        //      // 
        //      // label1
        //      // 
        //      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        //      this.label1.AutoSize = true;
        //      this.label1.Location = new System.Drawing.Point(9, 545);
        //      this.label1.Name = "label1";
        //      this.label1.Size = new System.Drawing.Size(116, 13);
        //      this.label1.TabIndex = 5;
        //      this.label1.Text = "Последнее действие:";
        //      // 
        //      // infoLabel
        //      // 
        //      this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        //      this.infoLabel.AutoSize = true;
        //      this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        //      this.infoLabel.Location = new System.Drawing.Point(125, 545);
        //      this.infoLabel.Name = "infoLabel";
        //      this.infoLabel.Size = new System.Drawing.Size(0, 13);
        //      this.infoLabel.TabIndex = 6;
        //      // 
        //      // panel1
        //      // 
        //      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        //      | System.Windows.Forms.AnchorStyles.Left) 
        //      | System.Windows.Forms.AnchorStyles.Right)));
        //      this.panel1.Location = new System.Drawing.Point(10, 51);
        //      this.panel1.Name = "panel1";
        //      this.panel1.Size = new System.Drawing.Size(364, 402);
        //      this.panel1.TabIndex = 7;
        //      // 
        //      // db
        //      // 
        //      this.db.AllowUserToAddRows = false;
        //      this.db.AllowUserToDeleteRows = false;
        //      this.db.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //      this.db.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        //      this.db.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
        //      this.db.ColumnHeadersVisible = false;
        //      this.db.ContextMenuStrip = this.deleteMessage;
        //      DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
        //      gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //      gridViewCellStyle.BackColor = SystemColors.Window;
        //      gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)204);
        //      gridViewCellStyle.ForeColor = SystemColors.ControlText;
        //      gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
        //      gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
        //      gridViewCellStyle.WrapMode = DataGridViewTriState.True;
        //      this.db.DefaultCellStyle = gridViewCellStyle;
        //      this.db.Dock = DockStyle.Fill;
        //      this.db.Location = new Point(0, 0);
        //      this.db.Name = "db";
        //      this.db.RowHeadersVisible = false;
        //      this.db.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //      this.db.Size = new Size(271, 433);
        //      this.db.TabIndex = 0;
        //      this.db.CellEndEdit += new DataGridViewCellEventHandler(this.Db_CellEndEdit);
        //      this.db.CurrentCellChanged += new EventHandler(this.Db_CurrentCellChanged);
        //      // 
        //      // trayExit
        //      // 
        //      this.trayExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        //      this.выходToolStripMenuItem1});
        //      this.trayExit.Name = "trayExit";
        //      this.trayExit.Size = new System.Drawing.Size(109, 26);
        //      // 
        //      // выходToolStripMenuItem1
        //      // 
        //      this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
        //      this.выходToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
        //      this.выходToolStripMenuItem1.Text = "Выход";
        //      this.выходToolStripMenuItem1.Click += new System.EventHandler(this.TrayIconExit);
        //      // 
        //      // send
        //      // 
        //      this.send.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        //      this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        //      this.send.Image = global::Записная_книжка.Properties.Resources.insert6060;
        //      this.send.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
        //      this.send.Location = new System.Drawing.Point(299, 459);
        //      this.send.Name = "send";
        //      this.send.Size = new System.Drawing.Size(75, 83);
        //      this.send.TabIndex = 2;
        //      this.send.Text = "Добавить";
        //      this.send.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        //      this.send.UseVisualStyleBackColor = true;
        //      this.send.Click += new System.EventHandler(this.Send_Click);
        //      // 
        //      // AllTables
        //      // 
        //      this.AllTables.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        //      this.AllTables.ContextMenuStrip = this.deleteTable;
        //      this.AllTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //      this.AllTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        //      this.AllTables.Location = new System.Drawing.Point(10, 24);
        //      this.AllTables.Name = "AllTables";
        //      this.AllTables.Size = new System.Drawing.Size(121, 21);
        //      this.AllTables.TabIndex = 8;
        //      this.AllTables.SelectedIndexChanged += new System.EventHandler(this.TableChanged);
        //      // 
        //      // deleteTable
        //      // 
        //      this.deleteTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        //      this.удалитьToolStripMenuItem1});
        //      this.deleteTable.Name = "deleteTable";
        //      this.deleteTable.Size = new System.Drawing.Size(119, 26);
        //      // 
        //      // удалитьToolStripMenuItem1
        //      // 
        //      this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
        //      this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
        //      this.удалитьToolStripMenuItem1.Text = "Удалить";
        //      this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteTable_Click);
        //      // 
        //      // deleteMessage
        //      // 
        //      this.deleteMessage.Items.AddRange(new ToolStripItem[3]
        //            {
        //              (ToolStripItem) this.копироватьToolStripMenuItem,
        //              (ToolStripItem) this.переместитьToolStripMenuItem,
        //              (ToolStripItem) this.удалитьToolStripMenuItem
        //            });
        //      this.deleteMessage.Name = "deleting";
        //      this.deleteMessage.Size = new System.Drawing.Size(181, 92);
        //      this.deleteMessage.Text = "Удалить";
        //      // 
        //      // удалитьToolStripMenuItem
        //      // 
        //      this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
        //      this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        //      this.удалитьToolStripMenuItem.Text = "Удалить";
        //      this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecords_Click);
        //      // 
        //      // trayIcon
        //      // 
        //      this.trayIcon.ContextMenuStrip = this.trayExit;
        //      this.trayIcon.Text = "Записная книжка";
        //      this.trayIcon.Visible = true;
        //      this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_Click);
        //      // 
        //      // копироваToolStripMenuItem
        //      // 
        //      this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
        //      this.копироватьToolStripMenuItem.Size = new Size(180, 22);
        //      this.копироватьToolStripMenuItem.Text = "Копировать";
        //      // 
        //      // переместитьToolStripMenuItem
        //      // 
        //      this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
        //this.переместитьToolStripMenuItem.Size = new Size(180, 22);
        //this.переместитьToolStripMenuItem.Text = "Переместить";
        //      // 
        //      // MainWindowRe
        //      // 
        //      this.AcceptButton = this.send;
        //      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //      this.ClientSize = new System.Drawing.Size(383, 564);
        //      this.Controls.Add(this.AllTables);
        //      this.Controls.Add(this.send);
        //      this.Controls.Add(this.db);
        //      this.Controls.Add(this.panel1);
        //      this.Controls.Add(this.infoLabel);
        //      this.Controls.Add(this.label1);
        //      this.Controls.Add(this.work);
        //      this.Controls.Add(this.topMenu);
        //      this.KeyPreview = true;
        //      this.MainMenuStrip = this.topMenu;
        //      this.Name = "MainWindowRe";
        //      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //      this.Text = "Записная книжка";
        //      this.Load += new System.EventHandler(this.MainWindow_Load);
        //      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
        //      this.topMenu.ResumeLayout(false);
        //      this.topMenu.PerformLayout();
        //      ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
        //      this.trayExit.ResumeLayout(false);
        //      this.deleteTable.ResumeLayout(false);
        //      this.deleteMessage.ResumeLayout(false);
        //      this.ResumeLayout(false);
        //      this.PerformLayout();

        //  }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllTables = new System.Windows.Forms.ListBox();
            this.deleteTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTable = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.work = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayExit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db = new Записная_книжка.DBView();
            this.send = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PassDV = new Записная_книжка.DBView();
            this.deletePass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTable.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.deleteMessage.SuspendLayout();
            this.trayExit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassDV)).BeginInit();
            this.deletePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTables
            // 
            this.AllTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllTables.ContextMenuStrip = this.deleteTable;
            this.AllTables.FormattingEnabled = true;
            this.AllTables.Location = new System.Drawing.Point(2, 6);
            this.AllTables.Name = "AllTables";
            this.AllTables.Size = new System.Drawing.Size(88, 394);
            this.AllTables.TabIndex = 8;
            this.AllTables.SelectedIndexChanged += new System.EventHandler(this.TableChanged);
            // 
            // deleteTable
            // 
            this.deleteTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1});
            this.deleteTable.Name = "deleteTable";
            this.deleteTable.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.DeleteTable_Click);
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.newTable,
            this.новыйПарольToolStripMenuItem,
            this.отчётToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(428, 24);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Записная_книжка.Properties.Resources.exit;
            this.выходToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // newTable
            // 
            this.newTable.Image = global::Записная_книжка.Properties.Resources.add;
            this.newTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newTable.Name = "newTable";
            this.newTable.Size = new System.Drawing.Size(135, 20);
            this.newTable.Text = "Добавить таблицу";
            this.newTable.Click += new System.EventHandler(this.NewTable_Click);
            // 
            // новыйПарольToolStripMenuItem
            // 
            this.новыйПарольToolStripMenuItem.Name = "новыйПарольToolStripMenuItem";
            this.новыйПарольToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.новыйПарольToolStripMenuItem.Text = "Добавить пароль";
            this.новыйПарольToolStripMenuItem.Click += new System.EventHandler(this.добавитьПарольToolStripMenuItem_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.Image = global::Записная_книжка.Properties.Resources.floppy_disk_save_button;
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            this.отчётToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.отчётToolStripMenuItem.Click += new System.EventHandler(this.ОтчётToolStripMenuItem_Click);
            // 
            // work
            // 
            this.work.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.work.Location = new System.Drawing.Point(2, 406);
            this.work.Multiline = true;
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(334, 82);
            this.work.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Последнее действие:";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.infoLabel.Location = new System.Drawing.Point(125, 548);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 6;
            // 
            // deleteMessage
            // 
            this.deleteMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.переместитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.deleteMessage.Name = "deleting";
            this.deleteMessage.Size = new System.Drawing.Size(147, 70);
            this.deleteMessage.Text = "Удалить";
            this.deleteMessage.Opening += new System.ComponentModel.CancelEventHandler(this.DeleteMessage_Opening_1);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteRecords_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayExit;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Записная книжка";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick_1);
            // 
            // trayExit
            // 
            this.trayExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1});
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(109, 26);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.TrayIconExit);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.db);
            this.panel1.Location = new System.Drawing.Point(96, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 394);
            this.panel1.TabIndex = 7;
            // 
            // db
            // 
            this.db.AllowUserToAddRows = false;
            this.db.AllowUserToDeleteRows = false;
            this.db.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.db.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.db.ColumnHeadersVisible = false;
            this.db.ContextMenuStrip = this.deleteMessage;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db.DefaultCellStyle = dataGridViewCellStyle1;
            this.db.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db.Location = new System.Drawing.Point(0, 0);
            this.db.Name = "db";
            this.db.RowHeadersVisible = false;
            this.db.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.db.Size = new System.Drawing.Size(319, 394);
            this.db.TabIndex = 0;
            this.db.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Db_CellEndEdit);
            this.db.CurrentCellChanged += new System.EventHandler(this.Db_CurrentCellChanged);
            // 
            // send
            // 
            this.send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.send.Image = global::Записная_книжка.Properties.Resources.insert6060;
            this.send.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.send.Location = new System.Drawing.Point(340, 406);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 82);
            this.send.TabIndex = 2;
            this.send.Text = "Добавить";
            this.send.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 521);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.send);
            this.tabPage1.Controls.Add(this.work);
            this.tabPage1.Controls.Add(this.AllTables);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Записи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PassDV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Хранилище паролей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PassDV
            // 
            this.PassDV.AllowUserToAddRows = false;
            this.PassDV.AllowUserToDeleteRows = false;
            this.PassDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PassDV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.PassDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassDV.ContextMenuStrip = this.deletePass;
            this.PassDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PassDV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PassDV.Location = new System.Drawing.Point(3, 3);
            this.PassDV.MultiSelect = false;
            this.PassDV.Name = "PassDV";
            this.PassDV.ReadOnly = true;
            this.PassDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PassDV.Size = new System.Drawing.Size(415, 489);
            this.PassDV.TabIndex = 0;
            this.PassDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PassDV_CellClick);
            // 
            // deletePass
            // 
            this.deletePass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem2});
            this.deletePass.Name = "contextMenuStrip1";
            this.deletePass.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 567);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.topMenu;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записная книжка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.deleteTable.ResumeLayout(false);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.deleteMessage.ResumeLayout(false);
            this.trayExit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PassDV)).EndInit();
            this.deletePass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MenuStrip topMenu;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem newTable;
        private Button send;
        private TextBox work;
        private Label label1;
        private Label infoLabel;
        private DBView db;
        private ContextMenuStrip deleteMessage;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ContextMenuStrip deleteTable;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayExit;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem переместитьToolStripMenuItem;
        private ListBox AllTables;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem новыйПарольToolStripMenuItem;
        private DBView PassDV;
        private ContextMenuStrip deletePass;
        private ToolStripMenuItem удалитьToolStripMenuItem2;
    }
}