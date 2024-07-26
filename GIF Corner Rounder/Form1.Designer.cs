namespace GIF_Corner_Rounder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainMenuStrip = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            darkModeToolStripMenuItem = new ToolStripMenuItem();
            developerToolStripMenuItem = new ToolStripMenuItem();
            mustafaTOKTAŞToolStripMenuItem = new ToolStripMenuItem();
            linkedInToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
            gitHubRepositoryToolStripMenuItem = new ToolStripMenuItem();
            gPL30LicenseToolStripMenuItem = new ToolStripMenuItem();
            v100ToolStripMenuItem = new ToolStripMenuItem();
            lblSelectGifFile = new Label();
            lblCornerRadius = new Label();
            tbFilePath = new TextBox();
            tbCornerRadius = new TextBox();
            btnBrowse = new Button();
            btnCreateGif = new Button();
            pictureBox = new PictureBox();
            pictureBoxMenuStrip = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            copyAsPathToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog = new OpenFileDialog();
            btnOpenFolder = new Button();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            pictureBoxMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, developerToolStripMenuItem, aboutToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(7, 2, 0, 2);
            mainMenuStrip.Size = new Size(653, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkModeToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // darkModeToolStripMenuItem
            // 
            darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            darkModeToolStripMenuItem.Size = new Size(132, 22);
            darkModeToolStripMenuItem.Text = "Dark Mode";
            darkModeToolStripMenuItem.Click += darkModeToolStripMenuItem_Click;
            // 
            // developerToolStripMenuItem
            // 
            developerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mustafaTOKTAŞToolStripMenuItem, linkedInToolStripMenuItem, githubToolStripMenuItem });
            developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            developerToolStripMenuItem.Size = new Size(72, 20);
            developerToolStripMenuItem.Text = "Developer";
            // 
            // mustafaTOKTAŞToolStripMenuItem
            // 
            mustafaTOKTAŞToolStripMenuItem.Checked = true;
            mustafaTOKTAŞToolStripMenuItem.CheckState = CheckState.Checked;
            mustafaTOKTAŞToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            mustafaTOKTAŞToolStripMenuItem.Name = "mustafaTOKTAŞToolStripMenuItem";
            mustafaTOKTAŞToolStripMenuItem.Size = new Size(167, 22);
            mustafaTOKTAŞToolStripMenuItem.Text = "Mustafa TOKTAŞ";
            // 
            // linkedInToolStripMenuItem
            // 
            linkedInToolStripMenuItem.Name = "linkedInToolStripMenuItem";
            linkedInToolStripMenuItem.Size = new Size(167, 22);
            linkedInToolStripMenuItem.Text = "LinkedIn";
            linkedInToolStripMenuItem.Click += linkedInToolStripMenuItem_Click;
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(167, 22);
            githubToolStripMenuItem.Text = "GitHub";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkForUpdatesToolStripMenuItem, gitHubRepositoryToolStripMenuItem, gPL30LicenseToolStripMenuItem, v100ToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new Size(173, 22);
            checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            checkForUpdatesToolStripMenuItem.Click += checkForUpdatesToolStripMenuItem_Click;
            // 
            // gitHubRepositoryToolStripMenuItem
            // 
            gitHubRepositoryToolStripMenuItem.Name = "gitHubRepositoryToolStripMenuItem";
            gitHubRepositoryToolStripMenuItem.Size = new Size(173, 22);
            gitHubRepositoryToolStripMenuItem.Text = "GitHub Repository";
            gitHubRepositoryToolStripMenuItem.Click += gitHubRepositoryToolStripMenuItem_Click;
            // 
            // gPL30LicenseToolStripMenuItem
            // 
            gPL30LicenseToolStripMenuItem.Name = "gPL30LicenseToolStripMenuItem";
            gPL30LicenseToolStripMenuItem.Size = new Size(173, 22);
            gPL30LicenseToolStripMenuItem.Text = "GPL-3.0 License";
            gPL30LicenseToolStripMenuItem.Click += gPL30LicenseToolStripMenuItem_Click;
            // 
            // v100ToolStripMenuItem
            // 
            v100ToolStripMenuItem.Name = "v100ToolStripMenuItem";
            v100ToolStripMenuItem.Size = new Size(173, 22);
            v100ToolStripMenuItem.Text = "v1.0.0";
            // 
            // lblSelectGifFile
            // 
            lblSelectGifFile.AutoSize = true;
            lblSelectGifFile.Location = new Point(12, 36);
            lblSelectGifFile.Name = "lblSelectGifFile";
            lblSelectGifFile.Size = new Size(99, 18);
            lblSelectGifFile.TabIndex = 1;
            lblSelectGifFile.Text = "Select GIF File:";
            // 
            // lblCornerRadius
            // 
            lblCornerRadius.AutoSize = true;
            lblCornerRadius.Location = new Point(12, 64);
            lblCornerRadius.Name = "lblCornerRadius";
            lblCornerRadius.Size = new Size(144, 18);
            lblCornerRadius.TabIndex = 2;
            lblCornerRadius.Text = "Corner Radius (1-238):";
            // 
            // tbFilePath
            // 
            tbFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFilePath.Location = new Point(156, 33);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.ReadOnly = true;
            tbFilePath.ScrollBars = ScrollBars.Horizontal;
            tbFilePath.Size = new Size(390, 26);
            tbFilePath.TabIndex = 3;
            tbFilePath.TextChanged += tbCornerRadius_TextChanged;
            // 
            // tbCornerRadius
            // 
            tbCornerRadius.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCornerRadius.Location = new Point(156, 61);
            tbCornerRadius.MaxLength = 3;
            tbCornerRadius.Name = "tbCornerRadius";
            tbCornerRadius.Size = new Size(390, 26);
            tbCornerRadius.TabIndex = 4;
            tbCornerRadius.TextChanged += tbCornerRadius_TextChanged;
            tbCornerRadius.KeyPress += tbCornerRadius_KeyPress;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.AutoSize = true;
            btnBrowse.Location = new Point(552, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 28);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnCreateGif
            // 
            btnCreateGif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateGif.AutoSize = true;
            btnCreateGif.Enabled = false;
            btnCreateGif.Location = new Point(464, 93);
            btnCreateGif.Name = "btnCreateGif";
            btnCreateGif.Size = new Size(82, 28);
            btnCreateGif.TabIndex = 6;
            btnCreateGif.Text = "Create GIF";
            btnCreateGif.UseVisualStyleBackColor = true;
            btnCreateGif.Click += btnCreateGif_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.ContextMenuStrip = pictureBoxMenuStrip;
            pictureBox.Location = new Point(12, 127);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(629, 96);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // pictureBoxMenuStrip
            // 
            pictureBoxMenuStrip.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, copyAsPathToolStripMenuItem });
            pictureBoxMenuStrip.Name = "pictureBoxMenuStrip";
            pictureBoxMenuStrip.Size = new Size(144, 48);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(143, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // copyAsPathToolStripMenuItem
            // 
            copyAsPathToolStripMenuItem.Name = "copyAsPathToolStripMenuItem";
            copyAsPathToolStripMenuItem.Size = new Size(143, 22);
            copyAsPathToolStripMenuItem.Text = "Copy as path";
            copyAsPathToolStripMenuItem.Click += copyAsPathToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "*.gif|";
            openFileDialog.Title = "Select a GIF File";
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenFolder.AutoSize = true;
            btnOpenFolder.Enabled = false;
            btnOpenFolder.Location = new Point(552, 59);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(96, 28);
            btnOpenFolder.TabIndex = 8;
            btnOpenFolder.Text = "Open Folder";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(653, 237);
            Controls.Add(btnOpenFolder);
            Controls.Add(pictureBox);
            Controls.Add(btnCreateGif);
            Controls.Add(btnBrowse);
            Controls.Add(tbCornerRadius);
            Controls.Add(tbFilePath);
            Controls.Add(lblCornerRadius);
            Controls.Add(lblSelectGifFile);
            Controls.Add(mainMenuStrip);
            Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(370, 200);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GIF Corner Rounder";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            pictureBoxMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem developerToolStripMenuItem;
        private ToolStripMenuItem mustafaTOKTAŞToolStripMenuItem;
        private ToolStripMenuItem linkedInToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private Label lblSelectGifFile;
        private Label lblCornerRadius;
        private TextBox tbFilePath;
        private TextBox tbCornerRadius;
        private Button btnBrowse;
        private Button btnCreateGif;
        private PictureBox pictureBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog;
        private ContextMenuStrip pictureBoxMenuStrip;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyAsPathToolStripMenuItem;
        private ToolStripMenuItem gitHubRepositoryToolStripMenuItem;
        private ToolStripMenuItem gPL30LicenseToolStripMenuItem;
        private ToolStripMenuItem v100ToolStripMenuItem;
        private Button btnOpenFolder;
        private ToolStripMenuItem darkModeToolStripMenuItem;
    }
}
