using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxCab.Models
{
    public class cab_dataaccess
    {
        public IEnumerable<UserDetail> Getallrecord()
        {
            //  connection();
            // List<UserDetail> lstUser = new List<UserDetail>();
            using (DbModels db = new DbModels())
            {
                return db.UserDetails.ToList<UserDetail>();
            }

        }
    }
}