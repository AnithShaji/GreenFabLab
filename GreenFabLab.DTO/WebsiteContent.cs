using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.DTO
{
   public class WebsiteContent
    {
        /// <summary>
        /// Gets or sets the primary key
        /// </summary>
        [Key]
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
        [ForeignKey("ContentType")]
        public int ContentTypeID { get; set; }

        /// <summary>
        /// Gets or sets the user status
        /// </summary>
        public virtual ContentType_Master ContentType { get; set; }
    }
}
