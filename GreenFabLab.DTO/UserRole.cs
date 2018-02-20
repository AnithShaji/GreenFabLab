using System;
using System.ComponentModel.DataAnnotations;

namespace GreenFabLab.DTO
{
    public class UserRole
    {
        /// <summary>
        /// Gets or sets the primary key
        /// </summary>
        [Key]
        public int UserRoleID { get; set; }

        /// <summary>
        /// Gets or sets the user type name
        /// </summary>
        public string UserRoleName { get; set; }

        /// <summary>
        /// Gets or sets the user type Code
        /// </summary>
        public string UserRoleCode { get; set; }

        /// <summary>
        /// Gets or sets the created date
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
