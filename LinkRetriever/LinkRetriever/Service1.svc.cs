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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HtmlAgilityPack;
using System.IO;


namespace LinkRetriever
{
    
    public class Service1 : IService1
    {
        public string returnedLinks(string webURL)
        {
            //Create new web object and open an HTML document for node selection
            HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load(@"https://www.theverge.com/2019/4/10/18296793/foxconn-wisconsin-location-factory-innovation-centers-technology-hub-no-news");
            HtmlDocument doc = web.Load(webURL);
            HtmlNodeCollection aTags = doc.DocumentNode.SelectNodes("//body//p//a");

            //Create a new List of strings for storing referenced URLs
            List<string> hrefLinks = new List<string>();

            //Iterate through node collection
            foreach (HtmlNode tag in aTags)
            {
                hrefLinks.Add(@tag.Attributes["href"].Value);

            }

            //new string list to store the titles of the web-pages stored in the previous segment
            List<string> linkTitles = new List<string>();

            //iterate through each referenced URL to parse the page title. If title is unaccessible, use a string and URL instead
            foreach (string refURL in hrefLinks)
            {
                //loads each referenced URL
                HtmlWeb refWeb = new HtmlWeb();
                HtmlDocument refDoc = web.Load(refURL);

                //selects title node
                HtmlNode title = refDoc.DocumentNode.SelectSingleNode("//head//title");

                //check title node for data, then enter into "linkTitles" list
                if (title == null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("No title availible: Referenced URL - ");
                    sb.Append(refURL);
                    linkTitles.Add(sb.ToString());

                }
                else if (title.InnerText.Equals(""))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("No title availible: Referenced URL - ");
                    sb.Append(refURL);
                    linkTitles.Add(sb.ToString());
                }
                else
                {
                    string urlTitle = title.InnerText;
                    linkTitles.Add(urlTitle);
                }
            }
            
            //another new string list to store properly formatted (HTML compliant) <a href="".....> tags with URL's and the respective titles
            List<string> formattedURLs = new List<string>();

            for (int i = 0; i < hrefLinks.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<p><a href='");
                sb.Append(hrefLinks.ElementAt(i));
                sb.Append("' target='_blank'>");
                sb.Append(linkTitles.ElementAt(i));
                //sb.Append("</a></p>");

                formattedURLs.Add(sb.ToString());
            }

            //begin new stringbuilder for final return string value
            StringBuilder finalReturnString = new StringBuilder();

            foreach (string validHREF in formattedURLs)
            {
                //append each item in "formattedURLs" to the final string, with an asp.net compliant line break (<br/>) between each
                finalReturnString.Append(validHREF);
                finalReturnString.Append("<br/>");
            }
            //return final stringbuilder string (.ToString())
            return (finalReturnString.ToString());
        }
    }
}
