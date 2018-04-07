using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace NoteWidget
{
    public partial class NoteComponent : Form
    {
        public NoteComponent()
        {
            InitializeComponent();
        }
     
        public NoteComponent(string title, string content, Color tabColor, Color padColor)
        {
            InitializeComponent();
            textBoxNoteName.Text = title;
            richTextBoxMain.Text = content;
            panelToolBar.BackColor = tabColor;
            richTextBoxMain.BackColor = padColor;
        }

        private ContextMenu _toolBarContextMenu;
        private MenuItem[] _menuItemsToolBar;
        private void NoteComponent_Load(object sender, EventArgs e)
        {
            var newNoteEvent = new EventHandler(OnNewNote);
            var addTimerEvent = new EventHandler(OnAddTimer);
            var exitEvent = new EventHandler(OnApplicationExit);
            var changeNoteName = new EventHandler(OnChangeNoteName);
            //var removeNote = new EventHandler<NoteFormEventArgs>(OnNoteRemoved);
            var removeNote = new EventHandler(OnNoteRemoved);
            _menuItemsToolBar = new MenuItem[]
                {
                new MenuItem("New Note", newNoteEvent),
                new MenuItem("Add Timer", addTimerEvent),
                new MenuItem("Change Name", changeNoteName),
                new MenuItem("Remove Note", removeNote),
                new MenuItem("Exit", exitEvent)
                };

            _toolBarContextMenu = new ContextMenu(_menuItemsToolBar);

            
        }


      


        public override string ToString()
        {
            var serializedString =
                $"{Title}_" +
                $"{Content}_" +
                $"{PadColor}_" +
                $"{TabColor}_" +
                "&";

            return serializedString;
        }

        #region Tool Bar buttons
        private void buttonClose_Click(object sender, EventArgs e)
        {

            // Serialize data here.
            InstanceManager<NoteComponent>.SerializeNoteFormObjects();
            Application.Exit();
        }

        private void buttonConfigure_Click(object sender, EventArgs e)
        {
            //var configForm = new ConfigurationForm(this);
            //configForm.ShowDialog();
        }
        #endregion

        #region Tool Bar Context Menu
        private void panelToolBar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _toolBarContextMenu.Show(panelToolBar, e.Location);
            }
        }

        #endregion

        #region **TEMP, event handling for context menu items** | Custom events
        private void OnNewNote(object sender, EventArgs e)
        {
            var newInstance = new NoteComponent();
            InstanceManager<NoteComponent>.AddInstance(newInstance);
            newInstance.Show();
        }
        private void OnAddTimer(object sender, EventArgs e)
        {
            // Add system timer.
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            buttonClose_Click(this, null);
        }
        private void OnChangeNoteName(object sender, EventArgs e)
        {
            textBoxNoteName.Enabled = true;
        }

        private void OnNoteRemoved(object sender, EventArgs e)
        {
            InstanceManager<NoteComponent>.RemoveInstance(this);
            Close();
        }
        #endregion

        #region Tool Bar label
        private void textBoxNoteName_DoubleClick(object sender, EventArgs e)
        {
            textBoxNoteName.Enabled = true;
            textBoxNoteName.SelectAll();
        }

        private void textBoxNoteName_Leave(object sender, EventArgs e)
        {
            textBoxNoteName.Enabled = false;
        }

        private void textBoxNoteName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                textBoxNoteName.Enabled = false;
                richTextBoxMain.Focus();
            }
        }
        #endregion

        #region NoteComponent properties

        public string Title
        {
            get => textBoxNoteName.Text;
        }
        public string Content
        {
            get => richTextBoxMain.Text;
        }
        public Color TabColor
        {
            get => panelToolBar.BackColor;
        }
        public Color PadColor
        {
            get => richTextBoxMain.BackColor;
        }

        #endregion

        #region Custom draggable toolbar
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
                Location = new Point((Location.X - _mouseDownPoint.X) + e.X, (Location.Y - _mouseDownPoint.Y) + e.Y);
        }
        #endregion
    }
}
