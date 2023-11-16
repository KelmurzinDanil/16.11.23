using System.Collections.Generic;

namespace BigRaces
{
    public class Team
    {
        readonly string teamCountry;
        readonly List<string[]> participantsShow = new List<string[]>();

        public Team(string teamCountry, string[] participantsShow)
        {
            this.teamCountry = teamCountry;
            this.participantsShow.Add(participantsShow);
        }   
    }
}
