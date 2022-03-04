using System.Drawing;

namespace CollaboroSecretImage.Core
{
    public class ImageHandler : IImageHandler
    {
        public ImageHandler()
        {
        }

        public Bitmap DecodeImage(Bitmap originalImage)
        {
            var decodedImage = new Bitmap(originalImage);

            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color pixelColor = originalImage.GetPixel(i, j);

                    int r1 = (byte)(pixelColor.R * 10);
                    decodedImage.SetPixel(i, j, Color.FromArgb(r1, 0, 0));
                }
            }

            return decodedImage;
        }
    }
}
