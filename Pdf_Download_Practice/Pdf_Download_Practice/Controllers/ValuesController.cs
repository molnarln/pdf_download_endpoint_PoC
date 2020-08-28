using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Pdf_Download_Practice.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        [HttpGet("getpdf")]
        public IActionResult GetFile()
        {
            var stream = new FileStream(@"C:\Users\laszl\Documents\Programozás\greenfox\pdf_download_endpoint_practice\Pdf_Download_Practice\Pdf_Download_Practice\Files\etlap.pdf", FileMode.Open);
            return new FileStreamResult(stream, "application/pdf");
        }
    }
}
