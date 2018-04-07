using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteWidget
{
    public class NoteFormEventArgs : EventArgs
    {
        public NoteFormEventArgs() { }
        // Will send data about the window instance when an even is triggered.
        string WindowName
        {
            set;get;
        }


    }
}
