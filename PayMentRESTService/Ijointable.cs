using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ijointable" in both code and config file together.
    [ServiceContract]
    public interface Ijointable
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetStudentDetails", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<StudentDetail>GetStudentDetails();
      //  List<StudentMark> GetStudentmarks();
      //  List<StudentRank> GetStudentRanks();

    }

    [DataContract]
    public class StudentDetails
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember] 
        public string RollNo { get; set; }
        [DataMember]
        public string Marks { get; set; }

    }
  //  [DataContract]
    //public class GetStudentmarks
    //{
    //    [DataMember]
    //    public string Id { get; set; }
    //    [DataMember]
    //    public string Marks { get; set; }
    //    [DataMember]
    //    public string Percentage { get; set; }
    //}
    //[DataContract]
    //public class GetStudentRanks
    //{
    //    [DataMember]
    //    public string Id { get; set; }
    //    [DataMember]
    //    public string Rank { get; set; }
    //    [DataMember]
    //    public string Marks { get; set; }
    //}
}
