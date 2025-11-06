using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;
namespace QRCodeService.Service
{
    public class BarcodeGeneratorService
    {
        private byte[] GenerateBarcodeInternal(string data)
        {
            var writer = new BarcodeWriter<Bitmap>
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 10
                },
                Renderer = new BitmapRenderer()
            };

            using var bitmap = writer.Write(data);
            using var ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public byte[] GenerateTextBarcode(string text)
        {
            return GenerateBarcodeInternal(text);
        }

        public byte[] GeneratePhoneBarcode(string phoneNumber)
        {
            return GenerateBarcodeInternal(phoneNumber);
        }

        public byte[] GenerateEmailBarcode(string email)
        {
            return GenerateBarcodeInternal(email);
        }
    }
}
