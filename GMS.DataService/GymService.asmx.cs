using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMS.DataService.DataContext;
using System.Web.Services;

namespace GMS.DataService
{
    /// <summary>
    /// Summary description for GymService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GymService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public object GetMember(int id)
        {
            using (gymEntities db = new gymEntities())
            {
                var member = db.Members.Find(id);

                return member;
            }

                
        }
    }
}
