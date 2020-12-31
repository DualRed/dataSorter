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
        string doc = "Documents";
        string music = "Musics";
        string pic = "Pictures";
        string vid = "Videos";
        string app = "Programs";

        public mainForm()
        {
            InitializeComponent();
        }

        private void folderEngine()
        {
            string endPath = txtPath.Text;

            string docfolder = System.IO.Path.Combine(endPath, doc);
            string musicfolder = System.IO.Path.Combine(endPath, music);
            string picfolder = System.IO.Path.Combine(endPath, pic);
            string vidfolder = System.IO.Path.Combine(endPath, vid);
            string appfolder = System.IO.Path.Combine(endPath, app);

            System.IO.Directory.CreateDirectory(docfolder);
            System.IO.Directory.CreateDirectory(musicfolder);
            System.IO.Directory.CreateDirectory(picfolder);
            System.IO.Directory.CreateDirectory(vidfolder);
            System.IO.Directory.CreateDirectory(appfolder);
        }

        private void sorterEngine()
        {
            string endPath = txtPath.Text;

            string[] docEx = {".doc", ".docx", ".txt"};

            var files = from file in Directory.EnumerateFiles(endPath)
                        select file;

            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string desName = endPath + @"\Documents" + @"\" + fileName;
                foreach (var doc in docEx)
                {
                    if(File.Exists(desName))
                    {
                       
                    }
                    else
                    {
                        if (file.Contains(doc))
                        {
                            System.IO.File.Move(file, desName);
                        }
                    }
                }
            }
        }

        private void btDocument_Click(object sender, EventArgs e)
        {
            DocForm docForm = new DocForm();
            docForm.Show();
        }

        private void btPicture_Click(object sender, EventArgs e)
        {
            PictureForm picForm = new PictureForm();
            picForm.Show();
        }

        private void btMusic_Click(object sender, EventArgs e)
        {
            MusicForm musicForm = new MusicForm();
            musicForm.Show();
        }

        private void btVideo_Click(object sender, EventArgs e)
        {
            VideoForm vidForm = new VideoForm();
            vidForm.Show();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btSort_Click(object sender, EventArgs e)
        {
            folderEngine();
            sorterEngine();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
