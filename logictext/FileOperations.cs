using System;                         
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logictext
{
    public class FileOperations
    {
        private string filename;
        private bool isfilesaved;
        private string fileLocation;

        public string Filename { get => filename; set => filename = value; }
        public bool Isfilesaved { get => isfilesaved; set => isfilesaved = value; }
        public string FileLocation { get => fileLocation; set => fileLocation = value; }

        public void initializeNewfile()
        {
            this.Filename = "Untitled.txt";
            this.Isfilesaved= true;
        }

       

        private void UpdateFileStatus()
        {
            string filename = FileLocation.Substring(FileLocation.LastIndexOf("\\") + 1);
            this.Filename=filename;
            this.Isfilesaved = true;
        }

        public string FileOpen(string fileLocation)
        {
            string content;
            this.FileLocation = fileLocation;
            Stream stream = File.Open(fileLocation, FileMode.Open, FileAccess.ReadWrite);
           using(StreamReader streamReader=new StreamReader(stream))
            {
                content = streamReader.ReadToEnd();
            }
            UpdateFileStatus();
            return content;
        }

        public void SaveFile(string fileLocation, string[] lines)
        {
            this.FileLocation = fileLocation;
            Stream stream = File.Open(FileLocation, FileMode.OpenOrCreate, FileAccess.Write);
            using(StreamWriter streamWriter=new StreamWriter(stream))
            {
                foreach (string line in lines)
                {
                    streamWriter.WriteLine(line);
                }
            }
            UpdateFileStatus();

        }
    }
}