using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static QRCoder.PayloadGenerator;
using static QRCoder.QRCodeGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace QRCodeService.Service
{
    public class QrCodeGeneratorService
    {
        public byte[] GenerateQrCode(string url)
        {
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(url, QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
        public byte[] GenerateQrCodeEmail(string Email)
        {
            var payload = new QRCoder.PayloadGenerator.Mail(Email);
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(payload.ToString(), QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }

        public byte[] GenerateQrCodeText(string Text)
        {
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(Text, QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
        public byte[] GenerateQrCodePhoneNumber(string PhoneNumber)
        {
            var payload = new QRCoder.PayloadGenerator.PhoneNumber(PhoneNumber);
            using var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(payload.ToString(), QRCoder.QRCodeGenerator.ECCLevel.Q);
            using var qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }

    }
}
