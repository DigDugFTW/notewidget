using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoteWidget
{

    #region TODO
    /*  If no instances exist show a blank note other wise --> deserialize data
     *  
     *  Completely redo and rethink the use of the NoteFormObject class.
     *  
     *  Instance tracker is a good idea, but doesn't need to be that flexible.
     * 
     *  Closing one instance shouldn't close all instances.
     *  
     *  One day, integrate this into a server for learning, sync data in a server and sign in to get note data.
     */
    #endregion



    public partial class NoteForm : Form
    {
        // Implement these in the NoteComponent
        //public event EventHandler<NoteFormEventArgs> WindowCreatedHandler;
        //public event EventHandler<NoteFormEventArgs> WindowLoadedHandler;
        //public event EventHandler<NoteFormEventArgs> WindowClosedHandler;


      

        public NoteForm()
        {
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
           
            InstanceManager<NoteComponent>.DeSerializeNoteFormObjects();
            
        }

    
        

        #region Tool Bar Dragging
        private Point _mouseDownPoint;
        private bool _mouseDown = false;
        private void panelToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownPoint = e.Location;
            _mouseDown = true;
        }

        private void panelToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void panelToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point((Location.X - _mouseDownPoint.X) + e.X, (Location.Y - _mouseDownPoint.Y) + e.Y);
            }
        }
        #endregion

       


    }
}
