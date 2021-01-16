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
        public static BindingSource source = new BindingSource();
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
                    tbToken.Text = files[0];
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

        /// <summary>
        /// Return current sha of data.json
        /// </summary>
        private void setSha()
        {
            sha = ApiHelper.getSha();
        }

        /// <summary>
        /// Make grid and buttons available
        /// </summary>
        private void unlock()
        {
            btnAdd.Enabled = true;
            btnRefresh.Enabled = true;
            btnUpdate.Enabled = true;
            btnGenerateJson.Enabled = true;
            gridViewListMusic.Enabled = true;
        }

        /// <summary>
        /// Load data.json from develop branch
        /// </summary>
        private void loadData()
        {
            DatabaseMusic.listMusic = ApiHelper.getFile();
            source.DataSource = DatabaseMusic.listMusic;
            gridViewListMusic.DataSource = source;
            gridViewListMusic.Columns["Title"].Frozen = true;
        }

        /// <summary>
        /// Return base64 of string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public String toBase64(String text)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void cbLoadFromFile_CheckedChanged(object sender, EventArgs e)
        {
            tbToken.Enabled = !tbToken.Enabled;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            new add().Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update music data in https://s0nnyhu.github.io/piano", "s0nnyhu : Piano data updater");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var jsonListMusic = JsonConvert.SerializeObject(DatabaseMusic.listMusic, Formatting.Indented);
            listMusicBase64 = toBase64(jsonListMusic);
            new commit().Show();
        }

        private void btnGenerateJson_Click(object sender, EventArgs e)
        {
            var jsonListMusic = JsonConvert.SerializeObject(DatabaseMusic.listMusic, Formatting.Indented);
            listMusicBase64 = toBase64(jsonListMusic);
            try
            {
                File.WriteAllText(@"data.json", jsonListMusic);
                MessageBox.Show("data.json generated", "Generate Json", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString(), "Error while generating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
