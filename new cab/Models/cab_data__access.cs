using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using new_cab.Models;
namespace new_cab.Models
{
    public class cab_data__access
    {
        //private SqlConnection con;
        //private void connection()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        //    con = new SqlConnection(constr);

        //}
        public IEnumerable<UserDetail> Getallrecord()
        {
          //  connection();
           // List<UserDetail> lstUser = new List<UserDetail>();
          using(CabBookingEntities db= new CabBookingEntities ())
            {
                return db.UserDetails.ToList<UserDetail>();
            }

        }
    }
}