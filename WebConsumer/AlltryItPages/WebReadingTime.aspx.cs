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
    public partial class WebReadingTime : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userURL = urlBox.Text;
            int userSpeed = Convert.ToInt32(wpmBox.Text);

            string url = @"http://webstrar16.fulton.asu.edu/Page5/Service1.svc/GetData?url=" + userURL + "&speed=" + userSpeed;
            //string url = @"http://localhost:55426/Service1.svc/GetData?url=" + userURL + "&speed=" + userSpeed;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            TimeLabel.Text = reader.ReadToEnd().ToString().Trim('"');
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}