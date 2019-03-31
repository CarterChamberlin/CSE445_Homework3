using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Web;
using System.Xml;
using HtmlAgilityPack;

namespace FileUploadService
{

    public class Service1 : IService1
    {
        
        public string StoreFile(string filePath)
        {
            string fsPath = HttpContext.Current.Server.MapPath("~/Uploads/");
            string newFilePath = fsPath + filePath;

            return newFilePath;
        }

        public string StoreURL(string urlPath)
        {

            
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(urlPath);

            HtmlNode title = doc.DocumentNode.SelectSingleNode("//head//title");
            
            string fsPath = HttpContext.Current.Server.MapPath("~/Uploads/");
            fsPath += (title.InnerText + @".html");

            FileStream sw = new FileStream(fsPath, FileMode.Create);
            doc.Save(sw);


            return fsPath;
        }
    }
}
