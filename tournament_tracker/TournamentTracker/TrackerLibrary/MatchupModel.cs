using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the score for this particular team
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the matchup that this team came from as the winner
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
