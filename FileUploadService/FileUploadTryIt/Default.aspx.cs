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
            statusLabel.Visible = false;
            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string userFileInput = String.Empty;
            if (FileUpload1.HasFile)
            {
                try
                {
                    userFileInput = FileUpload1.FileName;

                    string newFilePathURL = @"http://localhost:58435/Service1.svc/StoreFile?filePath=" + userFileInput;
                    string newFilePath = readerResponse(newFilePathURL);
                    newFilePath = newFilePath.Trim('"');
                    FileUpload1.SaveAs(newFilePath);


                    statusLabel.Text = "File Saved Successfully";
                    statusLabel.Visible = true;

                    savedURL.Text = newFilePath;
                }
                catch (Exception ex)
                {

                }
            }

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