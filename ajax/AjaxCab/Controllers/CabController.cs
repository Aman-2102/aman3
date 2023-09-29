using AjaxCab.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxCab.Controllers
{
    public class CabController : Controller
    {
        cab_dataaccess cda = new cab_dataaccess();
        // GET: Cab
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            

            IEnumerable<UserDetail> ul = cda.Getallrecord();
            return View(ul);
        }

        public ActionResult addOrEdit(int id=0)
        {
            UserDetail ud = new UserDetail();
            return View(ud);
        }
        [HttpPost]
        public ActionResult addOrEdit(UserDetail ud)
        {
            if(ud.imageupload!=null) 
            {
                string filename = Path.GetFileNameWithoutExtension(ud.imageupload.FileName);
                string extension = Path.GetExtension(ud.imageupload.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                ud.userpass = "~/App/image/" + filename;
                ud.imageupload.SaveAs(Path.Combine(Server.MapPath("~/ App/image/"), filename));
            }
            using(DbModels db =new DbModels())
            {
                db.UserDetails.Add(ud);
                db.SaveChanges();
            }
            return RedirectToAction("ViewAll");
        }
    }
}