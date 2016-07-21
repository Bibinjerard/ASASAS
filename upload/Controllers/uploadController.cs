using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace upload.Controllers
{
    public class uploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public void Upload()
        {
            foreach (string file in Request.Files)
            {
                var postedFile = Request.Files[file];
                postedFile.SaveAs(Server.MapPath("~/UploadedFiles/") + Path.GetFileName(postedFile.FileName));
            }
        }

        public ActionResult List()
        {
            var uploadedFiles = new List<UploadedFile>();

            var files = Directory.GetFiles(Server.MapPath("~/UploadedFiles"));

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                var uploadedFile = new UploadedFile() { Name = Path.GetFileName(file) };
                uploadedFile.Size = fileInfo.Length;

                uploadedFile.Path = ("~/UploadedFiles/") + Path.GetFileName(file);
                uploadedFiles.Add(uploadedFile);
            }

            return View(uploadedFiles);
        }
        


    }

}

    
