namespace GameWeb
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersT = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesT = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesT = new System.Windows.Forms.ToolStripMenuItem();
            this.genresT = new System.Windows.Forms.ToolStripMenuItem();
            this.addElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_CountryT = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fMain = new System.Windows.Forms.FlowLayoutPanel();
            this.tlMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gbShowMain = new System.Windows.Forms.GroupBox();
            this.showBoxMain1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cog = new System.Windows.Forms.GroupBox();
            this.genreBox = new System.Windows.Forms.ListBox();
            this.gbMoreInfo = new System.Windows.Forms.GroupBox();
            this.aScore = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.createRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.fMain.SuspendLayout();
            this.tlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbShowMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cog.SuspendLayout();
            this.gbMoreInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.addElementToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.createRaportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersT,
            this.gamesT,
            this.countriesT,
            this.genresT});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablesToolStripMenuItem.Text = "Tables";
            // 
            // usersT
            // 
            this.usersT.Name = "usersT";
            this.usersT.Size = new System.Drawing.Size(125, 22);
            this.usersT.Text = "Users";
            this.usersT.Click += new System.EventHandler(this.usersT_Click);
            // 
            // gamesT
            // 
            this.gamesT.Name = "gamesT";
            this.gamesT.Size = new System.Drawing.Size(125, 22);
            this.gamesT.Text = "Games";
            this.gamesT.Click += new System.EventHandler(this.gamesT_Click);
            // 
            // countriesT
            // 
            this.countriesT.Name = "countriesT";
            this.countriesT.Size = new System.Drawing.Size(125, 22);
            this.countriesT.Text = "Countries";
            this.countriesT.Click += new System.EventHandler(this.countriesT_Click);
            // 
            // genresT
            // 
            this.genresT.Name = "genresT";
            this.genresT.Size = new System.Drawing.Size(125, 22);
            this.genresT.Text = "Genres";
            this.genresT.Click += new System.EventHandler(this.genresT_Click);
            // 
            // addElementToolStripMenuItem
            // 
            this.addElementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_CountryT,
            this.genreToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.addGameToolStripMenuItem,
            this.addScoreToolStripMenuItem});
            this.addElementToolStripMenuItem.Name = "addElementToolStripMenuItem";
            this.addElementToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.addElementToolStripMenuItem.Text = "Add Element";
            // 
            // add_CountryT
            // 
            this.add_CountryT.Name = "add_CountryT";
            this.add_CountryT.Size = new System.Drawing.Size(142, 22);
            this.add_CountryT.Text = "Add Country";
            this.add_CountryT.Click += new System.EventHandler(this.add_CountryT_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.genreToolStripMenuItem.Text = "Add Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // fMain
            // 
            this.fMain.Controls.Add(this.tlMain);
            this.fMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMain.Location = new System.Drawing.Point(0, 24);
            this.fMain.Name = "fMain";
            this.fMain.Size = new System.Drawing.Size(800, 426);
            this.fMain.TabIndex = 1;
            // 
            // tlMain
            // 
            this.tlMain.ColumnCount = 3;
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.59754F));
            this.tlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.40246F));
            this.tlMain.Controls.Add(this.groupBox2, 1, 0);
            this.tlMain.Controls.Add(this.gbShowMain, 0, 0);
            this.tlMain.Controls.Add(this.panel1, 2, 0);
            this.tlMain.Location = new System.Drawing.Point(3, 3);
            this.tlMain.Name = "tlMain";
            this.tlMain.RowCount = 2;
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.67153F));
            this.tlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.32847F));
            this.tlMain.Size = new System.Drawing.Size(797, 423);
            this.tlMain.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(231, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 352);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(216, 333);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // gbShowMain
            // 
            this.gbShowMain.Controls.Add(this.showBoxMain1);
            this.gbShowMain.Location = new System.Drawing.Point(3, 3);
            this.gbShowMain.Name = "gbShowMain";
            this.gbShowMain.Size = new System.Drawing.Size(222, 352);
            this.gbShowMain.TabIndex = 0;
            this.gbShowMain.TabStop = false;
            this.gbShowMain.Text = "groupBox1";
            // 
            // showBoxMain1
            // 
            this.showBoxMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBoxMain1.FormattingEnabled = true;
            this.showBoxMain1.Location = new System.Drawing.Point(3, 16);
            this.showBoxMain1.Name = "showBoxMain1";
            this.showBoxMain1.Size = new System.Drawing.Size(216, 333);
            this.showBoxMain1.TabIndex = 0;
            this.showBoxMain1.SelectedIndexChanged += new System.EventHandler(this.showBoxMain1_SelectedIndexChanged);
            this.showBoxMain1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showBoxMain1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cog);
            this.panel1.Controls.Add(this.gbMoreInfo);
            this.panel1.Location = new System.Drawing.Point(462, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 352);
            this.panel1.TabIndex = 3;
            // 
            // cog
            // 
            this.cog.Controls.Add(this.genreBox);
            this.cog.Location = new System.Drawing.Point(3, 190);
            this.cog.Name = "cog";
            this.cog.Size = new System.Drawing.Size(329, 159);
            this.cog.TabIndex = 3;
            this.cog.TabStop = false;
            this.cog.Text = "Addition data";
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(6, 19);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(314, 134);
            this.genreBox.TabIndex = 0;
            this.genreBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genreBox_KeyDown);
            // 
            // gbMoreInfo
            // 
            this.gbMoreInfo.Controls.Add(this.aScore);
            this.gbMoreInfo.Controls.Add(this.infoLabel);
            this.gbMoreInfo.Location = new System.Drawing.Point(3, 3);
            this.gbMoreInfo.Name = "gbMoreInfo";
            this.gbMoreInfo.Size = new System.Drawing.Size(320, 158);
            this.gbMoreInfo.TabIndex = 2;
            this.gbMoreInfo.TabStop = false;
            this.gbMoreInfo.Text = "More Info";
            // 
            // aScore
            // 
            this.aScore.AutoSize = true;
            this.aScore.Location = new System.Drawing.Point(17, 54);
            this.aScore.Name = "aScore";
            this.aScore.Size = new System.Drawing.Size(0, 13);
            this.aScore.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(17, 31);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 0;
            // 
            // createRaportToolStripMenuItem
            // 
            this.createRaportToolStripMenuItem.Name = "createRaportToolStripMenuItem";
            this.createRaportToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.createRaportToolStripMenuItem.Text = "Create Raport";
            this.createRaportToolStripMenuItem.Click += new System.EventHandler(this.createRaportToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fMain);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameweb";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fMain.ResumeLayout(false);
            this.tlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbShowMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.cog.ResumeLayout(false);
            this.gbMoreInfo.ResumeLayout(false);
            this.gbMoreInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        internal System.Windows.Forms.FlowLayoutPanel fMain;
        internal System.Windows.Forms.TableLayoutPanel tlMain;
        internal System.Windows.Forms.GroupBox gbShowMain;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ListBox listBox2;
        internal System.Windows.Forms.ToolStripMenuItem usersT;
        internal System.Windows.Forms.ToolStripMenuItem gamesT;
        internal System.Windows.Forms.ToolStripMenuItem countriesT;
        internal System.Windows.Forms.ToolStripMenuItem genresT;
        internal System.Windows.Forms.ListBox showBoxMain1;
        private System.Windows.Forms.GroupBox gbMoreInfo;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ToolStripMenuItem addElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_CountryT;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox cog;
        private System.Windows.Forms.ListBox genreBox;
        private System.Windows.Forms.Label aScore;
        private System.Windows.Forms.ToolStripMenuItem createRaportToolStripMenuItem;
    }
}

