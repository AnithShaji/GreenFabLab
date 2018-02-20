using GreenFabLab.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.BLL.Interface
{
    public interface IManageContent
    {

        /// <summary>
        ///  Function to authenticate
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <returns>returns UserID</returns>
        List<WebsiteContent> GetMainPageContent(string contentTypeCode);
    }
}
