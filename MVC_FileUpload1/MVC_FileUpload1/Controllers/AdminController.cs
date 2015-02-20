using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FileUpload1.Models;
using System.IO;

namespace MVC_FileUpload1.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file_Uploader)
        {
            if (file_Uploader != null)
            {

                string fileName = string.Empty;
                string destinationPath = string.Empty;


                foreach (string Upload in Request.Files)
                {

                   fileName = Path.GetFileName(file_Uploader.FileName);
                    destinationPath = @"c:\Users\CodeIT\Desktop";
                    file_Uploader.SaveAs(destinationPath);

                }
                // Path.Combine(@"C:\Users\CodeIT\Desktop\", fileName);
                //StreamReader streamReader = new StreamReader(@"C:\Users\CodeIT\Desktop\FolderToZip\ddl.txt");
                //  string path = @"c:\temp\MyTest.txt";
                //string text = streamReader.ReadToEnd();
                //streamReader.Close();
                //    FileStream fs=new FileStream();
                List<FileUploadModel> uploadFileModel = new List<FileUploadModel>()
                {
                    {new FileUploadModel { FileName= fileName,FilePath=destinationPath}}
                };

                Response.Write(uploadFileModel);
               

              //  ViewData["Uploads"] = uploadFileModel;
            }
            // return File()
            return View();
        }

        //public static bool HasFile(this HttpPostedFileBase file)
        //{
        //    return (file != null && file.ContentLength > 0) ? true : false;
        //}

        public FileStreamResult StreamFileFromDisk()
        {
            string path = @"c:\temp\MyTest.txt";
            string fileName = "test.txt";
            return File(new FileStream(path + fileName, FileMode.Open), "text/plain", fileName);
        }


    }
}
