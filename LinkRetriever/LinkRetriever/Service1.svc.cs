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
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(@"https://www.theverge.com/2019/4/10/18296793/foxconn-wisconsin-location-factory-innovation-centers-technology-hub-no-news");
            HtmlNodeCollection aTags = doc.DocumentNode.SelectNodes("//body//p//a");

            List<string> hrefLinks = new List<string>();

            foreach (HtmlNode tag in aTags)
            {
                hrefLinks.Add(@tag.Attributes["href"].Value);

            }

            List<string> linkTitles = new List<string>();

            foreach (string refURL in hrefLinks)
            {
                HtmlWeb refWeb = new HtmlWeb();
                HtmlDocument refDoc = web.Load(refURL);

                HtmlNode title = refDoc.DocumentNode.SelectSingleNode("//head//title");


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
            //<a href=&quot;url&quot;>text</a>

            List<string> formattedURLs = new List<string>();
            for (int i = 0; i < hrefLinks.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<a href=&quot;");
                sb.Append(hrefLinks.ElementAt(i));
                sb.Append("&quot;>");
                sb.Append(linkTitles.ElementAt(i));
                sb.Append("</ a >");

                formattedURLs.Add(sb.ToString());
            }


            StringBuilder finalReturnString = new StringBuilder();

            foreach (string validHREF in formattedURLs)
            {
                finalReturnString.Append(validHREF);
                finalReturnString.Append("<br>");
            }

            return finalReturnString.ToString();
        }
    }
}
