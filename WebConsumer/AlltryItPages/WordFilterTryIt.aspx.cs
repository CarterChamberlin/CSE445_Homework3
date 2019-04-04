using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace AlltryItPages
{
    public partial class WordFilterTryIt : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output.Visible = false;
        }

        protected void sendString_Click(object sender, EventArgs e)
        {
            string userString = userInput.Text;

            string url = @"http://webstrar16.fulton.asu.edu/Page2/Service1.svc/FilteredString?originalString=" + userString;
            string formattedString = readerResponse(url);



            output.Text = formattedString.Trim('"');
            output.Visible = true;
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