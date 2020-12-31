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
    public partial class DocForm : Form
    {
        private string path = "docSort.xml";
        public DocForm()
        {
            InitializeComponent();            
        }

        private void DocForm_Load(object sender, EventArgs e)
        {
            lvDoc.View = View.Details;
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                lvDoc.Items.Clear();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(path);
                DataTable dt = new DataTable();
                dt = dataSet.Tables["docSort"];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    lvDoc.Items.Add(dr["Extension"].ToString());
                    i++;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
