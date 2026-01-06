using CefSharp.DevTools.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surf
{
    public partial class SurfNotes : Form
    {
        private static List <string> notes = new List<string>();

        public SurfNotes()
        {
            start();
            noteSearch.AutoCompleteCustomSource.AddRange(notes.ToArray());
        }

        public void start() 
        {
            InitializeComponent();
            noteSearch.AutoCompleteCustomSource.AddRange(notes.ToArray()); 
        }

        private void notePad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.S || e.KeyCode == Keys.D))
            {
                if (title.Text.Contains(":") || title.Text.Contains("\\") || title.Text.Contains("/") || title.Text.Contains(".") || title.Text.Contains("*") || title.Text.Contains("?") || title.Text.Contains("\"")|| title.Text.Contains("<") || title.Text.Contains(">")|| title.Text.Contains("|")|| title.Text.Contains("<")|| title.Text.Contains(",")) 
                {
                    title.Text = title.Text.Replace(":", "-");
                    title.Text = title.Text.Replace("\\", "-");
                    title.Text = title.Text.Replace("/", "-");
                    title.Text = title.Text.Replace(".", "-");
                    title.Text = title.Text.Replace("*", "-");
                    title.Text = title.Text.Replace("?", "-");
                    title.Text = title.Text.Replace("\"", "-");
                    title.Text = title.Text.Replace("<", "-");
                    title.Text = title.Text.Replace(">", "-");
                    title.Text = title.Text.Replace("|", "-");
                    title.Text = title.Text.Replace(",", "-");
                }
                string path = @"C:\Users\monst\source\repos\Surf\SurfNotes\SurfNote-" + title.Text.Trim() + SurfUI.notesFileType;
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(notePad.Text);
                    fs.Write(info, 0, info.Length);
                }
                notes.Append(title.Text);
                noteSearch.AutoCompleteCustomSource.Add(title.Text);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            SurfNotes notes = new SurfNotes();

            notes.Show();
            notes.Activate();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            noteSearch.Visible = true;
            noteSearch.SelectAll();
            noteSearch.Focus();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (title.Text.Contains(":") || title.Text.Contains("\\") || title.Text.Contains("/") || title.Text.Contains(".") || title.Text.Contains("*") || title.Text.Contains("?") || title.Text.Contains("\"") || title.Text.Contains("<") || title.Text.Contains(">") || title.Text.Contains("|") || title.Text.Contains("<") || title.Text.Contains(","))
            {
                title.Text = title.Text.Replace(":", "-");
                title.Text = title.Text.Replace("\\", "-");
                title.Text = title.Text.Replace("/", "-");
                title.Text = title.Text.Replace(".", "-");
                title.Text = title.Text.Replace("*", "-");
                title.Text = title.Text.Replace("?", "-");
                title.Text = title.Text.Replace("\"", "-");
                title.Text = title.Text.Replace("<", "-");
                title.Text = title.Text.Replace(">", "-");
                title.Text = title.Text.Replace("|", "-");
                title.Text = title.Text.Replace(",", "-");
            }

            string path = @"C:\Users\monst\source\repos\Surf\SurfNotes\SurfNote-" + title.Text.Trim() + SurfUI.notesFileType;
            using (FileStream fs = File.Create(path))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(notePad.Text);
                fs.Write(info, 0, info.Length);
            }
            notes.Append(title.Text);
            noteSearch.AutoCompleteCustomSource.Add(title.Text);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            notePad.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            notePad.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            notePad.Paste();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void noteSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                notes.Append(noteSearch.Text);
                noteSearch.AutoCompleteCustomSource.AddRange(notes.ToArray());
                noteSearch.Visible = false;
                if (noteSearch.Text.Contains(":") || noteSearch.Text.Contains("\\") || noteSearch.Text.Contains("/") || noteSearch.Text.Contains(".") || noteSearch.Text.Contains("*") || noteSearch.Text.Contains("?") || noteSearch.Text.Contains("\"") || noteSearch.Text.Contains("<") || noteSearch.Text.Contains(">") || noteSearch.Text.Contains("|") || noteSearch.Text.Contains("<") || noteSearch.Text.Contains(","))
                {
                    noteSearch.Text = noteSearch.Text.Replace(":", "-");
                    noteSearch.Text = noteSearch.Text.Replace("\\", "-");
                    noteSearch.Text = noteSearch.Text.Replace("/", "-");
                    noteSearch.Text = noteSearch.Text.Replace(".", "-");
                    noteSearch.Text = noteSearch.Text.Replace("*", "-");
                    noteSearch.Text = noteSearch.Text.Replace("?", "-");
                    noteSearch.Text = noteSearch.Text.Replace("\"", "-");
                    noteSearch.Text = noteSearch.Text.Replace("<", "-");
                    noteSearch.Text = noteSearch.Text.Replace(">", "-");
                    noteSearch.Text = noteSearch.Text.Replace("|", "-");
                    noteSearch.Text = noteSearch.Text.Replace(",", "-");
                }

                string path = @"C:\Users\monst\source\repos\Surf\SurfNotes\SurfNote-" + noteSearch.Text.Trim();
                string defaultPath = path + SurfUI.notesFileType;
                if (File.Exists(defaultPath))
                {
                    notePad.Text = File.ReadAllText(defaultPath);
                    title.Text = noteSearch.Text;
                }
                else if (SurfUI.notesFileType == ".docx")
                {
                    string txtPath = path + ".txt";
                    if (File.Exists(txtPath))
                    {
                        notePad.Text = File.ReadAllText(txtPath);
                        title.Text = noteSearch.Text;
                    }
                    else 
                    {
                        return;
                    }
                }
                else if(SurfUI.notesFileType == ".txt")
                {
                    string docxPath = path + ".docx";
                    if (File.Exists(docxPath))
                    {
                        notePad.Text = File.ReadAllText(docxPath);
                        title.Text = noteSearch.Text;
                    }
                    else
                    {
                        title.Text = "No File Found";
                        return;
                    }
                }
                    noteSearch.Text = "";
            }
        }
    }
}
