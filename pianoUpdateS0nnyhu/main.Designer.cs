namespace pianoUpdateS0nnyhu
{
    partial class main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatusCheck = new System.Windows.Forms.Label();
            this.pbLoadingCheck = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetData = new System.Windows.Forms.Button();
            this.gridViewListMusic = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLoadFromENv = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCheck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoadFromENv);
            this.groupBox1.Controls.Add(this.lblStatusCheck);
            this.groupBox1.Controls.Add(this.pbLoadingCheck);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.tbToken);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authorization token";
            // 
            // lblStatusCheck
            // 
            this.lblStatusCheck.AutoSize = true;
            this.lblStatusCheck.Location = new System.Drawing.Point(12, 144);
            this.lblStatusCheck.Name = "lblStatusCheck";
            this.lblStatusCheck.Size = new System.Drawing.Size(264, 13);
            this.lblStatusCheck.TabIndex = 6;
            this.lblStatusCheck.Text = "I will get updated once you clicked on checked button";
            // 
            // pbLoadingCheck
            // 
            this.pbLoadingCheck.ErrorImage = null;
            this.pbLoadingCheck.ImageLocation = "C:\\Users\\Sonny\\source\\repos\\pianoUpdateS0nnyhu\\loading.gif";
            this.pbLoadingCheck.InitialImage = null;
            this.pbLoadingCheck.Location = new System.Drawing.Point(96, 100);
            this.pbLoadingCheck.Name = "pbLoadingCheck";
            this.pbLoadingCheck.Size = new System.Drawing.Size(19, 23);
            this.pbLoadingCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLoadingCheck.TabIndex = 5;
            this.pbLoadingCheck.TabStop = false;
            this.pbLoadingCheck.Visible = false;
            this.pbLoadingCheck.WaitOnLoad = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(15, 100);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbToken
            // 
            this.tbToken.Enabled = false;
            this.tbToken.Location = new System.Drawing.Point(15, 74);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(370, 20);
            this.tbToken.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(24, 233);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "GET  data..json";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // gridViewListMusic
            // 
            this.gridViewListMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewListMusic.Enabled = false;
            this.gridViewListMusic.Location = new System.Drawing.Point(24, 289);
            this.gridViewListMusic.Name = "gridViewListMusic";
            this.gridViewListMusic.Size = new System.Drawing.Size(685, 214);
            this.gridViewListMusic.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLoadFromENv
            // 
            this.cbLoadFromENv.AutoSize = true;
            this.cbLoadFromENv.Checked = true;
            this.cbLoadFromENv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoadFromENv.Location = new System.Drawing.Point(15, 25);
            this.cbLoadFromENv.Name = "cbLoadFromENv";
            this.cbLoadFromENv.Size = new System.Drawing.Size(97, 17);
            this.cbLoadFromENv.TabIndex = 5;
            this.cbLoadFromENv.Text = "Load from .env";
            this.cbLoadFromENv.UseVisualStyleBackColor = true;
            this.cbLoadFromENv.CheckedChanged += new System.EventHandler(this.cbLoadFromENv_CheckedChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridViewListMusic);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCheck)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox pbLoadingCheck;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblStatusCheck;
        private System.Windows.Forms.DataGridView gridViewListMusic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbLoadFromENv;
    }
}

