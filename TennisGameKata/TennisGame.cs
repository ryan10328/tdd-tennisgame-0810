using System;
using System.Collections.Generic;

namespace TennisGameKata
{
    public class TennisGame
    {
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public static Dictionary<int, string> ScoreMapping;

        public TennisGame()
        {
            ScoreMapping = new Dictionary<int, string>();
            ScoreMapping.Add(0, "Love");
            ScoreMapping.Add(1, "Fifteen");
            ScoreMapping.Add(2, "Thirty");
            ScoreMapping.Add(3, "Forty");
        }

        public string Score()
        {
            var advPlayer = HomeScore > AwayScore ? "John" : "Tom";

            if (HomeScore == AwayScore)
            {
                if (HomeScore >= 3)
                {
                    return "Deuce";
                }

                return $"{ScoreMapping[HomeScore]} All";
            }

            if (HomeScore >= 3 && AwayScore >= 3)
            {

                if (Math.Abs(HomeScore - AwayScore) == 1)
                {
                    return $"{advPlayer} Adv";
                }

            }

            if (HomeScore > 3 || AwayScore > 3)
            {
                return $"{advPlayer} Win";
            }

            return $"{ScoreMapping[HomeScore]} {ScoreMapping[AwayScore]}";
        }
    }
}