using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharacterCreatorHelper
{
    public partial class Main : Form
    {
        private readonly PictureForm _picForm;

        public Main()
        {
            InitializeComponent();

            _picForm = new PictureForm();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }


        private void cbToggle_CheckedChanged(object sender, EventArgs e)
        {
            _picForm.MakeSizeable(cbToggle.Checked);
        }

        private void b_LoadPicture_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog { Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG" };
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (ofd.ShowDialog())
                {
                    case DialogResult.OK:
                        var image = Image.FromFile(ofd.FileName);
                        _picForm.SetImage(image);
                        _picForm.Show();
                        tB_Alpha.Value = tB_Alpha.Maximum;
                        tB_Alpha.Enabled = cbToggle.Enabled = cbToggle.Checked = true;
                        break;
                    default:
                        _picForm.Hide();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} ({ex.InnerException.Message})", @"Image loading error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void tB_Alpha_Scroll(object sender, EventArgs e)
        {
            var trackBar = sender as TrackBar;
            if (trackBar != null) _picForm.SetTransparency(trackBar.Value, cbToggle.Checked);
        }
    }
}
