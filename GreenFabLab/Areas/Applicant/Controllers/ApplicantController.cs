using GreenFabLab.BLL.BusinessObject;
using GreenFabLab.BLL.Interface;
using GreenFabLab.DTO.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GreenFabLab.Areas.Applicant.Controllers
{
    public class ApplicantController : Controller
    {
        private readonly IManageApplicant _manageApplicant;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantController"/> class.
        /// </summary>
        public ApplicantController()
        {
            this._manageApplicant = new ManageApplicant();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantController"/> class
        /// </summary>
        /// <param name="manageApplicant">manage Applicant</param>
        public ApplicantController(ManageApplicant manageApplicant)
        {
            this._manageApplicant = manageApplicant;
        }


        // GET: Applicant/Applicant
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        ///  Get all applicants
        /// </summary>
        /// <returns>returns applicant list</returns>
        public ActionResult GetApplicantList()
        {
            List<ApplicantListingVM> applicantList = new List<ApplicantListingVM>();

            if (this.Session["UserRoleCode"] != null)
            {
                applicantList = this._manageApplicant.GetAllApplicantByRole(this.Session["UserRoleCode"].ToString());
            }

            return Json(new { rows = applicantList }, JsonRequestBehavior.AllowGet);
        }
    }
}