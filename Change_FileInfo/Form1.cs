using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Change_FileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBrwose_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFd = new OpenFileDialog();
            if (OFd.ShowDialog() == DialogResult.OK)
            {
                TXTFileDirectory.Text = OFd.FileName;
                DTPCreateTime.Value = File.GetCreationTime(OFd.FileName);
                DTPModifyTime.Value = File.GetLastWriteTime(OFd.FileName);
                DTPLastAccess.Value = File.GetLastAccessTime(OFd.FileName);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            File.SetCreationTime(TXTFileDirectory.Text, DTPCreateTime.Value);
            File.SetLastWriteTime(TXTFileDirectory.Text, DTPModifyTime.Value);
            File.SetLastAccessTime(TXTFileDirectory.Text, DTPLastAccess.Value);
        }
    }
}
