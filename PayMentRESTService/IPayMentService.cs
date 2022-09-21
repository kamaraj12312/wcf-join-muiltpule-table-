using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPayMentService" in both code and config file together.
    [ServiceContract]
    public interface IPayMentService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/PayBill/{PayId}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string PayBill(string PayId);

        //    [OperationContract]
        //    [WebInvoke(Method = "GET",
        //RequestFormat = WebMessageFormat.Json,
        //ResponseFormat = WebMessageFormat.Json,
        //UriTemplate = "/GetCustomers/{Account_Holder_Last_Name}")]
        //    string Constring(string Account_Holder_Last_Name);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetAllCities", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Cities> GetAllCities();
    }
    //[DataContract]
    // public class Constring
    //{
    //    [DataMember]
    //    public string Account_Holder_First_Name { get; set; }

    //    [DataMember]
    //    public string Account_Holder_Last_Name { get; set; }    
    //}

    [DataContract]
    public class Cities
    {
        [DataMember]
        public string CityN { get; set; }
        [DataMember]
        public int CityID { get; set; }
    }

}
