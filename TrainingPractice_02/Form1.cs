using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        static Font font = new Font("Times New Roman", 14);
        static bool pressed1 = false, pressed2 = false;
        ColorDialog colorDialog1 = new ColorDialog();
        static string[][] oldText, newText;
        static int[] oldEndOfSentences, newEndOfSentences;
        static int[] oldStartOfSentences, newStartOfSentences;
        static Color addColor = Color.LightGreen;
        static Color removeColor = Color.Red;
        static Color editColor = Color.Yellow;

        static List<Selection> selections = new List<Selection>();

        struct Selection
        {
            public int Start;
            public int End;
            public Color Color;
            public RichTextBox RichTextBox;
        }

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Font = font;
            richTextBox2.Font = font;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Завершить работу?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
                Application.Exit();
        }

        private void colorSelectAddedWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                addColor = colorDialog1.Color;
                compareFilesToolStripMenuItem.PerformClick();
            }
        }

        private void colorSelectEditedWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                editColor = colorDialog1.Color;
                compareFilesToolStripMenuItem.PerformClick();
            }
        }

        private void colorSelectRemovedWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                removeColor = colorDialog1.Color;
                compareFilesToolStripMenuItem.PerformClick();
            }
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
                richTextBox2.ForeColor = colorDialog1.Color;
            }
        }

        private void styleFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Font = fontDialog1.Font;
                richTextBox1.Font = fontDialog1.Font;
            }
        }
        private void openFirstFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (normalizeInput(ref oldText, ref oldEndOfSentences, ref oldStartOfSentences))
            {
                ClearSelection();
                fillRichTextBox(richTextBox1, oldText);
            }
            if (richTextBox1.TextLength != 0)
            {
                pressed1 = true;
                if (pressed1 && pressed2)
                {
                    compareFilesToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void openSecondFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (normalizeInput(ref newText, ref newEndOfSentences, ref newStartOfSentences))
            {
                ClearSelection();
                fillRichTextBox(richTextBox2, newText);
            }
            if (richTextBox2.TextLength != 0)
            {
                pressed2 = true;
                if (pressed1 && pressed2)
                {
                    compareFilesToolStripMenuItem.Enabled = true;
                }
            }
        }

        private bool normalizeInput(ref string[][] text, ref int[] endOfSentences, ref int[] startOfSentences)
        {
            var result = false;
            var file = string.Empty;
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files | *.txt",
                FileName = string.Empty
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                result = true;
                var indexes = new List<int>();
                file = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < file.Length; i++)
                {
                    if (file[i] == '.' ||
                        file[i] == '?' ||
                        file[i] == '!')
                    {
                        indexes.Add(i);
                    }
                }
                text = new string[indexes.Count][];
                var start = 0;
                for (int i = 0; i < indexes.Count; i++)
                {
                    var sentence = file[start..(indexes[i] + 1)];
                    text[i] = sentence.Split(' ');
                    start = indexes[i] + 2;
                }
                endOfSentences = indexes.ToArray();

                startOfSentences = new int[endOfSentences.Length];
                startOfSentences[0] = 0;

                for (int i = 0; i < endOfSentences.Length - 1; i++)
                {
                    startOfSentences[i + 1] = endOfSentences[i] + 2;
                }
            }
            return result;
        }

        private void fillRichTextBox(RichTextBox richTextBox, string[][] text)
        {
            richTextBox.Clear();
            foreach (var item in text)
            {
                foreach (var item2 in item)
                {
                    richTextBox.Text += item2 + ' ';
                }
            }

            foreach (var item in selections)
            {
                item.RichTextBox.Select(item.Start, item.End);
                item.RichTextBox.SelectionBackColor = item.Color;
            }
        }

        private void ClearSelection()
        {
            selections.Clear();
            richTextBox1.SelectAll();
            richTextBox1.SelectionBackColor = Color.White;
            richTextBox2.SelectAll();
            richTextBox2.SelectionBackColor = Color.White;
            richTextBox1.DeselectAll();
            richTextBox2.DeselectAll();
        }

        private void compareFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selections.Clear();
            if (richTextBox1.Text != richTextBox2.Text)
            {
                for (int i = 0; i < oldText.GetLength(0); i++)
                {
                    CompareSentences(oldText[i], newText[i], i);
                }

                fillRichTextBox(richTextBox1, oldText);
                fillRichTextBox(richTextBox2, newText);
                richTextBox1.Select(0, 0);
                richTextBox2.Select(0, 0);
            }
            else
            {
                MessageBox.Show("Файлы идентичны", "Сообщение", MessageBoxButtons.OK);
            }
        }

        private bool CompareSentences(string[] oldSentence, string[] newSentence, int number)
        {
            var sentenceSelection = new List<Selection>();
            var isWordCountEqual = false;

            if (oldSentence.Length == newSentence.Length)
            {
                isWordCountEqual = true;
            }

            if (isWordCountEqual)
            {
                //поиск всех модификаций в словах и выделение жёлтым
                var sum = 0;
                for (int i = 0; i < oldSentence.Length; i++)
                {

                    if (oldSentence[i] != newSentence[i])
                    {
                        var selection = new Selection();
                        selection.Start = newStartOfSentences[number] + sum;
                        selection.End = newSentence[i].Length;
                        selection.Color = editColor;
                        selection.RichTextBox = richTextBox2;
                        sentenceSelection.Add(selection);
                    }
                    sum += newSentence[i].Length + 1;
                }
                selections.AddRange(sentenceSelection);
                return true;
            }
            else
            {
                var offset = 0;
                //проверка на изменение слов в общем
                for (int i = 0; i < oldSentence.Length; i++)
                {
                    if (oldSentence[i] != newSentence[i + offset])
                    {
                        var selection = new Selection();
                        var start = 0;
                        var temp = offset;
                        while (temp != newSentence.Length - i &&
                               oldSentence[i] != newSentence[i + temp])
                        {
                            temp++;
                        }
                        if (temp == newSentence.Length - i)
                        {
                            temp = 0;
                            while (temp != oldSentence.Length - i &&
                               newSentence[i + offset] != oldSentence[i + temp])
                            {
                                temp++;
                            }
                            if (temp == oldSentence.Length - i)
                            {
                                return false;
                            }
                            else
                            {
                                for (int j = 0; j < i; j++)
                                {
                                    start += oldSentence[j].Length + 1;
                                }
                                var end = 0;
                                for (int j = i; j < i + temp; j++)
                                {
                                    end += oldSentence[j].Length + 1;
                                }
                                selection.Start = start + oldStartOfSentences[number];
                                selection.End = end - 1;
                                selection.Color = removeColor;
                                selection.RichTextBox = richTextBox1;
                                sentenceSelection.Add(selection);
                                offset--;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < i + offset; j++)
                            {
                                start += newSentence[j].Length + 1;
                            }
                            var end = 0;
                            for (int j = i + offset; j < i + temp; j++)
                            {
                                end += newSentence[j].Length + 1;
                            }
                            selection.Start = start + newStartOfSentences[number];
                            selection.End = end - 1;
                            selection.Color = addColor;
                            selection.RichTextBox = richTextBox2;
                            sentenceSelection.Add(selection);
                            offset = temp;
                        }
                    }

                }
                selections.AddRange(sentenceSelection);
                return true;
            }
        }
    }
}
