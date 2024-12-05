# Web API for Dynamic Content Display
This project is a simple yet powerful Web API built using ASP.NET Core to serve dynamic content from a file on the server. The API is designed to provide real-time data to any frontend application that requests it.

## Technologies Used:
* **ASP.NET Core**: To build a robust backend Web API capable of reading data from a file and exposing it via a GET endpoint.
* **File Handling**: Implemented basic error handling to check if the file exists and return appropriate messages if something goes wrong.

## Key Features:
* A GET endpoint that fetches and returns the contents of a text file from the server.
* Error handling to ensure the API gracefully handles missing files or unexpected issues.
* This API can be used as the backend for a full-stack web application, providing real-time data for any frontend interface that connects to it.

```csharp
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
```
![API Screenshot](https://github.com/AlienWashim/FileReadAPi/blob/514cca4854cf0be89870139181b35431965d012d/FIleReadApiScreenshot.png)

