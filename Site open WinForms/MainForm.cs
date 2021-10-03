using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_open_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void KS_Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://directum.akelon.com/Login.aspx?ReturnUrl=%2f");
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
            System.Diagnostics.Process.Start("http://kmknowledge.akelon.com/");
        }

        private void service_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://service.akelon.com/app");
        }
    }
}
