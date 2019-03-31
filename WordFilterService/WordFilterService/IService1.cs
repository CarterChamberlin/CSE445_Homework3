/*  Author: Carter Chamberlin
 *  Assignment: Project 3, Phase II
 *  Group: Group #16 (Carter & Chloe)
 *  Date: 31st March 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WordFilterService
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/FilteredString?originalString={originalString}")]
        string FilteredString(string originalString);

    }


    
}
