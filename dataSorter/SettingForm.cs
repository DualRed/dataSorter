using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace dataSorter
{
    public partial class SettingForm : Form
    {
        private string path = "sortEngine.xml";

        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();
        string hour = DateTime.Now.Hour.ToString();
        string min = DateTime.Now.Minute.ToString();
        string sec = DateTime.Now.Second.ToString();

        string docID, musicID, picID, appID, vidID;

        public SettingForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            lvDocument.Items.Clear();
            lvMusic.Items.Clear();
            lvPicture.Items.Clear();
            lvProgram.Items.Clear();
            lvVideo.Items.Clear();

            DataSet dataSetDocument = new DataSet();
            DataSet dataSetMusic = new DataSet();
            DataSet dataSetPicture = new DataSet();
            DataSet dataSetProgram = new DataSet();
            DataSet dataSetVideo = new DataSet();

            try
            {
                dataSetDocument.ReadXml(path);
                dataSetMusic.ReadXml(path);
                dataSetPicture.ReadXml(path);
                dataSetProgram.ReadXml(path);
                dataSetVideo.ReadXml(path);
            }
            catch
            {
                MessageBox.Show("sortEngine.xml is missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    lvDocument.Items.Add(dr["ID"].ToString());
                    lvDocument.Items[i].SubItems.Add(dr["Extension"].ToString());
                    i++;
                } i = 0;

                foreach (DataRow dr in dtMusic.Rows)
                {
                    lvMusic.Items.Add(dr["ID"].ToString());
                    lvMusic.Items[i].SubItems.Add(dr["Extension"].ToString());
                    i++;
                } i = 0;

                foreach (DataRow dr in dtPicture.Rows)
                {
                    lvPicture.Items.Add(dr["ID"].ToString());
                    lvPicture.Items[i].SubItems.Add(dr["Extension"].ToString());
                    i++;
                } i = 0;

                foreach (DataRow dr in dtProgram.Rows)
                {
                    lvProgram.Items.Add(dr["ID"].ToString());
                    lvProgram.Items[i].SubItems.Add(dr["Extension"].ToString());
                    i++;
                } i = 0;

                foreach (DataRow dr in dtVideo.Rows)
                {
                    lvVideo.Items.Add(dr["ID"].ToString());
                    lvVideo.Items[i].SubItems.Add(dr["Extension"].ToString());
                    i++;
                } i = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            lvDocument.View = View.Details;
            lvMusic.View = View.Details;
            lvPicture.View = View.Details;
            lvProgram.View = View.Details;
            lvVideo.View = View.Details;

            loadData();
        }

        private void btAddDoc_Click(object sender, EventArgs e)
        {
            long id = long.Parse("1999" + day + month + year + hour + min + sec);

            try
            {
                XDocument addEngine = XDocument.Load(path);
                XElement newExtension = new XElement("docSort", new XElement("Extension", txtAddDoc.Text));

                var lastExtension = addEngine.Descendants("docSort").Last();
                long newID = Convert.ToInt64(lastExtension.Attribute("ID").Value);
                newExtension.SetAttributeValue("ID", id);

                if (txtAddDoc.Text != "")
                {
                    addEngine.Element("SortEngine").Add(newExtension);
                    addEngine.Save(path);
                    loadData();
                    txtAddDoc.Clear();
                }
                else
                    MessageBox.Show("Extension empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddMusic_Click(object sender, EventArgs e)
        {
            long id = long.Parse("1999" + day + month + year + hour + min + sec);

            try
            {
                XDocument addEngine = XDocument.Load(path);
                XElement newExtension = new XElement("musicSort", new XElement("Extension", txtAddMusic.Text));

                var lastExtension = addEngine.Descendants("musicSort").Last();
                long newID = Convert.ToInt64(lastExtension.Attribute("ID").Value);
                newExtension.SetAttributeValue("ID", id);

                if (txtAddMusic.Text != "")
                {
                    addEngine.Element("SortEngine").Add(newExtension);
                    addEngine.Save(path);
                    loadData();
                    txtAddMusic.Clear();
                }
                else
                    MessageBox.Show("Extension empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddPic_Click(object sender, EventArgs e)
        {
            long id = long.Parse("1999" + day + month + year + hour + min + sec);

            try
            {
                XDocument addEngine = XDocument.Load(path);
                XElement newExtension = new XElement("pictureSort", new XElement("Extension", txtAddPic.Text));

                var lastExtension = addEngine.Descendants("pictureSort").Last();
                long newID = Convert.ToInt64(lastExtension.Attribute("ID").Value);
                newExtension.SetAttributeValue("ID", id);

                if (txtAddPic.Text != "")
                {
                    addEngine.Element("SortEngine").Add(newExtension);
                    addEngine.Save(path);
                    loadData();
                    txtAddPic.Clear();
                }
                else
                    MessageBox.Show("Extension empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddApp_Click(object sender, EventArgs e)
        {
            long id = long.Parse("1999" + day + month + year + hour + min + sec);

            try
            {
                XDocument addEngine = XDocument.Load(path);
                XElement newExtension = new XElement("appSort", new XElement("Extension", txtAddApp.Text));

                var lastExtension = addEngine.Descendants("appSort").Last();
                long newID = Convert.ToInt64(lastExtension.Attribute("ID").Value);
                newExtension.SetAttributeValue("ID", id);

                if (txtAddApp.Text != "")
                {
                    addEngine.Element("SortEngine").Add(newExtension);
                    addEngine.Save(path);
                    loadData();
                    txtAddApp.Clear();
                }
                else
                    MessageBox.Show("Extension empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddVid_Click(object sender, EventArgs e)
        {
            long id = long.Parse("1999" + day + month + year + hour + min + sec);

            try
            {
                XDocument addEngine = XDocument.Load(path);
                XElement newExtension = new XElement("videoSort", new XElement("Extension", txtAddVid.Text));

                var lastExtension = addEngine.Descendants("videoSort").Last();
                long newID = Convert.ToInt64(lastExtension.Attribute("ID").Value);
                newExtension.SetAttributeValue("ID", id);

                if (txtAddVid.Text != "")
                {
                    addEngine.Element("SortEngine").Add(newExtension);
                    addEngine.Save(path);
                    loadData();
                    txtAddVid.Clear();
                }
                else
                    MessageBox.Show("Extension empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (docID != "1")
                {
                    XDocument delEngine = XDocument.Load(path);
                    XElement delExtension = delEngine.Descendants("docSort").Where(c => c.Attribute("ID").Value.Equals(docID)).FirstOrDefault();
                    delExtension.Remove();
                    delEngine.Save(path);
                    loadData();
                    txtAddDoc.Clear();
                }
                else
                    MessageBox.Show("Default value please don't delete it!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelMusic_Click(object sender, EventArgs e)
        {
            try
            {
                if (musicID != "2")
                {
                    XDocument delEngine = XDocument.Load(path);
                    XElement delExtension = delEngine.Descendants("musicSort").Where(c => c.Attribute("ID").Value.Equals(musicID)).FirstOrDefault();
                    delExtension.Remove();
                    delEngine.Save(path);
                    loadData();
                    txtAddMusic.Clear();
                }
                else
                    MessageBox.Show("Default value please don't delete it!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelPic_Click(object sender, EventArgs e)
        {
            try
            {
                if (picID != "3")
                {
                    XDocument delEngine = XDocument.Load(path);
                    XElement delExtension = delEngine.Descendants("pictureSort").Where(c => c.Attribute("ID").Value.Equals(picID)).FirstOrDefault();
                    delExtension.Remove();
                    delEngine.Save(path);
                    loadData();
                    txtAddPic.Clear();
                }
                else
                    MessageBox.Show("Default value please don't delete it!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelApp_Click(object sender, EventArgs e)
        {
            try
            {
                if (appID != "4")
                {
                    XDocument delEngine = XDocument.Load(path);
                    XElement delExtension = delEngine.Descendants("appSort").Where(c => c.Attribute("ID").Value.Equals(appID)).FirstOrDefault();
                    delExtension.Remove();
                    delEngine.Save(path);
                    loadData();
                    txtAddApp.Clear();
                }
                else
                    MessageBox.Show("Default value please don't delete it!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelVid_Click(object sender, EventArgs e)
        {
            try
            {
                if (vidID != "5")
                {
                    XDocument delEngine = XDocument.Load(path);
                    XElement delExtension = delEngine.Descendants("videoSort").Where(c => c.Attribute("ID").Value.Equals(vidID)).FirstOrDefault();
                    delExtension.Remove();
                    delEngine.Save(path);
                    loadData();
                    txtAddVid.Clear();
                }
                else
                    MessageBox.Show("Default value please don't delete it!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDocument.SelectedItems)
            {
                docID = item.SubItems[0].Text;
                txtAddDoc.Text = item.SubItems[1].Text;
            }
        }

        private void lvMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvMusic.SelectedItems)
            {
                musicID = item.SubItems[0].Text;
                txtAddMusic.Text = item.SubItems[1].Text;
            }
        }

        private void lvPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPicture.SelectedItems)
            {
                picID = item.SubItems[0].Text;
                txtAddPic.Text = item.SubItems[1].Text;
            }
        }

        private void lvProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvProgram.SelectedItems)
            {
                appID = item.SubItems[0].Text;
                txtAddApp.Text = item.SubItems[1].Text;
            }
        }

        private void lvVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvVideo.SelectedItems)
            {
                vidID = item.SubItems[0].Text;
                txtAddVid.Text = item.SubItems[1].Text;
            }
        }
    }
}
