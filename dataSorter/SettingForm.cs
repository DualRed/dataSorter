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
                MessageBox.Show(err.Message);
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

                addEngine.Element("SortEngine").Add(newExtension);
                addEngine.Save(path);
                loadData();
                txtAddDoc.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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

                addEngine.Element("SortEngine").Add(newExtension);
                addEngine.Save(path);
                loadData();
                txtAddMusic.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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

                addEngine.Element("SortEngine").Add(newExtension);
                addEngine.Save(path);
                loadData();
                txtAddPic.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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

                addEngine.Element("SortEngine").Add(newExtension);
                addEngine.Save(path);
                loadData();
                txtAddApp.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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

                addEngine.Element("SortEngine").Add(newExtension);
                addEngine.Save(path);
                loadData();
                txtAddVid.Clear();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btDelDoc_Click(object sender, EventArgs e)
        {

        }

        private void btDelMusic_Click(object sender, EventArgs e)
        {

        }

        private void btDelPic_Click(object sender, EventArgs e)
        {

        }

        private void btDelApp_Click(object sender, EventArgs e)
        {

        }

        private void btDelVid_Click(object sender, EventArgs e)
        {

        }
    }
}
