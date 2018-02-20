using GreenFabLab.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.BLL.Interface
{
    public interface IManageApplicant
    {
        /// <summary>
        ///  Function to get all applicants based on UserRoleCode
        /// </summary>
        /// <returns>returns applicant list</returns>
        List<ApplicantListingVM> GetAllApplicantByRole(string UserRoleCode);
    }
}
