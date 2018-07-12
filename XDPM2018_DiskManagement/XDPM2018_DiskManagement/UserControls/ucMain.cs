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
    public partial class ucMain : UserControl
    {
        private static ucMain instance;
        public static ucMain Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ucMain();
                }
                return instance;
            }
        }

        private ucMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyDia_Click(object sender, EventArgs e)
        {
            Parent.Controls.Add(ucDiskManagement.Instance);
            ucDiskManagement.Instance.BringToFront();
        }
    }
}
