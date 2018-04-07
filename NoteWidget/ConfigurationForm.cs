using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace NoteWidget
{
    public partial class ConfigurationForm : Form
    {
        private NoteForm _referenceForm;
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        // Overload to pass a reference to the main form.
        public ConfigurationForm(NoteForm formReference)
        {
            InitializeComponent();
            _referenceForm = formReference;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        #region Form buttons
        // Just change the font with reference to the main form.
        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            //if(fontDialogChangeFont.ShowDialog() == DialogResult.OK)
            //{
            //    foreach(var form in _referenceForm.noteFormInstances)
            //    {
            //        form.Font = Properties.Settings.Default.Font;
            //    }
            //}
        }
        // Change the richTextBoxMain background color.
        private void buttonChangeNoteBGColor_Click(object sender, EventArgs e)
        {
            //if (colorDialogChangePadColor.ShowDialog() == DialogResult.OK)
            //{
            //    _referenceForm.richTextBoxMain.BackColor = colorDialogChangePadColor.Color;
            //}
        }
        #endregion

        private void radioButtonEnableRandomNoteColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonDebugInfo_Click(object sender, EventArgs e)
        {
            // Instance tracker has the serialized data in the right format.
            /*
             *  // Format: (overridden ToString())
             *  var serializedString =
                 $"{Title}_\r\n" +
                 $"{Contents}_\r\n" +
                 $"{PadColor}_\r\n" +
                 $"{ToolBarColor}_\r\n" +
                 "&\r\n";
             * 
             */


            // Infinite loop of deserialization being created here.
         
        }
    }
}
