using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Itotaljointable" in both code and config file together.
    [ServiceContract]
    public interface Itotaljointable
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/ProductInformation", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ProductInformation> GetProductInformation();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/ProductInformation1", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
       List<ProductInformation1> GetProductInformation1();



        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/ProductInformation2", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ProductInformation2> GetProductInformation2();


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/ProductInformation3", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<ProductInformation3> GetProductInformation3();
       
    }
    [DataContract]

    public class ProductInformation
    {
        [DataMember]
        public string ProdId { get; set; }
        [DataMember]
        public string ProdName { get; set; }
        [DataMember]
        public string Price { get; set; }
        //[DataMember]
      //  public string ModelName { get; set; }
        [DataMember]
        public string ProdDetails { get; set; }

        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string DepartmentName { get; set; }

        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public int DepartmentID { get; set; }
    }
    [DataContract]
    public class ProductInformation1
    {
        [DataMember]
        public string ProdName { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public string DepartmentName { get; set; }

    }

    [DataContract]
    public class ProductInformation2
    {
        [DataMember]
        public int DepartmentId { get; set; }

        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public int ProdId { get; set; }


    }
    [DataContract]
    public class ProductInformation3
    {
        [DataMember]
        public int ProdId { get; set; }
        [DataMember]
        public string ProdName { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string ModelId { get; set; }
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
    }



}

