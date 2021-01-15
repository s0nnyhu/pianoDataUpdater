using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoUpdateS0nnyhu
{
    public partial class main : Form
    {
        ApiHelper apiHelper;
        List<Music> listMusic;

        public main()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            pbLoadingCheck.Visible = true;

            if (cbLoadFromFile.Checked)
            {
                try
                {
                    string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"token.txt");
                    string[] files = File.ReadAllLines(path);
                    apiHelper = new ApiHelper(files[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            } else
            {
                apiHelper = new ApiHelper(tbToken.Text.ToString());
            }


            String msg = apiHelper.getInfoRepository();

            pbLoadingCheck.Visible = false;

            lblStatusCheck.Text = msg;

            if (msg.Contains("You are connected"))
            {
                loadData();
                unlock();
            }
        }

        private void unlock()
        {
            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            gridViewListMusic.Enabled = true;
        }


        private void loadData()
        {
            listMusic = apiHelper.getFile();
            gridViewListMusic.DataSource = listMusic;
            gridViewListMusic.Columns["Title"].Frozen = true;
        }


        private void cbLoadFromFile_CheckedChanged(object sender, EventArgs e)
        {
            tbToken.Enabled = !tbToken.Enabled;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Titre");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update music data in https://s0nnyhu.github.io/piano", "s0nnyhu : Piano data updater");
        }
    }
}
