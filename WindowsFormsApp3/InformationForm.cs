using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp3
{
    public partial class InformationForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public InformationForm()
        {
            InitializeComponent();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string constr = "Data Source = orcl; User Id= scott; Password= tiger";
            string cmdstr;
            if (artistInfoButton.Checked)
            {
                cmdstr = "SELECT * FROM actors";
            }
            else
            {
                cmdstr = "SELECT * FROM members";
            }

            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            infoGridView.DataSource = ds.Tables[0];
        }

        private void artistInfoButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
