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

        string[] docEx = new string[128];
        string[] musicEx = new string[128];
        string[] picEx = new string[128];
        string[] vidEx = new string[128];
        string[] appEx = new string[128];

        private string path = "sortEngine.xml";

        public mainForm()
        {
            InitializeComponent();
        }

        private void folderEngine()
        {
            try
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void sorterEngine()
        {
            string endPath = txtPath.Text;

            //string[] docEx = {".doc", ".docx", ".txt", ".csv"};
            //string[] musicEx = { ".mp3", ".ogg", ".wma", ".wav", ".flac", ".aac", ".aiff", ".alac", ".amr"};
            //string[] picEx = {".jpg", ".jpeg", ".png", ".bmp", ".gif"};
            //string[] vidEx = {".mp4", ".avi", ".flv", ".wmv", ".mov"};
            //string[] appEx = {".exe", ".msi", ".iso", ".zip", ".rar"};

            var files = from file in Directory.EnumerateFiles(endPath)
                        select file;

            try
            {
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
                        if (doc != null)
                        {
                            if (File.Exists(docPath))
                            {

                            }
                            else
                            {
                                if (file.EndsWith(doc))
                                {
                                    System.IO.File.Move(file, docPath);
                                    lvStatus.Items.Add("Moved [" + fileName + "] to [" + docName + "] folder.");
                                }
                            }
                        }
                    }

                    foreach (var music in musicEx)
                    {
                        if (music != null)
                        {
                            if (File.Exists(musicPath))
                            {

                            }
                            else
                            {
                                if (file.EndsWith(music))
                                {
                                    System.IO.File.Move(file, musicPath);
                                    lvStatus.Items.Add("Moved [" + fileName + "] to [" + musicName + "] folder.");
                                }
                            }
                        }
                    }

                    foreach (var pic in picEx)
                    {
                        if (pic != null)
                        {
                            if (File.Exists(picPath))
                            {

                            }
                            else
                            {
                                if (file.EndsWith(pic))
                                {
                                    System.IO.File.Move(file, picPath);
                                    lvStatus.Items.Add("Moved [" + fileName + "] to [" + picName + "] folder.");
                                }
                            }
                        }
                    }

                    foreach (var vid in vidEx)
                    {
                        if (vid != null)
                        {
                            if (File.Exists(vidPath))
                            {

                            }
                            else
                            {
                                if (file.EndsWith(vid))
                                {
                                    System.IO.File.Move(file, vidPath);
                                    lvStatus.Items.Add("Moved [" + fileName + "] to [" + vidName + "] folder.");
                                }
                            }
                        }
                    }

                    foreach (var app in appEx)
                    {
                        if (app != null)
                        {
                            if (File.Exists(appPath))
                            {

                            }
                            else
                            {
                                if (file.EndsWith(app))
                                {
                                    System.IO.File.Move(file, appPath);
                                    lvStatus.Items.Add("Moved [" + fileName + "] to [" + appName + "] folder.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void sortLoader()
        {
            DataSet dataSetDocument = new DataSet();
            DataSet dataSetMusic = new DataSet();
            DataSet dataSetPicture = new DataSet();
            DataSet dataSetProgram = new DataSet();
            DataSet dataSetVideo = new DataSet();

            dataSetDocument.ReadXml(path);
            dataSetMusic.ReadXml(path);
            dataSetPicture.ReadXml(path);
            dataSetProgram.ReadXml(path);
            dataSetVideo.ReadXml(path);

            DataTable dtDocument = new DataTable();
            DataTable dtMusic = new DataTable();
            DataTable dtPicture = new DataTable();
            DataTable dtProgram = new DataTable();
            DataTable dtVideo = new DataTable();

            dtDocument = dataSetDocument.Tables["docSort"];
            dtMusic = dataSetDocument.Tables["musicSort"];
            dtPicture = dataSetDocument.Tables["pictureSort"];
            dtProgram = dataSetDocument.Tables["appSort"];
            dtVideo = dataSetDocument.Tables["videoSort"];

            int i = 0;

            try
            {
                foreach (DataRow dr in dtDocument.Rows)
                {
                    docEx[i] = dr["Extension"].ToString();
                    i++;
                } i = 0;
                foreach (DataRow dr in dtMusic.Rows)
                {
                    musicEx[i] = dr["Extension"].ToString();
                    i++;
                } i = 0;
                foreach (DataRow dr in dtPicture.Rows)
                {
                    picEx[i] = dr["Extension"].ToString();
                    i++;
                } i = 0;
                foreach (DataRow dr in dtProgram.Rows)
                {
                    appEx[i] = dr["Extension"].ToString();
                    i++;
                } i = 0;
                foreach (DataRow dr in dtVideo.Rows)
                {
                    vidEx[i] = dr["Extension"].ToString();
                    i++;
                } i = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtPath.Text = folderBrowser.SelectedPath;
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All files will moved to the folder base on extension. Are you sure?", "Please confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                lvStatus.Items.Clear();

                Array.Clear(docEx, 0, docEx.Length);
                Array.Clear(musicEx, 0, musicEx.Length);
                Array.Clear(picEx, 0, picEx.Length);
                Array.Clear(appEx, 0, appEx.Length);
                Array.Clear(vidEx, 0, vidEx.Length);

                sortLoader();
                folderEngine();
                sorterEngine();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lvStatus.View = View.Details;
            sortLoader();
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
