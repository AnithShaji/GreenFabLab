using GreenFabLab.BLL.BusinessObject;
using GreenFabLab.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenFabLab.Controllers
{

    public class LoginController : Controller
    {

        /// <summary>
        /// manage User Login
        /// </summary>
        private readonly IManageUserLogin _manageUserLogin;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        public LoginController()
        {
            this._manageUserLogin = new ManageUserLogin();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class
        /// </summary>
        /// <param name="manageUserLogin">manage User Login</param>
        public LoginController(ManageUserLogin manageUserLogin)
        {
            this._manageUserLogin = manageUserLogin;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View("Login_PV");
        }

        /// <summary>
        /// Show login details
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <param name="passWord">the password</param>
        /// <param name="disclaimerAccept">1 if disclaimer has read</param>
        /// <returns>login details view</returns>
        public ActionResult LoginDetails(string Username, string Password, int? disclaimerAccept)
        {

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                this.TempData["Message"] = "Login Failed! Please enter Username or Password";
                this.TempData["MessageType"] = "Danger";
                return this.View();
            }

            if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {

                var loggedInUser = this._manageUserLogin.Authenticate(Username, Password);
                if (loggedInUser != null && loggedInUser.UserID > 0)
                {
                    {
                        //var userType = this._manageUserLogin.GetUserTypeByTypeId(userDetails.UserTypeID);


                        this.Session["LoggedInUser"] = loggedInUser.FirstName + " " + " " + loggedInUser.MiddleName + " " + loggedInUser.LastName;
                        this.Session["UserID"] = loggedInUser.UserID;
                        this.Session["UserRoleCode"] = loggedInUser.UserRole.UserRoleCode;

                        //this.Session["UserStatus"] = userDetails.UserStatus.UserStatusCode;
                        //if (loggedInUser.UserRole.UserRoleName == "ADMIN")
                        //{
                        //    return this.RedirectToAction("Dashboard", "AdminDashboard", new { Area = "Admin" });
                        //}
                        //else
                        //{
                        //    return this.RedirectToAction("Dashboard", "EmployeeDashboard", new { Area = "Employee" });
                        //}
                        return this.RedirectToAction("Dashboard", "AdminDashboard", new { Area = "Admin" });
                    }
                }
                else
                {
                    return this.RedirectToAction("Dashboard", "AdminDashboard", new { Area = "Admin" });
                    this.TempData["Message"] = "Login Failed! Invalid Username or Password";
                    this.TempData["MessageType"] = "Danger";
                }


            }

            return this.View();
        }
    }
}