using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharacterCreatorHelper
{
    public partial class PictureForm : Form
    {
        private readonly int _baseStyle;
        private Point _lastLocation;
        private bool _mouseDown;

        public PictureForm()
        {
            InitializeComponent();
            _baseStyle = User32Wrapper.GetWindowLong(Handle, User32Wrapper.Gwl.ExStyle);
            TopMost = true;
        }

        public void SetImage(Image image)
        {
            try
            {
                pB_image.Image?.Dispose();
                const decimal scale = (decimal)0.75;
                pB_image.Image = image;
                // max width/height according to current screen
                var maxHeight = Screen.FromControl(this).Bounds.Height * scale;
                var maxWidth = Screen.FromControl(this).Bounds.Width * scale;
                // determine defining edge
                if (image.Width < maxWidth && image.Height < maxHeight) // no problem here
                {
                    Width = image.Width;
                    Height = image.Height;
                }
                else
                {
                    // get worse ratio
                    var widthRatio = decimal.Divide(Screen.FromControl(this).Bounds.Width, image.Width);
                    var heightRatio = decimal.Divide(Screen.FromControl(this).Bounds.Height, image.Height);
                    // take smaller
                    var ratio = widthRatio < heightRatio ? widthRatio : heightRatio;
                    Width = (int)(image.Width * ratio * scale);
                    Height = (int)(image.Height * ratio * scale);
                }
                CenterToScreen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} ({ex.InnerException.Message})", @"Image display error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        public void SetTransparency(int alpha, bool isChecked)
        {
            User32Wrapper.SetLayeredWindowAttributes(Handle, 0, (byte)(255 * ((double)alpha / 100)), User32Wrapper.Lwa.Alpha);
            MakeSizeable(isChecked);
        }

        public void MakeSizeable(bool sizeable)
        {
            if (sizeable)
            User32Wrapper.SetWindowLong(Handle, User32Wrapper.Gwl.ExStyle,
                (User32Wrapper.WsEx) _baseStyle | User32Wrapper.WsEx.Layered);
            else
                User32Wrapper.SetWindowLong(Handle, User32Wrapper.Gwl.ExStyle, ((User32Wrapper.WsEx)_baseStyle | User32Wrapper.WsEx.Layered | User32Wrapper.WsEx.Transparent));
        }

        #region DragForm

        private void PictureForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void PictureForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            TopMost = true;
        }

        private void PictureForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDown) return;
            Location = new Point(x: (Location.X - _lastLocation.X) + e.X, y: (Location.Y - _lastLocation.Y) + e.Y);
            Update();
        }

        private void pB_image_MouseDown(object sender, MouseEventArgs e)
        {
            PictureForm_MouseDown(sender, e);
        }

        private void pB_image_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void pB_image_MouseMove(object sender, MouseEventArgs e)
        {
            PictureForm_MouseMove(sender, e);
        }

        #endregion
    }
}
