using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Записная_книжка
{
    public partial class MainWindow : Form
    {
        private DBWorker dBworker = new DBWorker();
        private List<string> tables = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Data.db"))
            {
                SQLiteConnection.CreateFile("Data.db");
                this.dBworker.CreateSettings();
                this.dBworker.CreatePasswordsTable();
                this.infoLabel.Text = "База создана";
            }
            else
            {
                DataTable dataTable = this.dBworker.Execute(new SQLiteCommand("SELECT * FROM SETTINGS"));
                if (dataTable.Rows.Count == 0)
                    this.dBworker.CreateSettings();
                dataTable.Dispose();
                UpdatePassSaverDV();
                this.infoLabel.Text = "Загружена БД";
            }
            this.tables = this.dBworker.GetTables();
            for (int index = 0; index < this.tables.Count; ++index)
                this.AllTables.Items.Add((object)this.tables[index]);
            if (this.AllTables.Items.Count > 0)
            {
                this.AllTables.SelectedIndex = this.dBworker.GetActiveTable();
                this.db.DataSource = (object)this.dBworker.LoadTable(this.AllTables.SelectedItem.ToString());
                this.db.Columns["id"].Visible = false;
                this.db.Columns["time"].Width = 76;
                try
                {
                    this.db.CurrentCell = this.db.Rows[this.dBworker.GetActiveRow()].Cells[1];
                }
                catch
                {
                }
            }
            this.trayIcon.Visible = true;
        }

        private void UpdateNotepadDV()
        {
            this.db.DataSource = (object)null;
            this.db.table = this.dBworker.LoadTable(this.AllTables.SelectedItem.ToString());
            this.dBworker.SetActiveTable(this.AllTables.SelectedIndex);
            this.db.DataSource = (object)this.db.table;
            try
            {
                this.dBworker.SetActiveRow(this.db.SelectedRows[0].Index);
            }
            catch
            {
            }
            this.db.Columns["id"].Visible = false;
            this.db.Columns["time"].Width = 76;
        }
        private void UpdatePassSaverDV()
        {
            this.PassDV.DataSource =null;
            this.db.table = this.dBworker.LoadTable("passwords");
            this.PassDV.DataSource =this.db.table;
            this.PassDV.Columns["id"].Visible = false;
            this.PassDV.Columns["pass"].Visible = false;
            
            this.PassDV.Columns["user"].HeaderText= "Пользователь";
            this.PassDV.Columns["info"].HeaderText= "Пояснение";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (!(this.work.Text.Replace(" ", "") != ""))
                return;
            if (AllTables.SelectedIndex >= 0)
            {
                this.dBworker.InsertMessage(this.AllTables.SelectedItem.ToString(), this.work.Text);
                this.work.Clear();
                this.infoLabel.Text = "Добавлена запись";
                this.UpdateNotepadDV();
                this.db.CurrentCell = this.db.Rows[this.db.Rows.Count - 1].Cells[1];
            }
            else
            {
                MessageBox.Show("Выберите таблицу");
                this.work.Clear();
            }
        }

        private void NewTable_Click(object sender, EventArgs e)
        {
            int x = 30 + this.Location.X;
            int y = 10 + this.Location.Y + 50;
            NewPageForm newPageForm1 = new NewPageForm();
            newPageForm1.Location = new Point(x, y);
            NewPageForm newPageForm2 = newPageForm1;
            if (newPageForm2.ShowDialog() == DialogResult.OK)
            {
                this.AllTables.Items.Add((object)newPageForm2.pageName.Text);
                this.AllTables.SelectedItem = (object)newPageForm2.pageName.Text;
                newPageForm2.Dispose();
                this.infoLabel.Text = "Добавлена таблица";
            }
            newPageForm2.Dispose();
        }

        private void TableChanged(object sender, EventArgs e)
        {
            try
            {
                this.infoLabel.Text = "Выбрана таблица " + this.AllTables.SelectedItem.ToString();
                this.UpdateNotepadDV();
            }
            catch
            { }
        }

        private void DeleteRecords_Click(object sender, EventArgs e)
        {
            if (this.db.SelectedRows.Count > 1)
                this.infoLabel.Text = "Удалены записи";
            else
                this.infoLabel.Text = "Удалена запись";
            for (int index = 0; index < this.db.SelectedRows.Count; ++index)
                this.dBworker.DeleteMessage(this.AllTables.Text, int.Parse(this.db.SelectedRows[index].Cells[0].Value.ToString()));
            this.UpdateNotepadDV();
        }

        private void DeleteTable_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.AllTables.SelectedIndex;
            string text = this.AllTables.Text;
            this.AllTables.Items.RemoveAt(selectedIndex);
            this.dBworker.DeleteTable(text);
            if (selectedIndex > 0)
            {
                if (selectedIndex < this.AllTables.Items.Count)
                {
                    this.AllTables.SelectedIndex = selectedIndex;
                    this.UpdateNotepadDV();
                    this.infoLabel.Text = "Удалена таблица";
                }
                else
                {
                    this.AllTables.SelectedIndex = selectedIndex - 1;
                    this.UpdateNotepadDV();
                    this.infoLabel.Text = "Удалена таблица";
                }
            }
            else
            {
                this.AllTables.SelectedIndex = -1;
                this.db.DataSource = (object)null;
            }
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
                this.newTable.PerformClick();

            if (e.Control && e.KeyCode == Keys.W)
                Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrayIconExit(object sender, EventArgs e)
        {
            this.infoLabel.Text = "Выход";
            Application.Exit();
        }

        private void ОтчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|";
            saveFileDialog1.DefaultExt = "rtf";
            SaveFileDialog saveFileDialog2 = saveFileDialog1;
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                List<string> Records = new List<string>();
                for (int index = 0; index < this.db.table.Rows.Count; ++index)
                    Records.Add(this.db.table.Rows[index][1].ToString());
                Report report = new Report(Records);
                saveFileDialog2.AddExtension = true;
                report.Save(saveFileDialog2.FileName);
                Directory.SetCurrentDirectory(currentDirectory);
            }
            saveFileDialog2.Dispose();
        }

        private void Db_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.dBworker.SetActiveRow(this.db.SelectedRows[0].Index);
            }
            catch
            {
            }
        }

        private void Db_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.dBworker.UpdateMessage(this.AllTables.SelectedItem.ToString(), this.db[1, e.RowIndex].Value.ToString(), int.Parse(this.db[0, e.RowIndex].Value.ToString()));
        }

        public void Copy_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.db.SelectedRows.Count; ++index)
            {
                try
                {
                    this.dBworker.CopyMessage(this.AllTables.SelectedItem.ToString(), ((ToolStripItem)sender).Text, int.Parse(this.db.SelectedRows[index].Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show(ex.ToString());
                }
            }
        }

        public void Move_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < this.db.SelectedRows.Count; ++index)
            {
                try
                {
                    this.dBworker.MoveMessage(this.AllTables.SelectedItem.ToString(), ((ToolStripItem)sender).Text, int.Parse(this.db.SelectedRows[index].Cells[0].Value.ToString()));
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show(ex.ToString());
                }
            }
            this.UpdateNotepadDV();
        }

        private void NotepadContMenStrip_Openning(object sender, CancelEventArgs e)
        {
            this.копироватьToolStripMenuItem.DropDownItems.Clear();
            this.переместитьToolStripMenuItem.DropDownItems.Clear();
            foreach (string text in this.AllTables.Items)
            {
                ToolStripButton toolStripButton = new ToolStripButton(text);
                toolStripButton.Click += new EventHandler(this.Copy_Click);
                this.копироватьToolStripMenuItem.DropDownItems.Add((ToolStripItem)toolStripButton);
            }
            foreach (string text in this.AllTables.Items)
            {
                ToolStripButton toolStripButton = new ToolStripButton(text);
                toolStripButton.Click += new EventHandler(this.Move_Click);
                this.переместитьToolStripMenuItem.DropDownItems.Add((ToolStripItem)toolStripButton);
            }
        }

        private void добавитьПароль_Click(object sender, EventArgs e)
        {
            int x = 30 + this.Location.X;
            int y = 10 + this.Location.Y + 50;
            AddPassForm form1 = new AddPassForm();
            form1.Location = new Point(x, y);
            AddPassForm form2 = form1;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                this.infoLabel.Text = "Добавлен пароль";
                UpdatePassSaverDV();
            }
            form2.Dispose();
            form1.Dispose();
        }

        private void удалитьPass(object sender, EventArgs e)
        {
            if (this.PassDV.SelectedRows.Count > 1)
                this.infoLabel.Text = "Удалены записи";
            else
                this.infoLabel.Text = "Удалена запись";
            for (int index = 0; index < this.PassDV.SelectedRows.Count; ++index)
                this.dBworker.DeleteMessage("passwords", int.Parse(this.PassDV.SelectedRows[index].Cells[0].Value.ToString()));
            this.UpdatePassSaverDV();
        }

        private void PassDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Clipboard.SetText(this.PassDV.SelectedRows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            { }
            this.infoLabel.Text = "Скопировано";
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            e.Cancel = true;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
    }
}
