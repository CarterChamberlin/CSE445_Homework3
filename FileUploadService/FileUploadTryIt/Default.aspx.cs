using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace FileUploadTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void saveFileButton_Click(object sender, EventArgs e)
        {

            string userFileInput = String.Empty;
            if (FileUpload1.HasFile)
            {

                userFileInput = FileUpload1.FileName;
                string newFilePathURL = @"http://localhost:58435/Service1.svc/StoreFile?filePath=" + userFileInput;
                string newFilePath = readerResponse(newFilePathURL);
                newFilePath = newFilePath.Trim('"');
                FileUpload1.SaveAs(newFilePath);

                statusLabel.Text = "File Saved Successfully!";
                fileSavedURL.Text = newFilePath;
                fileSavedURL.NavigateUrl =  newFilePath;




                //FileUpload1.SaveAs(MapPath("~/Uploads/" + FileUpload1.FileName));
            }

        }

        protected void webPageButton_Click(object sender, EventArgs e)
        {
            
            string responseURLstream = @"http://localhost:58435/Service1.svc/StoreURL?urlPath" + @webPageURL.Text;
            string newFilePath = readerResponse(responseURLstream);
            newFilePath = newFilePath.Trim('"');

            webpageStatusLabel.Text = "WebPage Saved Successfully!";
            webPageSavedURL.Text = newFilePath;


        }

        string readerResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            return reader.ReadToEnd();
        }
    }
}