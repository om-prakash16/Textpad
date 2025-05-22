
namespace Textpad
{
    partial class TextPad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPad));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Fileop = new System.Windows.Forms.ToolStripMenuItem();
            this.Newfile = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.Savefile = new System.Windows.Forms.ToolStripMenuItem();
            this.Saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.Pagesetup = new System.Windows.Forms.ToolStripMenuItem();
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Searchwithbing = new System.Windows.Forms.ToolStripMenuItem();
            this.Find = new System.Windows.Forms.ToolStripMenuItem();
            this.FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.FindPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.Goto = new System.Windows.Forms.ToolStripMenuItem();
            this.Selectall = new System.Windows.Forms.ToolStripMenuItem();
            this.timedate = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Color = new System.Windows.Forms.ToolStripMenuItem();
            this.pageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoomin = new System.Windows.Forms.ToolStripMenuItem();
            this.Zoomout = new System.Windows.Forms.ToolStripMenuItem();
            this.Restoredefaultzoom = new System.Windows.Forms.ToolStripMenuItem();
            this.Statusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.speechRecognitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.resume = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.texttoSpeechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speak = new System.Windows.Forms.ToolStripMenuItem();
            this.Stopp = new System.Windows.Forms.ToolStripMenuItem();
            this.translatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tohindi = new System.Windows.Forms.ToolStripMenuItem();
            this.Engtonep = new System.Windows.Forms.ToolStripMenuItem();
            this.Abouttextpad = new System.Windows.Forms.ToolStripMenuItem();
            this.txtArea = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fileop,
            this.edit,
            this.Format,
            this.viewToolStripMenuItem,
            this.speechRecognitionToolStripMenuItem,
            this.texttoSpeechToolStripMenuItem,
            this.translatorToolStripMenuItem,
            this.Abouttextpad});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(965, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menustrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // Fileop
            // 
            this.Fileop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Newfile,
            this.NewWindow,
            this.Openfile,
            this.Savefile,
            this.Saveas,
            this.Pagesetup,
            this.Print,
            this.exitToolStripMenuItem});
            this.Fileop.Name = "Fileop";
            this.Fileop.Size = new System.Drawing.Size(46, 26);
            this.Fileop.Text = "File";
            this.Fileop.Click += new System.EventHandler(this.Fileop_Click);
            // 
            // Newfile
            // 
            this.Newfile.Name = "Newfile";
            this.Newfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Newfile.Size = new System.Drawing.Size(274, 26);
            this.Newfile.Text = "New";
            this.Newfile.Click += new System.EventHandler(this.Newfile_Click);
            // 
            // NewWindow
            // 
            this.NewWindow.Name = "NewWindow";
            this.NewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.NewWindow.Size = new System.Drawing.Size(274, 26);
            this.NewWindow.Text = "New Window";
            this.NewWindow.Click += new System.EventHandler(this.NewWindow_Click);
            // 
            // Openfile
            // 
            this.Openfile.Name = "Openfile";
            this.Openfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Openfile.Size = new System.Drawing.Size(274, 26);
            this.Openfile.Text = "Open...";
            this.Openfile.Click += new System.EventHandler(this.openfile_click);
            // 
            // Savefile
            // 
            this.Savefile.Name = "Savefile";
            this.Savefile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Savefile.Size = new System.Drawing.Size(274, 26);
            this.Savefile.Text = "Save";
            this.Savefile.Click += new System.EventHandler(this.Savefile_Click);
            // 
            // Saveas
            // 
            this.Saveas.Name = "Saveas";
            this.Saveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Saveas.Size = new System.Drawing.Size(274, 26);
            this.Saveas.Text = "Save As...";
            this.Saveas.Click += new System.EventHandler(this.Saveas_Click);
            // 
            // Pagesetup
            // 
            this.Pagesetup.Name = "Pagesetup";
            this.Pagesetup.Size = new System.Drawing.Size(274, 26);
            this.Pagesetup.Text = "Page Setup...";
            this.Pagesetup.Click += new System.EventHandler(this.Pagesetup_Click);
            // 
            // Print
            // 
            this.Print.Name = "Print";
            this.Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Print.Size = new System.Drawing.Size(274, 26);
            this.Print.Text = "Print...";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.Redo,
            this.Cut,
            this.Copy,
            this.paste,
            this.Delete,
            this.Searchwithbing,
            this.Find,
            this.FindNext,
            this.FindPrevious,
            this.Replace,
            this.Goto,
            this.Selectall,
            this.timedate});
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(49, 26);
            this.edit.Text = "Edit";
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo.Size = new System.Drawing.Size(261, 26);
            this.undo.Text = "Undo";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // Redo
            // 
            this.Redo.Name = "Redo";
            this.Redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.Redo.Size = new System.Drawing.Size(261, 26);
            this.Redo.Text = "Redo";
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cut.Size = new System.Drawing.Size(261, 26);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copy.Size = new System.Drawing.Size(261, 26);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(261, 26);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.Delete.Size = new System.Drawing.Size(261, 26);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Searchwithbing
            // 
            this.Searchwithbing.Name = "Searchwithbing";
            this.Searchwithbing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.Searchwithbing.Size = new System.Drawing.Size(261, 26);
            this.Searchwithbing.Text = "Search with Bing...";
            // 
            // Find
            // 
            this.Find.Name = "Find";
            this.Find.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.Find.Size = new System.Drawing.Size(261, 26);
            this.Find.Text = "Find....";
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // FindNext
            // 
            this.FindNext.Name = "FindNext";
            this.FindNext.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.FindNext.Size = new System.Drawing.Size(261, 26);
            this.FindNext.Text = "Find Next";
            this.FindNext.Click += new System.EventHandler(this.findToolStripMenuItem1_Click);
            // 
            // FindPrevious
            // 
            this.FindPrevious.Name = "FindPrevious";
            this.FindPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.FindPrevious.Size = new System.Drawing.Size(261, 26);
            this.FindPrevious.Text = "Find Previous";
            // 
            // Replace
            // 
            this.Replace.Name = "Replace";
            this.Replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Replace.Size = new System.Drawing.Size(261, 26);
            this.Replace.Text = "Replace";
            // 
            // Goto
            // 
            this.Goto.Name = "Goto";
            this.Goto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Goto.Size = new System.Drawing.Size(261, 26);
            this.Goto.Text = "Go To...";
            // 
            // Selectall
            // 
            this.Selectall.Name = "Selectall";
            this.Selectall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Selectall.Size = new System.Drawing.Size(261, 26);
            this.Selectall.Text = "Select All";
            this.Selectall.Click += new System.EventHandler(this.Selectall_Click);
            // 
            // timedate
            // 
            this.timedate.Name = "timedate";
            this.timedate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timedate.Size = new System.Drawing.Size(261, 26);
            this.timedate.Text = "Time/Date";
            this.timedate.Click += new System.EventHandler(this.timedate_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Color,
            this.font});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(70, 26);
            this.Format.Text = "Format";
            // 
            // Color
            // 
            this.Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageColorToolStripMenuItem,
            this.foregroundToolStripMenuItem});
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(133, 26);
            this.Color.Text = "Color";
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // pageColorToolStripMenuItem
            // 
            this.pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            this.pageColorToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.pageColorToolStripMenuItem.Text = "PageColor";
            this.pageColorToolStripMenuItem.Click += new System.EventHandler(this.pageColorToolStripMenuItem_Click);
            // 
            // foregroundToolStripMenuItem
            // 
            this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
            this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.foregroundToolStripMenuItem.Text = "Foreground ";
            this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(133, 26);
            this.font.Text = "Font....";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zoom,
            this.Statusbar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // Zoom
            // 
            this.Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zoomin,
            this.Zoomout,
            this.Restoredefaultzoom});
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(158, 26);
            this.Zoom.Text = "Zoom";
            this.Zoom.Click += new System.EventHandler(this.Zoom_Click);
            // 
            // Zoomin
            // 
            this.Zoomin.Name = "Zoomin";
            this.Zoomin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Zoomin.Size = new System.Drawing.Size(290, 26);
            this.Zoomin.Text = "Zoom In";
            this.Zoomin.Click += new System.EventHandler(this.Zoomin_Click);
            // 
            // Zoomout
            // 
            this.Zoomout.Name = "Zoomout";
            this.Zoomout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.Zoomout.Size = new System.Drawing.Size(290, 26);
            this.Zoomout.Text = "Zoom Out";
            this.Zoomout.Click += new System.EventHandler(this.Zoomout_Click);
            // 
            // Restoredefaultzoom
            // 
            this.Restoredefaultzoom.Name = "Restoredefaultzoom";
            this.Restoredefaultzoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Restoredefaultzoom.Size = new System.Drawing.Size(290, 26);
            this.Restoredefaultzoom.Text = "Restore Default zoom";
            this.Restoredefaultzoom.Click += new System.EventHandler(this.Restoredefaultzoom_Click);
            // 
            // Statusbar
            // 
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(158, 26);
            this.Statusbar.Text = "Status Bar";
            // 
            // speechRecognitionToolStripMenuItem
            // 
            this.speechRecognitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.play,
            this.Pause,
            this.resume,
            this.Stop});
            this.speechRecognitionToolStripMenuItem.Name = "speechRecognitionToolStripMenuItem";
            this.speechRecognitionToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.speechRecognitionToolStripMenuItem.Text = "Text-to-Speech";
            this.speechRecognitionToolStripMenuItem.Click += new System.EventHandler(this.speechRecognitionToolStripMenuItem_Click);
            // 
            // play
            // 
            this.play.Name = "play";
            this.play.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Space)));
            this.play.Size = new System.Drawing.Size(230, 26);
            this.play.Text = "Play";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Pause
            // 
            this.Pause.Name = "Pause";
            this.Pause.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.Pause.Size = new System.Drawing.Size(230, 26);
            this.Pause.Text = "Pause";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // resume
            // 
            this.resume.Name = "resume";
            this.resume.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.resume.Size = new System.Drawing.Size(230, 26);
            this.resume.Text = "Resume";
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // Stop
            // 
            this.Stop.Name = "Stop";
            this.Stop.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.Stop.Size = new System.Drawing.Size(230, 26);
            this.Stop.Text = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // texttoSpeechToolStripMenuItem
            // 
            this.texttoSpeechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speak,
            this.Stopp});
            this.texttoSpeechToolStripMenuItem.Name = "texttoSpeechToolStripMenuItem";
            this.texttoSpeechToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.texttoSpeechToolStripMenuItem.Text = "Speech-to-Text";
            // 
            // speak
            // 
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(132, 26);
            this.speak.Text = "Speak";
            this.speak.Click += new System.EventHandler(this.speak_Click_2);
            // 
            // Stopp
            // 
            this.Stopp.Name = "Stopp";
            this.Stopp.Size = new System.Drawing.Size(132, 26);
            this.Stopp.Text = "Stop";
            this.Stopp.Click += new System.EventHandler(this.Stopp_Click);
            // 
            // translatorToolStripMenuItem
            // 
            this.translatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tohindi,
            this.Engtonep});
            this.translatorToolStripMenuItem.Name = "translatorToolStripMenuItem";
            this.translatorToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.translatorToolStripMenuItem.Text = "Translator";
            // 
            // tohindi
            // 
            this.tohindi.Name = "tohindi";
            this.tohindi.Size = new System.Drawing.Size(252, 26);
            this.tohindi.Text = "Translate Eng to Hindi";
            this.tohindi.Click += new System.EventHandler(this.tohindi_Click);
            // 
            // Engtonep
            // 
            this.Engtonep.Name = "Engtonep";
            this.Engtonep.Size = new System.Drawing.Size(252, 26);
            this.Engtonep.Text = "Translate English to Nep";
            this.Engtonep.Click += new System.EventHandler(this.Engtonep_Click);
            // 
            // Abouttextpad
            // 
            this.Abouttextpad.Name = "Abouttextpad";
            this.Abouttextpad.Size = new System.Drawing.Size(121, 26);
            this.Abouttextpad.Text = "About Textpad";
            this.Abouttextpad.Click += new System.EventHandler(this.Abouttextpad_Click);
            // 
            // txtArea
            // 
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArea.Location = new System.Drawing.Point(0, 30);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(965, 610);
            this.txtArea.TabIndex = 2;
            this.txtArea.Text = "";
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // TextPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 640);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TextPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextPad";
            this.Load += new System.EventHandler(this.TextPad_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Fileop;
        private System.Windows.Forms.ToolStripMenuItem Newfile;
        private System.Windows.Forms.ToolStripMenuItem NewWindow;
        private System.Windows.Forms.ToolStripMenuItem Openfile;
        private System.Windows.Forms.ToolStripMenuItem Savefile;
        private System.Windows.Forms.ToolStripMenuItem Saveas;
        private System.Windows.Forms.ToolStripMenuItem Pagesetup;
        private System.Windows.Forms.ToolStripMenuItem Print;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Searchwithbing;
        private System.Windows.Forms.ToolStripMenuItem Find;
        private System.Windows.Forms.ToolStripMenuItem FindNext;
        private System.Windows.Forms.ToolStripMenuItem FindPrevious;
        private System.Windows.Forms.ToolStripMenuItem Replace;
        private System.Windows.Forms.ToolStripMenuItem Goto;
        private System.Windows.Forms.ToolStripMenuItem Selectall;
        private System.Windows.Forms.ToolStripMenuItem timedate;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Color;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Zoom;
        private System.Windows.Forms.ToolStripMenuItem Zoomin;
        private System.Windows.Forms.ToolStripMenuItem Zoomout;
        private System.Windows.Forms.ToolStripMenuItem Restoredefaultzoom;
        private System.Windows.Forms.ToolStripMenuItem Abouttextpad;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.ToolStripMenuItem Statusbar;
        private System.Windows.Forms.RichTextBox txtArea;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem speechRecognitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem play;
        private System.Windows.Forms.ToolStripMenuItem Pause;
        private System.Windows.Forms.ToolStripMenuItem resume;
        private System.Windows.Forms.ToolStripMenuItem Stop;
        private System.Windows.Forms.ToolStripMenuItem pageColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.ToolStripMenuItem texttoSpeechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speak;
        private System.Windows.Forms.ToolStripMenuItem Stopp;
        private System.Windows.Forms.ToolStripMenuItem translatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tohindi;
        private System.Windows.Forms.ToolStripMenuItem Engtonep;
    }
}

