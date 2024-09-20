namespace ITM_NV_SDK
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN() {
            InitializeComponent();
        }

        private void BTN_selectRoom_Click(object sender, EventArgs e) {
            FRM_CONFIGURE_ROOM configWindow = new();
            Hide();
            configWindow.FormClosed += (s, args) => Close();
            configWindow.ShowDialog();
        }
    }
}
