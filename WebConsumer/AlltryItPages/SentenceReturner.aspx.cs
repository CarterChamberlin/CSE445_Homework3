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
    public partial class SentenceReturner : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userURL = TextBox1.Text;
            string userWord = TextBox2.Text;

            //string url = @"http://localhost:56785/Service1.svc/GetData?url=" + userURL + "&word=" + userWord;
            string url = @"http://webstrar16.fulton.asu.edu/Page6/Service1.svc/GetData?url=" + userURL + "&word=" + userWord;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string returnedString = reader.ReadToEnd().ToString().Trim('"');
            Label1.Text = returnedString;
        }
    }
}