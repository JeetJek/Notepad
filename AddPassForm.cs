using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Записная_книжка
{
    public class AddPassForm : Form
    {
        private DBWorker worker = new DBWorker();
        private IContainer components = (IContainer)null;
        private Button AddPass;
        private Button cancel;
        private TextBox User;
        private Label label1;
        private Label label2;
        private TextBox Pass;
        private Label label3;
        public TextBox Info;

        public AddPassForm()
        {
            this.InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPage_Click(object sender, EventArgs e)
        {
            this.worker.NewPass(this.Info.Text, this.User.Text, this.Pass.Text);
            this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AddPass = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPass
            // 
            this.AddPass.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddPass.Location = new System.Drawing.Point(101, 100);
            this.AddPass.Name = "AddPass";
            this.AddPass.Size = new System.Drawing.Size(100, 23);
            this.AddPass.TabIndex = 4;
            this.AddPass.Text = "Добавить";
            this.AddPass.UseVisualStyleBackColor = true;
            this.AddPass.Click += new System.EventHandler(this.AddPage_Click);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(12, 64);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(189, 30);
            this.Info.TabIndex = 2;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(12, 100);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(80, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(12, 25);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(84, 20);
            this.User.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(101, 25);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 1;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пояснение";
            // 
            // AddPassForm
            // 
            this.AcceptButton = this.AddPass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(207, 131);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.AddPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "AddPassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
