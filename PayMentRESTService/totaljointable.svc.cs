using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "totaljointable" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select totaljointable.svc or totaljointable.svc.cs at the Solution Explorer and start debugging.
    public class totaljointable : Itotaljointable
    {
        TestDBEntities4 Test = new TestDBEntities4();
        public List<ProductInformation> GetProductInformation()
        {
            var prodList = (from p in Test.Products
                            join pd in Test.ProductDescriptions on p.ProdId equals pd.ProductDesId
                            join e in Test.Employees on p.ProdId equals e.EmployeeId
                            join d in Test.Departments on p.ProdId equals d.DepartmentId
                            //join r in Test.Employees on p.ProdName equals r.EmployeeName
                            //join t in Test.Departments on pd.ProdDetails equals t.DepartmentName

                            select new ProductInformation
                            {
                                ProdId = p.ProdId.ToString(),
                                ProdName = p.ProdName,
                                Price = p.Price,
                                ProdDetails = pd.ProdDetails,
                                EmployeeID = e.EmployeeId,
                                DepartmentID = d.DepartmentId,
                                //EmployeeName = r.EmployeeName,
                                //DepartmentName = t.DepartmentName
                            }).ToList();
            return prodList;



            // throw new NotImplementedException();
        }
       public  List<ProductInformation1> GetProductInformation1()
        {
            var productList = (from p in Test.Products
                               join d in Test.Departments on p.ProdName equals d.DepartmentName
                               //join e in Test.Employees on p.ProdName equals e.EmployeeName

                               select new ProductInformation1
                               {
                                   ProdName = p.ProdName,
                                   //DepartmentName = pd.DepartmentName,
                                   //EmployeeName = e.EmployeeName,

                               }).ToList();
            return productList;

           // throw new NotImplementedException();
        }
        public List<ProductInformation2> GetProductInformation2()
        {
            var productID =(from pp in Test.Products
                             join s in Test.Departments on pp.ProdId equals s.DepartmentId
                             join a in Test.Employees on pp.ProdId equals a.EmployeeId
                        
                             select new ProductInformation2
                             {
                                 ProdId =pp.ProdId,
                                 DepartmentId =s.DepartmentId,
                                 EmployeeId = a.EmployeeId,
                             }).ToList();

            return productID;
        }
        //public List<ProductInformation3> GetProductInformation3()
        //{
           
        //}

       public List<ProductInformation3> GetProductInformation3()
        {
            var productjoin = (from q in Test.Products
                              // where Convert.ToInt32(q.ProdName) > 80
                               from e in Test.Employees
                               join w in Test.Employees on q.ProdId equals w.EmployeeId
                               where q.ProdId >= e.EmployeeId
                               select new ProductInformation3
                               {
                                   ProdId = w.EmployeeId
                               }).ToList();

            return productjoin;
        }
    }
}
