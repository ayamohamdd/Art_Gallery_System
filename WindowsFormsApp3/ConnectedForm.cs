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
    public partial class ConnectedForm : Form
    {
        public ConnectedForm()
        {
            InitializeComponent();
        }

        private void ConnectedForm_Load(object sender, EventArgs e)
        {

        }

        private void artistEnquiry_Click(object sender, EventArgs e)
        {
            ArtistEnquiryForm artistEnquiry = new ArtistEnquiryForm();
            artistEnquiry.Show();
        }

        private void addArtist_Click(object sender, EventArgs e)
        {
            AddArtistForm addArtistForm = new AddArtistForm();
            addArtistForm.Show();
        }
    }
}
