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

        private void webInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://club.directum.ru/webhelp/directumrx/web/index.html?provodnik_sistemy.htm");
        }
    }
}
