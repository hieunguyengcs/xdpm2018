using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPM2018_DiskManagement.UserControls
{
    public partial class ucDiskManagement : UserControl
    {
        private static ucDiskManagement instance;
        public static ucDiskManagement Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucDiskManagement();
                }
                return instance;
            }
        }

        private ucDiskManagement()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Panel pnlMain = (Panel)this.Parent;
            pnlMain.Controls["ucMain"].BringToFront();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
