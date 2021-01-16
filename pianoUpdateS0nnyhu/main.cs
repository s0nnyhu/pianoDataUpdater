using Newtonsoft.Json;
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
        BindingSource source = new BindingSource();

        public static String listMusicBase64 = null;
        public static String sha = null;

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
                    ApiHelper.initApiHelper(files[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            } else
            {
                ApiHelper.initApiHelper(tbToken.Text.ToString());
            }


            String msg = ApiHelper.getInfoRepository();

            pbLoadingCheck.Visible = false;

            lblStatusCheck.Text = msg;

            if (msg.Contains("You are connected"))
            {
                loadData();
                setSha();
                unlock();
            }
        }

        private void setSha()
        {
            sha = ApiHelper.getSha();
        }

        private void unlock()
        {
            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            btnUpdate.Enabled = true;
            gridViewListMusic.Enabled = true;
        }


        private void loadData()
        {
            listMusic = ApiHelper.getFile();
            source.DataSource = listMusic;
            gridViewListMusic.DataSource = source;
            gridViewListMusic.Columns["Title"].Frozen = true;
        }


        private void cbLoadFromFile_CheckedChanged(object sender, EventArgs e)
        {
            tbToken.Enabled = !tbToken.Enabled;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            listMusic.Add(new Music("Blooming in the mud", "Walpis Kater", "00:29", null, "https://www.google.com", "Theishter", null, null));
            source.ResetBindings(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update music data in https://s0nnyhu.github.io/piano", "s0nnyhu : Piano data updater");
        }

        public String toBase64(String text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var jsonListMusic = JsonConvert.SerializeObject(listMusic, Formatting.Indented);
            listMusicBase64 = toBase64(jsonListMusic);
            new commit().Show();
        }
    }
}
