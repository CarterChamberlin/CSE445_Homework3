using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace FileUploadService
{
   
    public class Service1 : IService1
    {
        public string StoreFile(string filePath)
        {
            

            string newFilePath = @"http://webstrar16.fulton.asu.edu/Page2/Uploads/" + filePath;

            return newFilePath;
        }
    }
}
