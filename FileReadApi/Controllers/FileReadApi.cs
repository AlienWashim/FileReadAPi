using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FileReadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileReadApi : ControllerBase
    {
        // Path to the .txt file
        private readonly string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "data.txt");

        // GET: api/file
        [HttpGet]
        public IActionResult GetFileData()
        {
            // Check if the file exists
            if (!System.IO.File.Exists(_filePath))
            {
                return NotFound("Intro file is missing from server.");
            }

            // Read the contents of the file
            string fileContent = System.IO.File.ReadAllText(_filePath);

            // Return the file content as a response
            return Ok(fileContent);
        }
    }
}
