using GreenFabLab.BLL.BusinessObject;
using GreenFabLab.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace GreenFabLab.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// manage Manage Content
        /// </summary>
        private readonly IManageContent _manageContent;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        public HomeController()
        {
            this._manageContent = new ManageContent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class
        /// </summary>
        /// <param name="manageContent">manage Manage Content</param>
        public HomeController(ManageContent manageContent)
        {
            this._manageContent = manageContent;
        }

        public ActionResult Index()

        {
            var lang = string.Empty;
            if (this.Session["Language"] != null)
            {
                lang = this.Session["Language"].ToString();
            }

            var content = this._manageContent.GetMainPageContent(lang);

            return View(content);
        }

        public ActionResult About()
        {

            var lang = string.Empty;
            if (this.Session["Language"] != null)
            {
                lang = this.Session["Language"].ToString();
            }
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult WasteWaterWork()
        {
            return View();
        }

        public ActionResult BiodieselWork()
        {
            return View();
        }

        public ActionResult BiogasWork()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Blog1()
        {
            return View();
        }

        public ActionResult Blog2()
        {
            return View();
        }
        public ActionResult geolocation()
        {
            return View();
        }
        public ActionResult ChangeLanguage(string lang)
        {

            if (lang != null)
            {

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);
            return RedirectToAction("Index");
        }

    }
}