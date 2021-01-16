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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != null && tbTitle.Text != "")
            {
                Music newMusic = new Music(tbTitle.Text, tbOrigin.Text, tbDuration.Text, tbCompleted.Text, tbLink.Text, tbCredit.Text, tbMid.Text, tbMp3.Text);
                Console.WriteLine("Adding ");
                DatabaseMusic.listMusic.Add(newMusic);
                main.source.ResetBindings(false);
                MessageBox.Show("New music added", "Add music", MessageBoxButtons.OK , MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Title must be filled", "Add music", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
