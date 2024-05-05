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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm();
            informationForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectedForm connectedForm = new ConnectedForm();
            connectedForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrysForm crysForm = new CrysForm();
            crysForm.Show();
        }
    }
}
