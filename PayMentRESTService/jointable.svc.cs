using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "jointable" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select jointable.svc or jointable.svc.cs at the Solution Explorer and start debugging.
    public class jointable : Ijointable
    {
        TestDBEntities3 Test = new TestDBEntities3();
        public List<StudentDetail> GetStudentDetails()
        {
            var stud = (from s in Test.StudentDetails
                        join m in Test.StudentMarks on s.Id.ToString() equals m.Id
                        join r in Test.StudentRanks on s.Id.ToString() equals r.Id
                        //orderby r.Marks


                        select s).AsEnumerable().Select(x =>
                        new StudentDetail
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Marks = x.Marks,
                            RollNo = x.RollNo

                        }).ToList();

            return stud;


           // throw new NotImplementedException();
        }

       
    }
}

