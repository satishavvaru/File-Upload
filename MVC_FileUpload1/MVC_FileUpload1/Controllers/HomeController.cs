using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FileUpload1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(HttpPostedFileBase file)
        {
            //if (file != null)
            //{
            //    //foreach (var item in file)
            //    //{
            //    //    string filename = System.IO.Path.GetFileName(file.FileName);
            //    //}
            //}
            //List<string> li = new List<string>();


            //string filePath, fileName;
            //if (FileUpload1.PostedFile file. != null)
            //{
            //    filePath = FileUpload1.PostedFile.FileName; // file name with path.
            //    fileName = FileUpload1.FileName;// Only file name.
            //}

            return View();
        }

        public static void GetFileDetails(HttpPostedFileBase file)
        {
            //foreach(HttpPostedFileBase item in file)
            //{
            //    item.FileName =
            //}
        }

    }
}

 //public ActionResult Index()
        //{
        //    DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
        //    Compress(directorySelected);

           
        //    return View();
        //}

        //private static string directoryPath = @"C:\Users\CodeIT\Desktop";
        //public static void Compress(DirectoryInfo directorySelected)
        //{
        //    foreach (FileInfo fileToCompress in directorySelected.GetFiles())
        //    {
        //        using (FileStream originalFileStream = fileToCompress.OpenRead())
        //        {
        //            if ((File.GetAttributes(fileToCompress.FullName) &
        //               FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz")
        //            {
        //                using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
        //                {
        //                    using (GZipStream compressionStream = new GZipStream(compressedFileStream,
        //                       CompressionMode.Compress))
        //                    {
        //                        originalFileStream.CopyTo(compressionStream);

