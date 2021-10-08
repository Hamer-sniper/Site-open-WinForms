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
            
            // todo Properties.Settings.Default.ServiceSite;
            // todo Properties.Settings.Default.WebInfoSite;
                       
        }

        private void KS_Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.KS);
        }

        private void WebInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://club.directum.ru/webhelp/directumrx/web/index.html?provodnik_sistemy.htm");
        }

        private void DvelopInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://club.directum.ru/webhelp/directumrx/sds/index.html?sds_sreda_razrabotki_sds.htm");
        }

        private void knowledge_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.KnowledgeSite);
        }

        private void service_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Default.ServiceSite);
        }
    }
}
