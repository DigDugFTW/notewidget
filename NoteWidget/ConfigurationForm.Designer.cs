namespace NoteWidget
{
    partial class ConfigurationForm
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
            this.fontDialogChangeFont = new System.Windows.Forms.FontDialog();
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.buttonChangeNoteBGColor = new System.Windows.Forms.Button();
            this.radioButtonEnableRandomNoteColor = new System.Windows.Forms.RadioButton();
            this.colorDialogChangePadColor = new System.Windows.Forms.ColorDialog();
            this.buttonDebugInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeFont.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeFont.Location = new System.Drawing.Point(27, 12);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(151, 32);
            this.buttonChangeFont.TabIndex = 1;
            this.buttonChangeFont.Text = "Change Font";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
            // 
            // buttonChangeNoteBGColor
            // 
            this.buttonChangeNoteBGColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNoteBGColor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeNoteBGColor.Location = new System.Drawing.Point(27, 50);
            this.buttonChangeNoteBGColor.Name = "buttonChangeNoteBGColor";
            this.buttonChangeNoteBGColor.Size = new System.Drawing.Size(151, 32);
            this.buttonChangeNoteBGColor.TabIndex = 2;
            this.buttonChangeNoteBGColor.Text = "Change Pad Color";
            this.buttonChangeNoteBGColor.UseVisualStyleBackColor = true;
            this.buttonChangeNoteBGColor.Click += new System.EventHandler(this.buttonChangeNoteBGColor_Click);
            // 
            // radioButtonEnableRandomNoteColor
            // 
            this.radioButtonEnableRandomNoteColor.AutoSize = true;
            this.radioButtonEnableRandomNoteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonEnableRandomNoteColor.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnableRandomNoteColor.Location = new System.Drawing.Point(37, 126);
            this.radioButtonEnableRandomNoteColor.Name = "radioButtonEnableRandomNoteColor";
            this.radioButtonEnableRandomNoteColor.Size = new System.Drawing.Size(132, 22);
            this.radioButtonEnableRandomNoteColor.TabIndex = 3;
            this.radioButtonEnableRandomNoteColor.TabStop = true;
            this.radioButtonEnableRandomNoteColor.Text = "Random Note Color";
            this.radioButtonEnableRandomNoteColor.UseVisualStyleBackColor = true;
            this.radioButtonEnableRandomNoteColor.CheckedChanged += new System.EventHandler(this.radioButtonEnableRandomNoteColor_CheckedChanged);
            // 
            // colorDialogChangePadColor
            // 
            this.colorDialogChangePadColor.AllowFullOpen = false;
            // 
            // buttonDebugInfo
            // 
            this.buttonDebugInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDebugInfo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebugInfo.Location = new System.Drawing.Point(27, 88);
            this.buttonDebugInfo.Name = "buttonDebugInfo";
            this.buttonDebugInfo.Size = new System.Drawing.Size(151, 32);
            this.buttonDebugInfo.TabIndex = 4;
            this.buttonDebugInfo.Text = "Debug info";
            this.buttonDebugInfo.UseVisualStyleBackColor = true;
            this.buttonDebugInfo.Click += new System.EventHandler(this.buttonDebugInfo_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 153);
            this.Controls.Add(this.buttonDebugInfo);
            this.Controls.Add(this.radioButtonEnableRandomNoteColor);
            this.Controls.Add(this.buttonChangeNoteBGColor);
            this.Controls.Add(this.buttonChangeFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialogChangeFont;
        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.Button buttonChangeNoteBGColor;
        private System.Windows.Forms.RadioButton radioButtonEnableRandomNoteColor;
        private System.Windows.Forms.ColorDialog colorDialogChangePadColor;
        private System.Windows.Forms.Button buttonDebugInfo;
    }
}