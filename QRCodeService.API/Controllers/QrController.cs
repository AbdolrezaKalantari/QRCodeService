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

        [HttpGet]
        public IActionResult GetQr([FromQuery] string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return BadRequest("URL is required");

            var qrBytes = _qrCodeGeneratorService.GenerateQrCode(url);
            return File(qrBytes, "image/png", "qrcode.png");
        }
    }
}
