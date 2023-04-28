using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; internal set; }                 
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The alst name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of the person.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The cell phone number of the person.
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
