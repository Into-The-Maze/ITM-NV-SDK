using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITM_NV_SDK
{
    public partial class FRM_CONFIGURE_ROOM : Form
    {
        public FRM_CONFIGURE_ROOM() {
            InitializeComponent();
        }

        private void BTN_createRoom_Click(object sender, EventArgs e) {
            FRM_ROOM roomEditor = new((int)NUM_width.Value, (int)NUM_height.Value, TXT_name.Text);
            Hide();
            roomEditor.FormClosed += (s, args) => Close();
            roomEditor.ShowDialog();
        }
    }
}
