using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFabLab.DTO.ViewModel
{
   public class ApplicantListingVM
    {
        /// <summary>
        /// Gets or sets the primary key
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets the full name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the telephone
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the PostCode
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the ProjectSection
        /// </summary>
        public string ProjectSection { get; set; }

        /// <summary>
        /// Gets or sets the mobile
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets the date of birth
        /// </summary>
        public DateTime? DOB { get; set; }

        /// <summary>
        /// Gets or sets the registration document path
        /// </summary>
        public string RegDocumentPath { get; set; }

        /// <summary>
        /// Gets or sets the flat house number
        /// </summary>
        public string FlatHouseNameNumber { get; set; }

        /// <summary>
        /// Gets or sets the address line 1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city
        /// </summary>
        public string City { get; set; }

        ///// <summary>
        ///// Gets or sets the created date
        ///// </summary>
        public DateTime CreatedDate { get; set; }

        ///// <summary>
        ///// Gets or sets the modified date
        ///// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by user ID
        /// </summary>
        public int? CreatedByID { get; set; }

        /// <summary>
        /// Gets or sets the modified by user
        /// </summary>
        public int? ModifiedByID { get; set; }
        
    }
}
