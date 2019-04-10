using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;

namespace AlltryItPages
{
    public partial class Top10ContentWords : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            topLabel.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string userURL = TextBox1.Text;
            string url = @"http://webstrar16.fulton.asu.edu/Page4/Service1.svc/GetData?url=" + userURL;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            Label1.Text = reader.ReadToEnd().ToString().Trim('"');
            topLabel.Visible = true;
            Label1.Visible = true;

        }
    }
}