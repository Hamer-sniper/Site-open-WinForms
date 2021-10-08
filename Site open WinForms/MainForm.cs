using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Site_open_WinForms.Properties.Settings;

namespace Site_open_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            textBoxWeb.Text = Default.WebInfoSite;
            textBoxDevelop.Text = Default.DevelopInfoSite;                                   
        }

        private void KS_Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.KS);
        }

        private void WebInfo_Click(object sender, EventArgs e)
        {           
            System.Diagnostics.Process.Start(textBoxWeb.Text);           
        }

        private void DvelopInfo_Click(object sender, EventArgs e)
        {            
            System.Diagnostics.Process.Start(textBoxDevelop.Text);          
        }

        private void knowledge_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.KnowledgeSite);
        }

        private void service_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.ServiceSite);
        }

        private void textBoxWeb_TextChanged(object sender, EventArgs e)
        {
            Default.WebInfoSite = textBoxWeb.Text;
            if (!string.IsNullOrEmpty(textBoxWeb.Text))
                Default.Save();
        }

        private void textBoxDevelop_TextChanged(object sender, EventArgs e)
        {
            Default.DevelopInfoSite = textBoxDevelop.Text;
            if (!string.IsNullOrEmpty(textBoxDevelop.Text))
                Default.Save();
        }
    }
}
