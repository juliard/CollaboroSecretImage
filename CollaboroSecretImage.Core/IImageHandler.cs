using System.Drawing;

namespace CollaboroSecretImage.Core
{
    public interface IImageHandler
    {
        Bitmap DecodeImage(Bitmap originalImage);
    }
}
