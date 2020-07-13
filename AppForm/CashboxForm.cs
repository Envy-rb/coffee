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

    public partial class CashboxForm : Form
    {
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Resources\DataBases\DraftDB\DraftDB.mdb";
        string label;
        double price;
        public CashboxForm(string label, double price)
        {
            this.label = label;
            this.price = price;
            InitializeComponent();
            CoffeePriceBox.Text = price.ToString();

        }

        public void My_Execute_Non_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string Price = price.ToString().Replace(',', '.');
            DateTime time = DateTime.Now;
            string Time = time.ToShortTimeString();
            string Input = CashInputBox.Text;
            double cashback;
            if (double.TryParse(Input, out cashback))
            {
                cashback -= price;
                string query = string.Format("INSERT INTO [Draft] ([Price], [Time], [Input],[Cashback],[CoffeeLabel]) values ('{0}', '{1}', '{2}', '{3}', '{4}')", Price, Time, Input, cashback, label);
                My_Execute_Non_Query(query);
                Close();
            }

        }

        private void CashInputBox_TextChanged(object sender, EventArgs e)
        {
            CashBackBox.Text = ((double.Parse(CashInputBox.Text) - price).ToString());
        }
    }
}
