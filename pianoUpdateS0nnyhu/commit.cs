using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoUpdateS0nnyhu
{
    public partial class commit : Form
    {
        public commit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbBranch.Text = "develop";
            tbSha.Text = main.sha;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (tbSha.Text == null || tbCommitMessage == null || main.listMusicBase64 == null || tbSha.Text == "" || tbCommitMessage.Text == "")
            {
                MessageBox.Show("Error, make sure to fill all required fields", "Error, check fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String newSha = ApiHelper.commit(tbCommitMessage.Text, main.listMusicBase64, tbBranch.Text, tbSha.Text);
                if (newSha != tbSha.Text)
                {
                    MessageBox.Show("Committed, new sha : " + newSha, "Update data.json", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main.sha = newSha;
                    this.Close();
                }
            }
        }
    }
}
