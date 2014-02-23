namespace OsgiliathRPG {
    partial class Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbCharacterSmall = new System.Windows.Forms.PictureBox();
            this.lbPlayerStats = new System.Windows.Forms.Label();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterSmall)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCharacterSmall
            // 
            this.pbCharacterSmall.Image = ((System.Drawing.Image)(resources.GetObject("pbCharacterSmall.Image")));
            this.pbCharacterSmall.Location = new System.Drawing.Point(12, 27);
            this.pbCharacterSmall.Name = "pbCharacterSmall";
            this.pbCharacterSmall.Size = new System.Drawing.Size(174, 143);
            this.pbCharacterSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCharacterSmall.TabIndex = 6;
            this.pbCharacterSmall.TabStop = false;
            this.pbCharacterSmall.Click += new System.EventHandler(this.pbCharacterSmall_Click);
            // 
            // lbPlayerStats
            // 
            this.lbPlayerStats.AutoSize = true;
            this.lbPlayerStats.Location = new System.Drawing.Point(192, 33);
            this.lbPlayerStats.Name = "lbPlayerStats";
            this.lbPlayerStats.Size = new System.Drawing.Size(34, 13);
            this.lbPlayerStats.TabIndex = 7;
            this.lbPlayerStats.Text = "Stats:";
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(348, 290);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(80, 70);
            this.btnNorth.TabIndex = 8;
            this.btnNorth.Text = "Go North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(220, 380);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(80, 70);
            this.btnWest.TabIndex = 9;
            this.btnWest.Text = "Go West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(475, 378);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(80, 70);
            this.btnEast.TabIndex = 10;
            this.btnEast.Text = "Go East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 511);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.lbPlayerStats);
            this.Controls.Add(this.pbCharacterSmall);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Osgiliath";
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacterSmall)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCharacterSmall;
        private System.Windows.Forms.Label lbPlayerStats;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}