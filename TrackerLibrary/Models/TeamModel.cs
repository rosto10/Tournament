using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The name of the team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// The list consisting of team member information
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        


    }
}
