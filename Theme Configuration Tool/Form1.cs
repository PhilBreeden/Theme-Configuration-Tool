using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Theme_Configuration_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////////////
        // Variables
        ////////////

        public string currentTheme = "Default";
        public Color frmBackColor = new Color();
        public Color menuBackColor = new Color();
        public Color menuDropDownBackColor = new Color();
        public Color frmForeColor = new Color();
        public Color menuForeColor = new Color();
        public Color menuDropDownForeColor = new Color();


        //////////
        // Methods
        //////////

        public void changeColorTheme(string selectedTheme)
        {
            ///////////////////////////////////
            // Change the color theme to "Dark"
            ///////////////////////////////////

            if (selectedTheme == "Dark")
            {
                this.BackColor = Color.FromArgb(32, 31, 33);

                ////////////////////////////////////////////////
                // Change the color theme on the tool strip menu
                ////////////////////////////////////////////////

                foreach (ToolStripMenuItem items in this.menuStrip1.Items)
                {
                    items.BackColor = Color.FromArgb(55, 11, 104);
                    items.ForeColor = Color.White;

                    foreach (ToolStripMenuItem nestedItems in items.DropDownItems)
                    {
                        nestedItems.BackColor = Color.FromArgb(55, 11, 104);
                        nestedItems.ForeColor = Color.White;
                    }
                }

                /////////////////////////////////////////////
                // Change the color theme for everything else
                /////////////////////////////////////////////

                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.White;

                    if (ctrl.Name != "lblColorThemes")
                        ctrl.BackColor = Color.FromArgb(55, 11, 104);
                    else
                        ctrl.BackColor = Color.FromArgb(32, 31, 33);
                }
            }
            else
            {
                ////////////////////////////////////
                // Change the color theme to "Light"
                ////////////////////////////////////

                this.BackColor = Color.FromKnownColor(KnownColor.Control);

                ////////////////////////////////////////////////
                // Change the color theme on the tool strip menu
                ////////////////////////////////////////////////

                foreach (ToolStripMenuItem items in this.menuStrip1.Items)
                {
                    items.BackColor = Color.FromKnownColor(KnownColor.Control);
                    items.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

                    foreach (ToolStripMenuItem nestedItems in items.DropDownItems)
                    {
                        nestedItems.BackColor = Color.FromKnownColor(KnownColor.Control);
                        nestedItems.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                    }
                }

                /////////////////////////////////////////////
                // Change the color theme for everything else
                /////////////////////////////////////////////

                foreach (Control ctrl in this.Controls)
                {
                        ctrl.BackColor = Color.FromKnownColor(KnownColor.Control);
                        ctrl.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
                }

                cbColorThemes.BackColor = Color.FromKnownColor(KnownColor.Window);
            }
        }
        
        public void loadColorTheme(string colorTheme)
        {
            // Add code to open the Color Theme text file and pull the data
        }

        public void loadColorThemesList()
        {
            ///////////////////////////////////////////////////////
            //  Load the color themes to the cbColorThemes combobox
            ///////////////////////////////////////////////////////

            string[] dir = Directory.GetFiles(@"..\..\Color Themes", "*.txt");

            foreach (string str in dir)
            {
                cbColorThemes.Items.Add(Path.GetFileNameWithoutExtension(str));
            }
        }


        /////////
        // Events
        /////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbColorThemes_SelectedValueChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////
            // lblFocus is hidden behind the cbColorThemes combobox;
            // this is used to remove focus from the combobox
            ////////////////////////////////////////////////////////

            lblFocus.Focus();

            if (cbColorThemes.Text == "Dark Theme")
                changeColorTheme("Dark");
            else
                changeColorTheme("Light");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadColorThemesList();
            loadColorTheme(currentTheme);

            ////////////////////////////////////////////////////////
            // lblFocus is hidden behind the cbColorThemes combobox;
            // this is used to remove focus from the combobox
            ////////////////////////////////////////////////////////

            lblFocus.Select();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ///////////////////////////////////////////////////////////////////////////
        // The following events partain to menu dropdowns being opened and closed.
        // When the File menu dropdown is opened and the cbColorTheme is "Dark",
        // change the forecolor (text color) to Black. When the dropdown is closed,
        // change the forecolor to White.
        ///////////////////////////////////////////////////////////////////////////

        private void menuFile_DropDownOpened(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuFile.ForeColor = Color.Black;
        }

        private void menuFile_DropDownClosed(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuFile.ForeColor = Color.White;
        }

        private void menuConfig_DropDownOpened(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuConfig.ForeColor = Color.Black;
        }

        private void menuConfig_DropDownClosed(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuConfig.ForeColor = Color.White;
        }

        private void menuHelp_DropDownOpened(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuHelp.ForeColor = Color.Black;
        }

        private void menuHelp_DropDownClosed(object sender, EventArgs e)
        {
            if (cbColorThemes.Text == "Dark Theme")
                menuHelp.ForeColor = Color.White;
        }
    }
}
