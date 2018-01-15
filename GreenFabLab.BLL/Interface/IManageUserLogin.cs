using GreenFabLab.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.BLL.Interface
{
    /// <summary>
    /// Interface for Manage User Login
    /// </summary>
   public interface IManageUserLogin
    {
        /// <summary>
        ///  Function to check User Login.
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <param name="password">pass word</param>
        /// <returns>returns user details</returns>
        Users Authenticate(string userName, string password);
    }
}
