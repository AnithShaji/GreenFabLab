using GreenFabLab.BLL.Interface;
using GreenFabLab.BLL.Persistence;
using GreenFabLab.DTO;
using System.Linq;

namespace GreenFabLab.BLL.BusinessObject
{
    /// <summary> 
    /// Class for managing User Login
    /// </summary>
    /// 
    public class ManageUserLogin : IManageUserLogin
    {
        #region Private Fields

        /// <summary> 
        /// Unit of work
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        #endregion

        #region Contructor

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageUserLogin"/> class.
        /// </summary>
        public ManageUserLogin()
        {
            this.unitOfWork = new UnitOfWork();
        }

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageUserLogin"/> class.
        /// </summary>
        /// <param name="uWork">the unit of work</param>
        public ManageUserLogin(IUnitOfWork uWork)
        {
            this.unitOfWork = uWork;
        }

        #endregion

        #region Public member methods.

        /// <summary>
        ///  Function to authenticate
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <param name="password">pass word</param>
        /// <returns>returns UserID</returns>
        public Users Authenticate(string userName, string password)
        {
            return this.unitOfWork.UserRepository.GetQuery(u => u.Username == userName && u.Password == password).FirstOrDefault();
        }

        #endregion
    }
}
