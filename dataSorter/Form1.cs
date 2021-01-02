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

namespace dataSorter
{
    public partial class mainForm : Form
    {
        string docName = "Documents";
        string musicName = "Musics";
        string picName = "Pictures";
        string vidName = "Videos";
        string appName = "Programs";

        public mainForm()
        {
            InitializeComponent();
        }

        private void folderEngine()
        {
            string endPath = txtPath.Text;

            string docfolder = System.IO.Path.Combine(endPath, docName);
            string musicfolder = System.IO.Path.Combine(endPath, musicName);
            string picfolder = System.IO.Path.Combine(endPath, picName);
            string vidfolder = System.IO.Path.Combine(endPath, vidName);
            string appfolder = System.IO.Path.Combine(endPath, appName);

            System.IO.Directory.CreateDirectory(docfolder);
            System.IO.Directory.CreateDirectory(musicfolder);
            System.IO.Directory.CreateDirectory(picfolder);
            System.IO.Directory.CreateDirectory(vidfolder);
            System.IO.Directory.CreateDirectory(appfolder);
        }

        private void sorterEngine()
        {
            string endPath = txtPath.Text;

            string[] docEx = {".doc", ".docx", ".txt", ".csv"};
            string[] musicEx = { ".mp3", ".ogg", ".wma", ".wav", ".flac", ".aac", ".aiff", ".alac", ".amr"};
            string[] picEx = {".jpg", ".jpeg", ".png", ".bmp", ".gif"};
            string[] vidEx = {".mp4", ".avi", ".flv", ".wmv", ".mov"};
            string[] appEx = {".exe", ".msi", ".iso", ".zip", ".rar"};

            var files = from file in Directory.EnumerateFiles(endPath)
                        select file;

            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string docPath = endPath + @"\Documents" + @"\" + fileName;
                string musicPath = endPath + @"\Musics" + @"\" + fileName;
                string picPath = endPath + @"\Pictures" + @"\" + fileName;
                string vidPath = endPath + @"\Videos" + @"\" + fileName;
                string appPath = endPath + @"\Programs" + @"\" + fileName;

                foreach (var doc in docEx)
                {
                    if(File.Exists(docPath))
                    {
                       
                    }
                    else
                    {
                        if (file.Contains(doc))
                        {
                            System.IO.File.Move(file, docPath);
                            lvStatus.Items.Add("Moved [" + fileName + "] to [" + docName + "] folder.");
                        }
                    }
                }

                foreach (var music in musicEx)
                {
                    if (File.Exists(musicPath))
                    {

                    }
                    else
                    {
                        if (file.Contains(music))
                        {
                            System.IO.File.Move(file, musicPath);
                            lvStatus.Items.Add("Moved [" + fileName + "] to [" + musicName + "] folder.");
                        }
                    }
                }

                foreach (var pic in picEx)
                {
                    if (File.Exists(picPath))
                    {

                    }
                    else
                    {
                        if (file.Contains(pic))
                        {
                            System.IO.File.Move(file, picPath);
                            lvStatus.Items.Add("Moved [" + fileName + "] to [" + picName + "] folder.");
                        }
                    }
                }

                foreach (var vid in vidEx)
                {
                    if (File.Exists(vidPath))
                    {

                    }
                    else
                    {
                        if (file.Contains(vid))
                        {
                            System.IO.File.Move(file, vidPath);
                            lvStatus.Items.Add("Moved [" + fileName + "] to [" + vidName + "] folder.");
                        }
                    }
                }

                foreach (var app in appEx)
                {
                    if (File.Exists(appPath))
                    {

                    }
                    else
                    {
                        if (file.Contains(app))
                        {
                            System.IO.File.Move(file, appPath);
                            lvStatus.Items.Add("Moved [" + fileName + "] to [" + appName + "] folder.");
                        }
                    }
                }
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtPath.Text = folderBrowser.SelectedPath;
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            folderEngine();
            sorterEngine();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lvStatus.View = View.Details;
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();
            setting.ShowDialog();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
