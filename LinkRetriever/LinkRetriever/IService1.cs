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

namespace LinkRetriever
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/returnedLinks?webURL={webURL}")]

        string returnedLinks(string webURL);
       
    }


}
