using GreenFabLab.BLL.Interface;
using GreenFabLab.BLL.Persistence;
using GreenFabLab.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.BLL.BusinessObject
{
    /// <summary> 
    /// Class for managing Applicant
    /// </summary>
    public class ManageApplicant : IManageApplicant
    {
        #region Private Fields

        /// <summary> 
        /// Unit of work
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        #endregion

        #region Contructor

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageApplicant"/> class.
        /// </summary>
        public ManageApplicant()
        {
            this.unitOfWork = new UnitOfWork();
        }

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageUserLogin"/> class.
        /// </summary>
        /// <param name="uWork">the unit of work</param>
        public ManageApplicant(IUnitOfWork uWork)
        {
            this.unitOfWork = uWork;
        }

        #endregion


        #region Public member methods.

        /// <summary>
        ///  Function to get all applicants based on UserRoleCode
        /// </summary>
        /// <returns>returns applicant list</returns>
        public List<ApplicantListingVM> GetAllApplicantByRole(string UserRoleCode)
        {
            var usrList = this.unitOfWork.UserRepository.GetQuery(null).Where(x => x.UserRole.UserRoleCode != UserRoleCode).ToList();
            List<ApplicantListingVM> lstApplicant = (from v in usrList
                                                 select new ApplicantListingVM
                                                 {
                                                     UserID = v.UserID,
                                                     FullName = v.FirstName + " " + v.MiddleName + " " + v.LastName,
                                                     EmailAddress = v.EmailAddress,
                                                     Country = v.Country,
                                                     RegDocumentPath = v.RegDocumentPath
                                                 }).ToList();
            return lstApplicant;
        }

        #endregion Public member methods.
    }
}
