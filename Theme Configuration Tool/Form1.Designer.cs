namespace Theme_Configuration_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbColorThemes = new System.Windows.Forms.ComboBox();
            this.lblColorThemes = new System.Windows.Forms.Label();
            this.lblFocus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbColorThemes
            // 
            this.cbColorThemes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColorThemes.FormattingEnabled = true;
            this.cbColorThemes.Location = new System.Drawing.Point(156, 55);
            this.cbColorThemes.Name = "cbColorThemes";
            this.cbColorThemes.Size = new System.Drawing.Size(330, 27);
            this.cbColorThemes.TabIndex = 0;
            this.cbColorThemes.SelectedValueChanged += new System.EventHandler(this.cbColorThemes_SelectedValueChanged);
            // 
            // lblColorThemes
            // 
            this.lblColorThemes.AutoSize = true;
            this.lblColorThemes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorThemes.Location = new System.Drawing.Point(48, 58);
            this.lblColorThemes.Name = "lblColorThemes";
            this.lblColorThemes.Size = new System.Drawing.Size(102, 19);
            this.lblColorThemes.TabIndex = 0;
            this.lblColorThemes.Text = "Color Themes:";
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(282, 62);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(62, 13);
            this.lblFocus.TabIndex = 1;
            this.lblFocus.Text = "Focus Here";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuConfig,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(574, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.SystemColors.Control;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            this.menuFile.DropDownClosed += new System.EventHandler(this.menuFile_DropDownClosed);
            this.menuFile.DropDownOpened += new System.EventHandler(this.menuFile_DropDownOpened);
            // 
            // menuExit
            // 
            this.menuExit.BackColor = System.Drawing.SystemColors.Control;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorThemes});
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(93, 20);
            this.menuConfig.Text = "Configuration";
            this.menuConfig.DropDownClosed += new System.EventHandler(this.menuConfig_DropDownClosed);
            this.menuConfig.DropDownOpened += new System.EventHandler(this.menuConfig_DropDownOpened);
            // 
            // menuColorThemes
            // 
            this.menuColorThemes.Name = "menuColorThemes";
            this.menuColorThemes.Size = new System.Drawing.Size(148, 22);
            this.menuColorThemes.Text = "Color Themes";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "Help";
            this.menuHelp.DropDownClosed += new System.EventHandler(this.menuHelp_DropDownClosed);
            this.menuHelp.DropDownOpened += new System.EventHandler(this.menuHelp_DropDownOpened);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(107, 22);
            this.menuAbout.Text = "About";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 131);
            this.Controls.Add(this.cbColorThemes);
            this.Controls.Add(this.lblColorThemes);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblFocus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Theme Configuration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColorThemes;
        private System.Windows.Forms.Label lblColorThemes;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuColorThemes;
    }
}

