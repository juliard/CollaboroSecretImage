using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using CollaboroSecretImage.Core;

namespace CollaboroSecretImage
{
    public partial class MainForm : Form
    {
        private readonly string _imageFilter =
            "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG|" +
            "BMP Files: (*.BMP;*.DIB;*.RLE)|*.BMP;*.DIB;*.RLE|" +
            "JPEG Files: (*.JPG;*.JPEG;*.JPE;*.JFIF)|*.JPG;*.JPEG;*.JPE;*.JFIF|" +
            "GIF Files: (*.GIF)|*.GIF|" +
            "TIFF Files: (*.TIF;*.TIFF)|*.TIF;*.TIFF|" +
            "PNG Files: (*.PNG)|*.PNG|" +
            "All Files|*.*";

        private readonly IImageHandler _imageHandler;

        public MainForm()
        {
            InitializeComponent();
            _imageHandler = new ImageHandler();
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = _imageFilter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OriginalPictureBox.Image = new Bitmap(dialog.FileName);
            }
        }

        private void DecodeImageButton_Click(object sender, EventArgs e)
        {
            DecodedPictureBox.Image = _imageHandler.DecodeImage(
                (Bitmap)OriginalPictureBox.Image);
        }
    }
}
