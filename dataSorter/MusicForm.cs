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
    public partial class MusicForm : Form
    {
        private string path = "docSort.xml";
        public MusicForm()
        {
            InitializeComponent();
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            lvMusic.View = View.Details;
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                lvMusic.Items.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(path);
                DataTable dt = new DataTable();
                dt = dataSet.Tables["musicSort"];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    lvMusic.Items.Add(dr["Extension"].ToString());
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
