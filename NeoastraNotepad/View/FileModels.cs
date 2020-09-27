using Microsoft.Win32;
using NeoastraNotepad.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NeoastraNotepad.View
{
    public class FileModels
    {

        public NotepadComponent Notepad {get; set;}
        public ICommand New { get; }
        public ICommand Save { get; }
        public ICommand SaveAs { get; }
        public ICommand Open { get; }

        public FileModels(NotepadComponent notepad)
        {
            Notepad = notepad;
            New = new NotepadCommands(NewFile);
            Save = new NotepadCommands(SaveFile, () => !Notepad.isEmpty);
            SaveAs = new NotepadCommands(SaveFileAs);
            Open = new NotepadCommands(OpenFile);
        }

        public void NewFile()
        {
            Notepad.FileName = string.Empty;
            Notepad.FilePath = string.Empty;
            Notepad.Text = string.Empty;
        }

        private void SaveFile()
        {
            File.WriteAllText(Notepad.FilePath, Notepad.Text);
        }

        private void SaveFileAs()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == true)
            {
                DockFile(saveFileDialog);
                File.WriteAllText(saveFileDialog.FileName, Notepad.Text);
            }
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DockFile(openFileDialog);
                Notepad.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void DockFile<T>(T dialog) where T : FileDialog
        {
            Notepad.FilePath = dialog.FileName;
            Notepad.FileName = dialog.SafeFileName;
        }
    }
}
