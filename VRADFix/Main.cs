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

namespace VRADFix
{
    public partial class Main : Form
    {
        Bsp map;
        Dface_t surface;
        public Main()
        {
            InitializeComponent();
            clearText();
        }

        private void buttonBrowseBsp_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                textBoxBsp.Text = openFileDialog1.FileName;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (map != null)
            {
                map.file.Close();
            }

            try
            {
                FileInfo file = new FileInfo(textBoxBsp.Text);
                map = new Bsp(new FileInfo(textBoxBsp.Text));
                //checks if there's data either for ldr or hdr lightmaps
                if (!map.LDR && !map.HDR)
                {
                    MessageBox.Show("Vrad must be run first!");
                    buttonUnload_Click(null, new EventArgs());
                }
                else
                {
                    //enables/disable available options for ldr/hdr
                    if (map.LDR)
                        radioButtonLDR.Enabled = true;
                    else
                    {
                        radioButtonLDR.Enabled = false;
                        radioButtonLDR.Checked = false;
                        radioButtonHDR.Checked = true;
                    }
                    if (map.HDR)
                        radioButtonHDR.Enabled = true;
                    else
                    {
                        radioButtonHDR.Enabled = false;
                        radioButtonHDR.Checked = false;
                        radioButtonLDR.Checked = true;
                    }
                    //fetchs the face, displays data and locks controls while editing
                    surface = new Dface_t(ushort.Parse(textBoxFaceID.Text), map);
                    updateLightmapViewer();

                    textBoxBsp.ReadOnly = true;
                    textBoxFaceID.ReadOnly = true;
                    buttonBrowseBsp.Enabled = false;
                    buttonLoad.Enabled = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("You must choose a bsp", "Error", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a faceID\n\nLoad your map in tf2 and use the command \"mat_surfaceid 2\" to display faceIDs.\nmat_wireframe 3 is also useful to see face divisions", "Error", MessageBoxButtons.OK);
            }
        }

        private void buttonUnload_Click(object sender, EventArgs e)
        {
            //unlocks the input fields to receive a new request
            clearText();
            textBoxBsp.ReadOnly = false;
            textBoxFaceID.ReadOnly = false;
            buttonBrowseBsp.Enabled = true;
            buttonLoad.Enabled = true;
            radioButtonHDR.Enabled = true;
            radioButtonLDR.Enabled = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //updates the data displayed when the user switches from ldr to hdr

            //note: this dumps any changes that were made before switching
            if (map != null)
            {
                updateLightmapViewer();
            }
        }

        private void updateLightmapViewer()
        {
            //this methods gathers the data from the bsp and displays it in the main window
            richTextBox1.Clear();
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Both;
            richTextBox1.WordWrap = false;
            ColorRGBExp32 luxel;
            for (int i = 0; i < surface.LightmapTextureWidth; i++)
            {
                for (int j = 0; j < surface.LightmapTextureLength; j++)
                {
                    if (radioButtonLDR.Checked)
                        luxel = surface.lightmapLDR[i, j];
                    else
                        luxel = surface.lightmapHDR[i, j];

                    if (checkBoxR.Checked)
                    {
                        richTextBox1.Text += luxel.r + ":";
                    }
                    if (checkBoxG.Checked)
                    {
                        richTextBox1.Text += luxel.g + ":";
                    }
                    if (checkBoxB.Checked)
                    {
                        richTextBox1.Text += luxel.b + ":";
                    }
                    if (checkBoxE.Checked)
                    {
                        richTextBox1.Text += luxel.e;
                    }
                    richTextBox1.Text += ";\t";
                }
                richTextBox1.Text += "\n";
            }
        }

        private char[] getColorMode()
            //this is the wacky way I came up with to pull the requested color mode from the user interface
        {
            string mode = "";
            if (checkBoxR.Checked)
            {
                mode += "r";
            }
            if (checkBoxG.Checked)
            {
                mode += "g";
            }
            if (checkBoxB.Checked)
            {
                mode += "b";
            }
            if (checkBoxE.Checked)
            {
                mode += "e"; 
            }
            return mode.ToCharArray();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //this method updates the bsp
            if (map != null)
            {
                //updates the model
                surface.updateLightmap(richTextBox1.Text.Replace("\t", String.Empty).Split(';'), getColorMode(), radioButtonLDR.Checked);
                //writes the updated model
                surface.writeLightmap();
                //updates the data in the UI with the new data from the bsp (useless, same data then before. but it reformats things)
                updateLightmapViewer();
            }
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            //this method is not accessible from the UI. It randomizes all lightmaps in a given bsp. (this power is too great to be handled by mere mortals)
            if (map != null)
            {
                map.file.Close();
            }
            map = new Bsp(new FileInfo(textBoxBsp.Text));
            surface.randoLightmaps(new Random());
        }

        private void clearText()
            //resets the main textbox, and displays a friendly welcome message
        {
            richTextBox1.Clear();
            richTextBox1.Text = "This is a lightmap editor for Source maps\n\n ***warning: back up your map before working with this.*** \n\n" + 
                "new: \n -HDR support\n -resizable interface\n\n"+
                "coming soon:\n -graphical editor\n\n";
        }

        //probably should merge these methods
        private void radioButtonLDR_CheckedChanged(object sender, EventArgs e)
        {
            if (map != null)
            {
                updateLightmapViewer();
            }
        }

        private void radioButtonHDR_CheckedChanged(object sender, EventArgs e)
        {
            if (map != null)
            {
                updateLightmapViewer();
            }
        }
    }
}