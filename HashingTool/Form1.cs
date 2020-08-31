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

        private static byte[] ConvertStringToByteArray(string data)
        {
            return (new System.Text.UnicodeEncoding()).GetBytes(data);
        }

        private static System.IO.FileStream GetFileStream(string pathName)
        {
            return (new System.IO.FileStream(pathName, System.IO.FileMode.Open,
                      System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite));
        }

        private string filePath;

        private void Button_Browse_Click(object sender, EventArgs e)
        {
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
            textBox1.Text = "";
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

        private void button_Hash_Click(object sender, EventArgs e)
        {
            string strResult = "";
            string strHashData = "";

            byte[] arrbytHashValue;
            System.IO.FileStream oFileStream = null;
            if (comboBox1.Text == "")
            {
                const string message = "Please Choose a Hash Type";
                const string caption = "Hash Type";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            if (label_Path.Text == "")
            {
                const string message = "Please browes for a file..";
                const string caption = "Open File";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher =
                               new System.Security.Cryptography.MD5CryptoServiceProvider();

                    try
                    {
                        oFileStream = GetFileStream(filePath);
                        arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);
                        oFileStream.Close();

                        strHashData = System.BitConverter.ToString(arrbytHashValue);
                        strHashData = strHashData.Replace("-", "");
                        strResult = strHashData;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
                                   System.Windows.Forms.MessageBoxButtons.OK,
                                   System.Windows.Forms.MessageBoxIcon.Error,
                                   System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }

                    textBox1.Text = strResult;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    System.Security.Cryptography.SHA1CryptoServiceProvider oSHA1Hasher =
                  new System.Security.Cryptography.SHA1CryptoServiceProvider();

                    try
                    {
                        oFileStream = GetFileStream(filePath);
                        arrbytHashValue = oSHA1Hasher.ComputeHash(oFileStream);
                        oFileStream.Close();

                        strHashData = System.BitConverter.ToString(arrbytHashValue);
                        strHashData = strHashData.Replace("-", "");
                        strResult = strHashData;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
                                 System.Windows.Forms.MessageBoxButtons.OK,
                                 System.Windows.Forms.MessageBoxIcon.Error,
                                 System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    textBox1.Text = strResult;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    System.Security.Cryptography.SHA256CryptoServiceProvider oSHA256Hasher =
                  new System.Security.Cryptography.SHA256CryptoServiceProvider();

                    try
                    {
                        oFileStream = GetFileStream(filePath);
                        arrbytHashValue = oSHA256Hasher.ComputeHash(oFileStream);
                        oFileStream.Close();

                        strHashData = System.BitConverter.ToString(arrbytHashValue);
                        strHashData = strHashData.Replace("-", "");
                        strResult = strHashData;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
                                 System.Windows.Forms.MessageBoxButtons.OK,
                                 System.Windows.Forms.MessageBoxIcon.Error,
                                 System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    textBox1.Text = strResult;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    System.Security.Cryptography.SHA384CryptoServiceProvider oSHA384Hasher =
                  new System.Security.Cryptography.SHA384CryptoServiceProvider();

                    try
                    {
                        oFileStream = GetFileStream(filePath);
                        arrbytHashValue = oSHA384Hasher.ComputeHash(oFileStream);
                        oFileStream.Close();

                        strHashData = System.BitConverter.ToString(arrbytHashValue);
                        strHashData = strHashData.Replace("-", "");
                        strResult = strHashData;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
                                 System.Windows.Forms.MessageBoxButtons.OK,
                                 System.Windows.Forms.MessageBoxIcon.Error,
                                 System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    textBox1.Text = strResult;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    System.Security.Cryptography.SHA512CryptoServiceProvider oSHA512Hasher =
                  new System.Security.Cryptography.SHA512CryptoServiceProvider();

                    try
                    {
                        oFileStream = GetFileStream(filePath);
                        arrbytHashValue = oSHA512Hasher.ComputeHash(oFileStream);
                        oFileStream.Close();

                        strHashData = System.BitConverter.ToString(arrbytHashValue);
                        strHashData = strHashData.Replace("-", "");
                        strResult = strHashData;
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!",
                                 System.Windows.Forms.MessageBoxButtons.OK,
                                 System.Windows.Forms.MessageBoxIcon.Error,
                                 System.Windows.Forms.MessageBoxDefaultButton.Button1);
                    }
                    textBox1.Text = strResult;
                }
            }
        }
    }
}
