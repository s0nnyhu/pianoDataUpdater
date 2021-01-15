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
            this.cbLoadFromFile = new System.Windows.Forms.CheckBox();
            this.lblStatusCheck = new System.Windows.Forms.Label();
            this.pbLoadingCheck = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewListMusic = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingCheck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoadFromFile);
            this.groupBox1.Controls.Add(this.lblStatusCheck);
            this.groupBox1.Controls.Add(this.pbLoadingCheck);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.tbToken);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authorization token";
            // 
            // cbLoadFromFile
            // 
            this.cbLoadFromFile.AutoSize = true;
            this.cbLoadFromFile.Checked = true;
            this.cbLoadFromFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoadFromFile.Location = new System.Drawing.Point(15, 25);
            this.cbLoadFromFile.Name = "cbLoadFromFile";
            this.cbLoadFromFile.Size = new System.Drawing.Size(106, 17);
            this.cbLoadFromFile.TabIndex = 5;
            this.cbLoadFromFile.Text = "Load from .token";
            this.cbLoadFromFile.UseVisualStyleBackColor = true;
            this.cbLoadFromFile.CheckedChanged += new System.EventHandler(this.cbLoadFromFile_CheckedChanged);
            // 
            // lblStatusCheck
            // 
            this.lblStatusCheck.AutoSize = true;
            this.lblStatusCheck.Location = new System.Drawing.Point(12, 135);
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
            this.btnCheck.Text = "Initialize";
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
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gridViewListMusic
            // 
            this.gridViewListMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewListMusic.Enabled = false;
            this.gridViewListMusic.Location = new System.Drawing.Point(24, 278);
            this.gridViewListMusic.Name = "gridViewListMusic";
            this.gridViewListMusic.Size = new System.Drawing.Size(394, 214);
            this.gridViewListMusic.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(24, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(117, 231);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(24, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 2);
            this.label2.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridViewListMusic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "s0nnyhuPianoDataUpdater";
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
        private System.Windows.Forms.Label lblStatusCheck;
        private System.Windows.Forms.DataGridView gridViewListMusic;
        private System.Windows.Forms.CheckBox cbLoadFromFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
    }
}

