using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.DTO.ViewModel
{
   public class MPContentVM
    {

        /// <summary>
        /// Gets or sets the primary key
        /// </summary>
        public int WebsiteContentID { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string ContentLbl { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the user status ID
        /// </summary>
        public int ContentTypeID { get; set; }
    }
}
