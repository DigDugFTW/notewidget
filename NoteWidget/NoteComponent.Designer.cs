namespace NoteWidget
{
    partial class NoteComponent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteComponent));
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.textBoxNoteName = new System.Windows.Forms.TextBox();
            this.buttonConfigure = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.richTextBoxMain = new System.Windows.Forms.RichTextBox();
            this.panelToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.LightBlue;
            this.panelToolBar.Controls.Add(this.textBoxNoteName);
            this.panelToolBar.Controls.Add(this.buttonConfigure);
            this.panelToolBar.Controls.Add(this.buttonClose);
            this.panelToolBar.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelToolBar.Location = new System.Drawing.Point(0, 2);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(273, 15);
            this.panelToolBar.TabIndex = 4;
            this.panelToolBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseClick);
            this.panelToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseDown);
            this.panelToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseMove);
            this.panelToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelToolBar_MouseUp);
            // 
            // textBoxNoteName
            // 
            this.textBoxNoteName.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxNoteName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoteName.Enabled = false;
            this.textBoxNoteName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteName.Location = new System.Drawing.Point(94, 0);
            this.textBoxNoteName.Name = "textBoxNoteName";
            this.textBoxNoteName.Size = new System.Drawing.Size(100, 13);
            this.textBoxNoteName.TabIndex = 3;
            this.textBoxNoteName.Text = "Edit Name";
            this.textBoxNoteName.DoubleClick += new System.EventHandler(this.textBoxNoteName_DoubleClick);
            this.textBoxNoteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNoteName_KeyDown);
            this.textBoxNoteName.Leave += new System.EventHandler(this.textBoxNoteName_Leave);
            // 
            // buttonConfigure
            // 
            this.buttonConfigure.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConfigure.AutoEllipsis = true;
            this.buttonConfigure.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfigure.FlatAppearance.BorderSize = 0;
            this.buttonConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigure.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfigure.Image")));
            this.buttonConfigure.Location = new System.Drawing.Point(0, 0);
            this.buttonConfigure.Name = "buttonConfigure";
            this.buttonConfigure.Size = new System.Drawing.Size(37, 15);
            this.buttonConfigure.TabIndex = 2;
            this.buttonConfigure.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonClose.AutoEllipsis = true;
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(258, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(15, 15);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // richTextBoxMain
            // 
            this.richTextBoxMain.BackColor = System.Drawing.Color.Ivory;
            this.richTextBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMain.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMain.Location = new System.Drawing.Point(0, 17);
            this.richTextBoxMain.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBoxMain.Name = "richTextBoxMain";
            this.richTextBoxMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxMain.Size = new System.Drawing.Size(275, 204);
            this.richTextBoxMain.TabIndex = 3;
            this.richTextBoxMain.Text = "";
            // 
            // NoteComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 219);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.richTextBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteComponent";
            this.Text = "NoteComponent";
            this.Load += new System.EventHandler(this.NoteComponent_Load);
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelToolBar;
        public System.Windows.Forms.TextBox textBoxNoteName;
        private System.Windows.Forms.Button buttonConfigure;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.RichTextBox richTextBoxMain;
    }
}