using System;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace Upload_File.Utils
{
    public class Upload
    {
        public string UploadFile(IFormFile file){

            try 
            {
                var folderName = Path.Combine ("Resources", "Images");
                var pathToSave = Path.Combine (Directory.GetCurrentDirectory (), folderName);

                if (file.Length > 0) {
                    var fileName = ContentDispositionHeaderValue.Parse (file.ContentDisposition).FileName.Trim ('"');
                    var fullPath = Path.Combine (pathToSave, fileName);

                    using (var stream = new FileStream (fullPath, FileMode.Create)) {
                        file.CopyTo (stream);
                    }

                    return fileName;

                } else {
                    return "";
                }
                
            } catch (Exception ex) {
                return ex.ToString();
            }


        }
    }
}