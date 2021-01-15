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

            apiHelper = new ApiHelper(tbToken.Text.ToString());

            String msg = apiHelper.getInfoRepository();

            pbLoadingCheck.Visible = false;

            lblStatusCheck.Text = msg;

            if (msg.Contains("You are connected"))
            {
                tbToken.BackColor = Color.Gray;
                unlock();
            }
        }

        private void unlock()
        {
            btnGetData.Enabled = true;
            gridViewListMusic.Enabled = true;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            listMusic = apiHelper.getFile();
            gridViewListMusic.DataSource = listMusic;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Music a in listMusic)
            {
                Console.WriteLine(a.Title);
            }
        }
    }
}
