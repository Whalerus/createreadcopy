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

namespace CreateReadCopy
{
    public partial class CRCform : Form
    {
        public CRCform()
        {
            InitializeComponent();
        }

        private void CRCform_Load(object sender, EventArgs e)
        {

        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(entertexttextBox.Text);
            string pathname = enterfilenametextBox.Text;
            pathname = pathname.ToLower();
            if (!pathname.EndsWith(".txt"))
            {
                pathname += ".txt";
            }
            // MessageBox.Show(pathname);
            StreamWriter sw = new StreamWriter(pathname);
            sw.Write(entertexttextBox.Text);
            sw.Close();
            MessageBox.Show("File creation completed");
        }
    }
}
