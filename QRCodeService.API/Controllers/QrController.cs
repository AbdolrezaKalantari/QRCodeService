using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QRCodeService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrController : ControllerBase
    {
        private readonly QRCodeService.Service.QrCodeGeneratorService _qrCodeGeneratorService;
        public QrController(QRCodeService.Service.QrCodeGeneratorService qrCodeGeneratorService)
        {
            _qrCodeGeneratorService = qrCodeGeneratorService;
        }

        [HttpGet("url")]
        public IActionResult GetQr([FromQuery] string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return BadRequest("URL is required");

            var qrBytes = _qrCodeGeneratorService.GenerateQrCode(url);
            return File(qrBytes, "image/png", "qrcode.png");
        }

        [HttpGet("text")]
        public IActionResult GetQrText([FromQuery] string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return BadRequest("Text is required");
            var qrBytes = _qrCodeGeneratorService.GenerateQrCodeText(text);
            return File(qrBytes, "image/png", "qrcode.png");
        }

        [HttpGet("email")]
        public IActionResult GetQrEmail([FromQuery] string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return BadRequest("Email is required");
            var qrBytes = _qrCodeGeneratorService.GenerateQrCodeEmail(email);
            return File(qrBytes, "image/png", "qrcode.png");
        }

        [HttpGet("phone")]
        public IActionResult GetQrPhone([FromQuery] string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber)) return BadRequest("Phone number is required");
            var qrBytes = _qrCodeGeneratorService.GenerateQrCodePhoneNumber(phoneNumber);
            return File(qrBytes, "image/png", "qrcode.png");
        }
    }
}
