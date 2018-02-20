using GreenFabLab.BLL.Interface;
using GreenFabLab.BLL.Persistence;
using GreenFabLab.DTO;
using GreenFabLab.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.BLL.BusinessObject
{
    public class ManageContent : IManageContent
    {
        #region Private Fields

        /// <summary> 
        /// Unit of work
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        #endregion

        #region Contructor

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageContent"/> class.
        /// </summary>
        public ManageContent()
        {
            this.unitOfWork = new UnitOfWork();
        }

        /// <summary> 
        /// Initializes a new instance of the <see cref="ManageContent"/> class.
        /// </summary>
        /// <param name="uWork">the unit of work</param>
        public ManageContent(IUnitOfWork uWork)
        {
            this.unitOfWork = uWork;
        }

        #endregion

        #region Public member methods.

        /// <summary>
        ///  Function to authenticate
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <returns>returns UserID</returns>
        public List<WebsiteContent> GetMainPageContent(string contentTypeCode)
        {
            return this.unitOfWork.WebsiteContentnRepository.GetQuery(w => w.ContentType.ContentTypeCode == contentTypeCode).ToList();
        }

        #endregion
    }
}
