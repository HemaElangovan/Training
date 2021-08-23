using MvcRegistrationTask.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRegistrationTask.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        RegisterModel rm = new RegisterModel();
        public ActionResult Get()
        {
            DataTable dt = rm.GetData();
            return View("RFDetails",dt);
        }
        public ActionResult Insert()
        {
            return View ("InsertData");
        }
        public ActionResult InsertDetails(FormCollection fc, string action)
        {
            DataTable dt = rm.GetData();
            if(action=="Submit")
            {
                string fname = fc["txt_fname"];
                string lname = fc["txt_lname"];
                string age = fc["txt_age"];
                string gender = fc["txt_gender"];
                int ins = rm.InsertData(fname, lname, Convert.ToInt32(age), gender);
                return View("RFDetails", dt);
            }
            else
            {
                return RedirectToAction("Get", dt);
            }
        }
        public ActionResult Edit(int rno)
        {
            DataTable dt = rm.Edit(rno);
            return View("Edit", dt);

        }
        public ActionResult EditDetails(FormCollection fc, string action)
        {
            if(action =="Submit")
            {
                int rno = Convert.ToInt32(fc["txt_rno"]);
                string fname = fc["txt_fname"];
                string lname = fc["txt_lname"];
                string age = fc["txt_age"];
                string gender = fc["txt_gender"];
                int ins = rm.EditData(rno,fname, lname, Convert.ToInt32(age), gender);
                return RedirectToAction("Get");
            }
            return RedirectToAction("Get");
        }
    }
}