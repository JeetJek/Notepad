// Decompiled with JetBrains decompiler
// Type: Записная_книжка.NewPageForm
// Assembly: Записная книжка, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A0D518A3-D4BA-4371-9C44-D7D6E9D22E50
// Assembly location: D:\Драгоценный исходник записной книжки\Записная книжка.exe

using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Записная_книжка
{
  public class NewPageForm : Form
  {
    private DBWorker worker = new DBWorker();
    private IContainer components = (IContainer) null;
    private Button addPage;
    private Button cancel;
    public TextBox pageName;

    public NewPageForm()
    {
      this.InitializeComponent();
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void AddPage_Click(object sender, EventArgs e)
    {
      this.worker.CreateNewTable(this.pageName.Text);
      this.Close();
    }

    private void pageName_TextChanged(object sender, EventArgs e)
    {
      if (this.worker.Execute(new SQLiteCommand("select * from sqlite_master where type = 'table' and tbl_name='" + this.pageName.Text + "'")).Rows.Count < 1)
        this.addPage.Enabled = true;
      else
        this.addPage.Enabled = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.addPage = new Button();
      this.pageName = new TextBox();
      this.cancel = new Button();
      this.SuspendLayout();
      this.addPage.DialogResult = DialogResult.OK;
      this.addPage.Location = new Point(98, 39);
      this.addPage.Name = "addPage";
      this.addPage.Size = new Size(70, 23);
      this.addPage.TabIndex = 1;
      this.addPage.Text = "Добавить";
      this.addPage.UseVisualStyleBackColor = true;
      this.addPage.Click += new EventHandler(this.AddPage_Click);
      this.pageName.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.pageName.Location = new Point(12, 12);
      this.pageName.Name = "pageName";
      this.pageName.Size = new Size(156, 21);
      this.pageName.TabIndex = 0;
      this.pageName.TextChanged += new EventHandler(this.pageName_TextChanged);
      this.cancel.DialogResult = DialogResult.Cancel;
      this.cancel.Location = new Point(12, 39);
      this.cancel.Name = "cancel";
      this.cancel.Size = new Size(75, 23);
      this.cancel.TabIndex = 2;
      this.cancel.Text = "Отмена";
      this.cancel.UseVisualStyleBackColor = true;
      this.cancel.Click += new EventHandler(this.Cancel_Click);
      this.AcceptButton = (IButtonControl) this.addPage;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.cancel;
      this.ClientSize = new Size(183, 72);
      this.Controls.Add((Control) this.cancel);
      this.Controls.Add((Control) this.pageName);
      this.Controls.Add((Control) this.addPage);
      this.FormBorderStyle = FormBorderStyle.None;
      this.KeyPreview = true;
      this.Name = "NewPageForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "NewPage";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
