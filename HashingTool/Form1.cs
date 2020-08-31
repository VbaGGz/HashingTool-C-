using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashingTool
{
    public partial class Main : Form
    {   
        public Main()
        {
            InitializeComponent();
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            string filePath;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    status_Label.Text = "File Opened";
                    label_Path.Text = filePath;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            status_Label.Text = "Pleae open file..";
            label_Path.Text = "";
        }

        private void Button_Copy_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Clipboard.SetText(textBox1.Text);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
