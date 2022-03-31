
namespace TrainingPractice_02
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFirstFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSecondFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSelectAddedWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSelectEditedWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSelectRemovedWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.compareFilesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFirstFileToolStripMenuItem,
            this.openSecondFileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openFirstFileToolStripMenuItem
            // 
            this.openFirstFileToolStripMenuItem.Name = "openFirstFileToolStripMenuItem";
            this.openFirstFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.openFirstFileToolStripMenuItem.Text = "Открыть исходный файл";
            this.openFirstFileToolStripMenuItem.Click += new System.EventHandler(this.openFirstFileToolStripMenuItem_Click);
            // 
            // openSecondFileToolStripMenuItem
            // 
            this.openSecondFileToolStripMenuItem.Name = "openSecondFileToolStripMenuItem";
            this.openSecondFileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.openSecondFileToolStripMenuItem.Text = "Открыть изменённый файл";
            this.openSecondFileToolStripMenuItem.Click += new System.EventHandler(this.openSecondFileToolStripMenuItem_Click);
            // 
            // compareFilesToolStripMenuItem
            // 
            this.compareFilesToolStripMenuItem.Enabled = false;
            this.compareFilesToolStripMenuItem.Name = "compareFilesToolStripMenuItem";
            this.compareFilesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.compareFilesToolStripMenuItem.Text = "Сравнить файлы";
            this.compareFilesToolStripMenuItem.Click += new System.EventHandler(this.compareFilesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorSelectAddedWordToolStripMenuItem,
            this.colorSelectEditedWordToolStripMenuItem,
            this.colorSelectRemovedWordToolStripMenuItem,
            this.colorFontToolStripMenuItem,
            this.styleFontToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // colorSelectAddedWordToolStripMenuItem
            // 
            this.colorSelectAddedWordToolStripMenuItem.Name = "colorSelectAddedWordToolStripMenuItem";
            this.colorSelectAddedWordToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.colorSelectAddedWordToolStripMenuItem.Text = "Цвет выделения добавленных слов";
            this.colorSelectAddedWordToolStripMenuItem.Click += new System.EventHandler(this.colorSelectAddedWordToolStripMenuItem_Click);
            // 
            // colorSelectEditedWordToolStripMenuItem
            // 
            this.colorSelectEditedWordToolStripMenuItem.Name = "colorSelectEditedWordToolStripMenuItem";
            this.colorSelectEditedWordToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.colorSelectEditedWordToolStripMenuItem.Text = "Цвет выделения изменённых слов";
            this.colorSelectEditedWordToolStripMenuItem.Click += new System.EventHandler(this.colorSelectEditedWordToolStripMenuItem_Click);
            // 
            // colorSelectRemovedWordToolStripMenuItem
            // 
            this.colorSelectRemovedWordToolStripMenuItem.Name = "colorSelectRemovedWordToolStripMenuItem";
            this.colorSelectRemovedWordToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.colorSelectRemovedWordToolStripMenuItem.Text = "Цвет выделения удалённых слов";
            this.colorSelectRemovedWordToolStripMenuItem.Click += new System.EventHandler(this.colorSelectRemovedWordToolStripMenuItem_Click);
            // 
            // colorFontToolStripMenuItem
            // 
            this.colorFontToolStripMenuItem.Name = "colorFontToolStripMenuItem";
            this.colorFontToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.colorFontToolStripMenuItem.Text = "Цвет шрифта";
            this.colorFontToolStripMenuItem.Click += new System.EventHandler(this.colorFontToolStripMenuItem_Click);
            // 
            // styleFontToolStripMenuItem
            // 
            this.styleFontToolStripMenuItem.Name = "styleFontToolStripMenuItem";
            this.styleFontToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.styleFontToolStripMenuItem.Text = "Стиль шрифта";
            this.styleFontToolStripMenuItem.Click += new System.EventHandler(this.styleFontToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(652, 420);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 420);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(323, 420);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Программа для визуального сравнения текстовых файлов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem openFirstFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSecondFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSelectAddedWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSelectEditedWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSelectRemovedWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

