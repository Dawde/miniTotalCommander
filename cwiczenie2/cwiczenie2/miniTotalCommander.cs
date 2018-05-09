using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cwiczenie2
{
    public partial class miniTotalCommander : UserControl
    {

        public event Action<miniTotalCommander> LoadDrivers;
        public event Action<miniTotalCommander> Directory;
        public miniTotalCommander()
        {
            InitializeComponent();
        }


        
        public string currentPath
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string lastPath
        {
            get { return textBox1.Text; }
            set { label1.Text = value; }
        }
        
        public string Item
        {
            get
            {
                string kkk = listBox1.SelectedItem.ToString();
                if (kkk.StartsWith("<DIR>"))
                    kkk = kkk.Remove(0, 5);
                if (!kkk.StartsWith("\\"))
                    kkk = "\\" + kkk;
                return kkk;
            }
        }

        public string source
        {
            get
            {
                string kkk = listBox1.SelectedItem.ToString();
                if (kkk.StartsWith("<DIR>"))
                    kkk = kkk.Remove(0, 5);
                string sorc = currentPath + Item;
                if (currentPath.EndsWith("\\"))
                sorc = currentPath + kkk; 
                return sorc;
            }
        }

        public string[] Drivers
        {
            set
            {
                if (value != null)
                    comboBox1.Items.AddRange(value);
            }
        }

        public string[] Directories
        {
            set
            {
                if (value != null)
                {
                    if (!currentPath.EndsWith(@":\"))
                    listBox1.Items.Add("...");
                    listBox1.Items.AddRange(value);
                }
                    
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            loading(sender, e);
            if (LoadDrivers != null)
                LoadDrivers(this);
            
        }

        private void miniTotalCommander_Load(object sender, EventArgs e)
        {
            textBox1.Text = Path.GetPathRoot(Environment.SystemDirectory);
            comboBox1.Text = Path.GetPathRoot(Environment.SystemDirectory);
            loading(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.TabIndex != -1)
            {
                //loading(sender, e);
                if (currentPath != "")
                lastPath = currentPath;

                currentPath = comboBox1.Text;
               // loading(sender, e);

            }
        }

       public void loading(object sender, EventArgs e)
        {
            int aaa = listBox1.SelectedIndex;
            listBox1.Items.Clear();
            if (Directory != null)
                Directory(this);
            if (aaa != -1 && aaa <= listBox1.Items.Count)
            listBox1.SelectedIndex = aaa;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Focus();
            loading(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && Directory != null)
            {
                listBox1.Items.Clear();
                Directory(this);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                lastPath = currentPath;

                currentPath += listBox1.Text.Remove(0, 5);

            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem.ToString()=="...")
                {
                    lastPath = currentPath;
                    currentPath = System.IO.Directory.GetParent(currentPath).FullName;
                }
                else
                {
                    lastPath = currentPath;
                    currentPath += listBox1.Text.Remove(0, 5);
                }
               
                loading(sender, e);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            currentPath = label1.Text;
            loading(sender, e);
        }
    }
}
