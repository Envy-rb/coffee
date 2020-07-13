using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolyaKurs.AppForm
{
    public partial class DraftListForm : Form
    {
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Resources\DataBases\DraftDB\DraftDB.mdb";
        public DraftListForm()
        {
            InitializeComponent();
        }

        private void DraftList_Load(object sender, EventArgs e)
        {
            string CommandText = "SELECT * FROM Draft";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Draft");
            dataGridView1.DataSource = ds.Tables["Draft"].DefaultView;
        }
    }
}
