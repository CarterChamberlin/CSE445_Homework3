using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace TranslationClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            programOutput.Visible = false;
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string dataInput = textInput.Text;
            
            
            string responseURL = @"http://localhost:8888/Service1.svc/translatedText?sentText=" + dataInput;
            //WEBSTRAR

            string textResponse = readerResponse(responseURL);
            textResponse = textResponse.Trim('"');
            translatedLabel.Text = textResponse;

            programOutput.Visible = true;
        }

        //readerResponse method designed for reuse if needed
        string readerResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            return reader.ReadToEnd().ToString();
        }
    }
}