using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.DTO
{
   public class ContentType_Master
    {
        /// <summary>
        /// Gets or sets the primary key
        /// </summary>
        [Key]
        public int ContentTypeID  { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        public string ContentTypeCode { get; set; }
    }
}
