using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCodeService.Service;

namespace QRCodeService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarcodeController : ControllerBase
    {
        private BarcodeGeneratorService _barcodeGeneratorService;
        public BarcodeController(BarcodeGeneratorService barcodeGeneratorService)
        {
            _barcodeGeneratorService = barcodeGeneratorService;
        }

        [HttpGet("text")]
        public IActionResult GetTextBarcode([FromQuery] string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return BadRequest("Text is required.");

            var barcodeBytes = _barcodeGeneratorService.GenerateTextBarcode(text);
            return File(barcodeBytes, "image/png", "text-barcode.png");
        }

        [HttpGet("phone")]
        public IActionResult GetPhoneBarcode([FromQuery] string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return BadRequest("Phone number is required.");

            var barcodeBytes = _barcodeGeneratorService.GeneratePhoneBarcode(phone);
            return File(barcodeBytes, "image/png", "phone-barcode.png");
        }

        [HttpGet("email")]
        public IActionResult GetEmailBarcode([FromQuery] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return BadRequest("Email is required.");

            var barcodeBytes = _barcodeGeneratorService.GenerateEmailBarcode(email);
            return File(barcodeBytes, "image/png", "email-barcode.png");
        }

    }
}
