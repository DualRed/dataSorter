using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataSorter
{
    public partial class SettingForm : Form
    {
        private string path = "sortEngine.xml";
        public SettingForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            try
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
                foreach (DataRow dr in dtDocument.Rows)
                {
                    lvDocument.Items.Add(dr["Extension"].ToString());
                }

                foreach (DataRow dr in dtMusic.Rows)
                {
                    lvMusic.Items.Add(dr["Extension"].ToString());
                }

                foreach (DataRow dr in dtPicture.Rows)
                {
                    lvPicture.Items.Add(dr["Extension"].ToString());
                }

                foreach (DataRow dr in dtProgram.Rows)
                {
                    lvProgram.Items.Add(dr["Extension"].ToString());
                }

                foreach (DataRow dr in dtVideo.Rows)
                {
                    lvVideo.Items.Add(dr["Extension"].ToString());
                }
            }
            catch (Exception)
            {

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
    }
}
