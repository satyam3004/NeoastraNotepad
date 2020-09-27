using NeoastraNotepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoastraNotepad.View
{
    public class HomePageModel
    {
        //Document that is saved, loaded and hold editor text
        public NotepadComponent _document { get; set; }
        public EditorViewModel Editor { get; set; }

        //saving and loading text files
        public FileModels File { get; set; }


        public HomePageModel()
        {
            _document = new NotepadComponent();
            File = new FileModels(_document);
            Editor = new EditorViewModel(_document);
        }
    }

    public class EditorViewModel
    {
        public NotepadComponent Document { get; set; }
        public EditorViewModel(NotepadComponent document)
        {
            Document = document;
        }
    }
}

