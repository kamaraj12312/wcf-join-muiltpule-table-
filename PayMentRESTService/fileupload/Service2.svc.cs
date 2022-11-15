using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService.file_upload
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        string path = @"D:\12 date08\PayMentRESTService\PayMentRESTService\image";

        public string upload(String input)
        { 
            string filename =String.Format(@"{0}\{1}.txt",path,Guid.NewGuid().ToString());
         
            return filename; 
        }
    }
}
