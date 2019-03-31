/*  Author: Carter Chamberlin
 *  Assignment: Project 3, Phase II
 *  Group: Group #16 (Carter & Chloe)
 *  Date: 31st March 2019
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace WordFilterTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            output.Visible = false;
        }

        protected void sendString_Click(object sender, EventArgs e)
        {
            string userString = userInput.Text;
            
            string url = @"http://localhost:58532/Service1.svc/FilteredString?originalString=" + userString;
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