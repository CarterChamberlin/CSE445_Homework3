/*  Author:         Carter Chamberlin
 *  Date:           10th April 2019
 *  Class:          CSE 445 - Balasooriya
 *  Assignment:     Project 3
 *  Group:          #16 (Carter Chamberlin & Chloe Jenko)
 *  
 *  Description:   Elective web service for Project 3 Phase III utilizing RESTful design.
 *                 Program is designed to pull referenced links from an HTML page.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace LinkRetrieverTryIt
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hides the empty output section until program is done executing
            programOutput.Visible = false;
        }

        //this code executes after the "Submit_Click" event is triggered
        protected void Submit_Click(object sender, EventArgs e)
        {
            //formats the user's URL into a proper REST statement for use with the web service
            string responseURL = @"http://localhost:2697/Service1.svc/returnedLinks?webURL=" + urlInput.Text; //LocalHost for testing and blackboard submission
            //string responseURL = @"http://webstrar16.fulton.asu.edu/Page3/Service1.svc/returnedLinks?webURL=" + urlInput.Text; //reserved for WEBSTRAR deployment
            
            //sends rest url to response method below, and sets the method's response to variable "outputResponse"
            string outputResponse = readerResponse(responseURL);

            //removes any added double-quote from the response then sets the text of the asp:Label "linkedURLs" to the response
            outputResponse = outputResponse.Trim('"');
            linkedURLs.Text = outputResponse;

            //makes program output visible to user once it has been populated with data
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