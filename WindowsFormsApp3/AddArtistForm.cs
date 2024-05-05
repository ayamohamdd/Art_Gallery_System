using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddArtistForm : Form
    {
        OracleConnection conn;
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        public AddArtistForm()
        {
            InitializeComponent();
        }

        private void AddArtistForm_Load(object sender, EventArgs e)
        {
            //conn = new OracleConnection(ordb);
            //conn.Open();
            //OracleCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "GetUsermaneArtists";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("usernames",OracleDbType.RefCursor,ParameterDirection.Output);
            //OracleDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    usernameCombobox.Items.Add(dr["username"]);
         
            //}
            //dr.Close();
        }
    }
}
