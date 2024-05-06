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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class AddArtistForm : Form
    {
        OracleConnection conn;
        string ordb = "Data Source = orcl; User Id= scott; Password= tiger";
        public AddArtistForm()
        {
            InitializeComponent();
        }

        private void AddArtistForm_Load(object sender, EventArgs e)
        {
            //idCombobox.Items.Clear();
            conn = new OracleConnection(ordb);
            conn.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "GetIdArtists";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("ids", OracleDbType.RefCursor, ParameterDirection.Output);
            //OracleDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    //string name = dr["fname"].ToString();
            //    //name += " ";
            //    //name += dr["lname"].ToString();
            //    idCombobox.Items.Add(dr["artist_id"]);

            //}
            //dr.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MAX(artist_id) FROM artist";
            object maxId = cmd.ExecuteScalar();

            int newID;
            if (maxId != DBNull.Value)
            {
                newID = Convert.ToInt32(maxId) + 1;
            }
            else
            {
                newID = 1;
            }
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into artist values (:id,:mid,:fname,:lname,:email)";
            cmd.Parameters.Add("id", newID);
            cmd.Parameters.Add("mid", null);

            cmd.Parameters.Add("fname", fnameTextBox.Text);
            cmd.Parameters.Add("lname", lnameTextBox.Text);
            cmd.Parameters.Add("email", emailTextBox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r!=-1)
            {
                MessageBox.Show($"Actor is Added\nSave Your ID {newID}");
            }
            else
            {
                MessageBox.Show("There is a Problem");

            }
        }

        private void AddArtistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void idCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText =
            //    @"""
            //        select FNAME,LNAME,EMAIL
            //        from artist 
            //        WHERE artist_id =:id;
            //    """;
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("id",Convert.ToInt32( idCombobox.Text.ToString()));

            //try
            //{
            //    OracleDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        fnameTextBox.Text = dr["fname"].ToString() + " " + dr["lname"].ToString();
            //        emailTextBox.Text = dr["email"].ToString();
            //    }
            //    dr.Close();
            //}
            //catch(Exception ex) 
            //{
            //    MessageBox.Show($"The problem is {ex}");
            //}
        }

        

        private void showButton_Click(object sender, EventArgs e)
        {

         
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetArtworks";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id_artist", IdTextBox.Text);

            cmd.Parameters.Add("atrworks", OracleDbType.RefCursor, ParameterDirection.Output);
            try { 
                OracleDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Artworks Title", typeof(string));
                if (!dr.HasRows)
                {
                    MessageBox.Show("Incorrect Data");
                    return;
                }
                while (dr.Read())
                {
                  
                    dataTable.Rows.Add(dr["artwork_title" ]);
                }
                artworksGridView.DataSource = dataTable; 
                dr.Close();

            }
            catch {
                MessageBox.Show("Incorrect Data");
            }
            
            

            //while (dr.Read())
            //{
            //    //string name = dr["fname"].ToString();
            //    //name += " ";
            //    //name += dr["lname"].ToString();
            //    //idCombobox.Items.Add(dr["artist_id"]);
            //}
        }
    }
}
