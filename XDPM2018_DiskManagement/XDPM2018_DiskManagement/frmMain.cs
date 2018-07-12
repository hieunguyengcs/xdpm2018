using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDPM2018_DiskManagement.UserControls;

namespace XDPM2018_DiskManagement
{
    public partial class frmMain : MaterialSkin.Controls.MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(ucMain.Instance);
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.BlueGrey900, Primary.Blue400, Accent.Blue400, TextShade.WHITE);
        }
    }
}
