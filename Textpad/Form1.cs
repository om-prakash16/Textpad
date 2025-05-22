using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Net;
using System.Net.Http;



using logictext;
using System.Web.Script.Serialization;
using System.Collections;

namespace Textpad
{
    public partial class TextPad : Form
    {
        PromptBuilder pb = new PromptBuilder();
       
        Choices clist = new Choices();
        FileOperations fileOperations;
       
        public TextPad()
        {
            InitializeComponent();
            fileOperations = new FileOperations();
            fileOperations.initializeNewfile();
            this.Text = fileOperations.Filename;

        }
        SpeechSynthesizer speechSynthesizerObj;

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {
            txtArea.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            txtArea.Redo();
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            
            txtArea.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            txtArea.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            txtArea.Paste();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            txtArea.SelectedText = "";
        }

        private void Find_Click(object sender, EventArgs e)
        {

        }

        private void Selectall_Click(object sender, EventArgs e)
        {
            txtArea.SelectAll();
        }

        private void timedate_Click(object sender, EventArgs e)
        {
            txtArea.Text = System.DateTime.Now.ToString();
        }

        private void font_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtArea.Font = fontDialog.Font;
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            
        }

        private void Zoomin_Click(object sender, EventArgs e)
        {

            float zoomout = txtArea.ZoomFactor;
            if (zoomout * 2 > 0.015625)
            {
                txtArea.ZoomFactor = zoomout / 2;
            }
        }

        private void Zoomout_Click(object sender, EventArgs e)
        {

            float zoomin = txtArea.ZoomFactor;
            if (zoomin * 2 < 64)
            {
                txtArea.ZoomFactor = zoomin * 2;
            }

        }

        private void Restoredefaultzoom_Click(object sender, EventArgs e)
        {
            txtArea.ZoomFactor = 1f;
        }

        private void TextPad_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            resume.Enabled = false;
            Pause.Enabled = false;
            Stop.Enabled = false;
        

        }

        private void play_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            if (txtArea.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.SpeakAsync(txtArea.Text);
                Pause.Enabled = true;
                Stop.Enabled = true;
              
            }
        }

       

        private void Pause_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    speechSynthesizerObj.Pause();
                    resume.Enabled = true;
                    play.Enabled = false;
                }
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
                    speechSynthesizerObj.Resume();
                    resume.Enabled = false;
                    play.Enabled = true;
                }

            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                speechSynthesizerObj.Dispose();
                play.Enabled = true;
                resume.Enabled = false;
                Pause.Enabled = false;
                Stop.Enabled = false;
            }
        }

        private void Newfile_Click(object sender, EventArgs e)
        {
            //on clicking the New,create new file
            //if the file is save create new file
            //if the is not saved create new file
            if (fileOperations.Isfilesaved)
            {
                txtArea.Text = " ";
                fileOperations.initializeNewfile();

                UpdateView();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save change?" + fileOperations.Filename, "Textpad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (fileOperations.Filename.Contains("Untitled"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Text(*.txt)|*.txt";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            fileOperations.SaveFile(newFileSave.FileName, txtArea.Lines);
                            UpdateView();
                        }

                    }
                    else
                    {
                        fileOperations.SaveFile(fileOperations.FileLocation, txtArea.Lines);
                        UpdateView();
                    }

                }
                else if (result == DialogResult.No)
                {
                    txtArea.Text = " ";
                    fileOperations.initializeNewfile();
                    UpdateView();
                }

            }

        }

        private void UpdateView()
        {
            this.Text = !fileOperations.Isfilesaved ? fileOperations.Filename + "*" : fileOperations.Filename;
        }

        private void openfile_click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt";
            openFile.InitialDirectory = "C: ";
            openFile.Title = "Open File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtArea.TextChanged -= txtArea_TextChanged;
                txtArea.Text = fileOperations.FileOpen(openFile.FileName);
                txtArea.TextChanged += txtArea_TextChanged;
                UpdateView();


            }

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            fileOperations.Isfilesaved = false;
            UpdateView();
        }

        private void Savefile_Click(object sender, EventArgs e)
        {
            if (!fileOperations.Isfilesaved)
            {
                if (!this.Text.Contains("Untitled.txt"))
                {
                    fileOperations.SaveFile(fileOperations.FileLocation, txtArea.Lines);
                    UpdateView();
                }
                else if (this.Text.Contains("Untitled.txt"))
                {
                    SaveFile();
                    UpdateView();
                }
            }
        }

        private void SaveFile()
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.Filter = "Text(*.txt)|*.txt";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                fileOperations.SaveFile(fileSave.FileName, txtArea.Lines);
                UpdateView();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fileOperations.Isfilesaved)
            {
                Application.Exit();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save change the file?", "Textpad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
               if(result==DialogResult.Yes)
                {
                    if(this.Text.Contains("Untitled"))
                    {
                        SaveFile();
                    }
                    else
                    {
                        fileOperations.SaveFile(fileOperations.FileLocation, txtArea.Lines);
                        UpdateView();
                    }

                }
               else if (result == DialogResult.No)
                {
                    txtArea.Text = " ";
                    UpdateView();
                    Application.Exit();
                }
            }
            
        }

        private void Saveas_Click(object sender, EventArgs e)
        {
            SaveFile();
            UpdateView();
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                txtArea.BackColor = colorDialog.Color;
            }

        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtArea.ForeColor = colorDialog.Color;
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Fileop_Click(object sender, EventArgs e)
        {

        }

        private void NewWindow_Click(object sender, EventArgs e)
        {
            TextPad txtpad = new TextPad();
            txtpad.Show();
        }

        private void Pagesetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog setupDlg = new PageSetupDialog();
            setupDlg.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            setupDlg.PageSettings = new System.Drawing.Printing.PageSettings();
            setupDlg.EnableMetric = false;
            setupDlg.ShowDialog();
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
        }

        private void Print_Click(object sender, EventArgs e)
        {
           
            
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();

                }

            
           
           
        }

        private void speechRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void speakToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void speak_Click(object sender, EventArgs e)
        {
           

            

        }

        private void speak_Click_1(object sender, EventArgs e)
        {

        }

        private void speak_Click_2(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();
            sre.LoadGrammar(words);
            try
            {
                txtArea.Text = "Listening Now....";
                sre.SetInputToDefaultAudioDevice();
                RecognitionResult result = sre.Recognize();
                txtArea.Clear();
                txtArea.Text = result.Text;
            }
            catch
            {
                txtArea.Text = "";
                MessageBox.Show("Mic is not found");
            }
            finally
            {
                sre.UnloadAllGrammars();
            }
        }

        private void resunme_Click(object sender, EventArgs e)
        {
            
        }

        private void Stopp_Click(object sender, EventArgs e)
        {
        }

        private void Zoom_Click(object sender, EventArgs e)
        {

        }

        private void Abouttextpad_Click(object sender, EventArgs e)
        {

        }

        private void tohindi_Click(object sender, EventArgs e)
        {
            if(txtArea.Text!="")
            {
                txtArea.Text = TranslateText(txtArea.Text);
            }
            else
            {
                MessageBox.Show("Please Entert the text: ");
            }
           
           
        }
        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "hi", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        public string TranslateNep(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "en", "ne", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        private void Engtonep_Click(object sender, EventArgs e)
        {
            
            if(txtArea.Text!="")
            {
                txtArea.Text = TranslateNep(txtArea.Text);
            }
            else
            {
                MessageBox.Show("Please Enter the Text: ");
            }
          

        }


    }
}