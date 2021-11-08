using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using Upload_File.Utils;

namespace Upload_File.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : ControllerBase
    {
        [HttpPost, DisableRequestSizeLimit]
        public IActionResult Upload () 
        {

            Upload up = new Upload();
            var imagem = up.UploadFile(Request.Form.Files[0]);

            return Ok(imagem);
            
        }
    }
}
