using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenFabLab.Areas.Admin.Controllers
{
    public class AdminDashboardController : Controller
    {
        // GET: Admin/AdminDashboard
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Admin Dashboard
        /// </summary>
        /// <returns>dashboard view</returns>
        public ActionResult Dashboard(string tab)
        {
            if (tab != null)
            {
                this.ViewData["ActiveTab"] = tab;
            }
            return this.View();
        }

        /// <summary>
        /// Load the tabs of admin details
        /// </summary>
        /// <param name="tab"> indicate which tab</param>
        /// <param name="clientID">client ID</param>
        /// <returns>view of tabs</returns>
        public ActionResult LoadAdminTab(string tab)
        {
            switch (tab)
            {

                case "tabDashboard":
                    {
                        return this.PartialView("Dashboard");
                    }

                case "tabUserProfile":
                    {
                        return this.PartialView("UserProfile");
                    }

                case "tabApplicantList":
                    {
                        return this.PartialView("TabAppliacntList");
                    }
              
                default:
                    {
                        return this.PartialView("Dashboard");
                    }
            }
        }
    }
}