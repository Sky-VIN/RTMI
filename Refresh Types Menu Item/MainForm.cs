using System;
using System.Drawing;
using System.Windows.Forms;


namespace RTMI
{
    public partial class MainForm : Form
    {
        /* Moving borderless form method * https://stackoverflow.com/a/24691094/5521566 */
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            if (message.Msg == 0x84) message.Result = (IntPtr)0x2;
        }


        public MainForm()
        {
            InitializeComponent();

            /* making corners transparent */
            BackColor = Color.Moccasin;
            TransparencyKey = Color.Moccasin;

            /* making app size smaller by icon size */
            Icon = Properties.Resources.icon;

            /* inserting info from resources */
            info.Text = Properties.Resources.info;
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (RegistryHelper.IsKeyExists()) enableChk.Checked = true;
            else enableChk.Checked = false;
        }


        private void enableChk_CheckedChanged(object sender, EventArgs e)
        {
            if (enableChk.Checked)
            {
                examplePic.BackgroundImage = Properties.Resources.example_on;
                RegistryHelper.Integrate(Application.ExecutablePath);
            }
            else
            {
                examplePic.BackgroundImage = Properties.Resources.example_off;
                RegistryHelper.DisIntegrate();
            }
        }


        private void OnKeyDown(object sender, KeyEventArgs e)
        { if (e.KeyCode == Keys.Escape) closePic_Click(sender, e); }

        private void closePic_MouseHover(object sender, EventArgs e)
        { closePic.BackgroundImage = Properties.Resources.close_hover; }

        private void closePic_MouseLeave(object sender, EventArgs e)
        { closePic.BackgroundImage = Properties.Resources.close; }

        private void closePic_Click(object sender, EventArgs e)
        {
            enableChk_CheckedChanged(sender, e);
            Application.Exit();
        }
    }
}
