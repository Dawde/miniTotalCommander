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

namespace cwiczenie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //miniTCPanel1.CurrentPath = @"c:\";
            miniTotalCommander1.LoadDrivers += MiniTCPanel1_LoadDrivers;
            miniTotalCommander1.Directory += MiniTC_Directory;
            miniTotalCommander2.LoadDrivers += MiniTCPanel1_LoadDrivers;
            miniTotalCommander2.Directory += MiniTC_Directory;
            //DriveInfo
            //Path
            //Directory
            //File
        }

        private void MiniTCPanel1_LoadDrivers(miniTotalCommander obj)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> dyski = new List<string> { };
            foreach (DriveInfo d in drives)
            {
                if(d.IsReady) dyski.Add(d.Name);
            }

            miniTotalCommander1.Drivers = dyski.ToArray();
            miniTotalCommander2.Drivers = dyski.ToArray();

        }



        private void MiniTC_Directory(miniTotalCommander obj)
        {

            if (Directory.Exists(obj.currentPath))
            {

                string[] directory = Directory.GetDirectories(obj.currentPath);
                string[] file = Directory.GetFiles(obj.currentPath);
                try
                {
                    for (int i = 0; i < directory.Length; i++)
                    {
                        directory[i] = "<DIR>" + directory[i].Substring(obj.currentPath.Length);
                    }
                    for (int i = 0; i < file.Length; i++)
                    {
                        file[i] = file[i].Substring(obj.currentPath.Length);
                    }


                    miniTotalCommander1.Directories = directory.Concat(file).ToArray();
                    miniTotalCommander2.Directories = directory.Concat(file).ToArray();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miniTotalCommander2_Load(object sender, EventArgs e)
        {

        }


        private void buttonRight_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander1.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander2.currentPath.EndsWith("\\"))
                dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item.Remove(0, 1);
            else dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item;
            File.Move(sour, dest);
          //  miniTotalCommander1.loading(sender,e);
           // miniTotalCommander2.loading(sender, e);

            //MessageBox.Show(dest);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander2.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander1.currentPath.EndsWith("\\"))
                dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item.Remove(0, 1);
            else dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item;
            File.Move(sour, dest);
          //  miniTotalCommander2.loading(sender, e);
          //  miniTotalCommander1.loading(sender, e);
        }

        private void buttonKopiujP_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander2.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander1.currentPath.EndsWith("\\"))
                dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item.Remove(0, 1);
            else dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item;
            File.Copy(sour, dest);
          //  miniTotalCommander2.loading(sender, e);
          //  miniTotalCommander1.loading(sender, e);
        }

        private void buttonKopiujL_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander1.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander2.currentPath.EndsWith("\\"))
                dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item.Remove(0, 1);
            else dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item;
            File.Copy(sour, dest);
         //   miniTotalCommander1.loading(sender, e);
          //  miniTotalCommander2.loading(sender, e);
        }

        private void buttonUsunL_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander1.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander2.currentPath.EndsWith("\\"))
                dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item.Remove(0, 1);
            else dest = miniTotalCommander2.currentPath + miniTotalCommander1.Item;
            File.Delete(sour);
          //  miniTotalCommander1.loading(sender, e);
           // miniTotalCommander2.loading(sender, e);
        }

        private void buttonUsunP_Click(object sender, EventArgs e)
        {
            string sour = miniTotalCommander2.source;
            string dest;
            if (sour.StartsWith("<DIR>"))
                sour.Remove(0, 5);
            if (miniTotalCommander1.currentPath.EndsWith("\\"))
                dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item.Remove(0, 1);
            else dest = miniTotalCommander1.currentPath + miniTotalCommander2.Item;
            File.Delete(sour);
           // miniTotalCommander2.loading(sender, e);
           // miniTotalCommander1.loading(sender, e);
        }
    }
}
