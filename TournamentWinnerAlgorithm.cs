using System.Collections.Generic;

namespace AlgoExpertAlgorithmsLibrary
{
    public class TournamentWinnerAlgorithm
    {
        // Teams compete in a round robin. All teams play eachother once. Each match there is a home and an away team.
        // There is always a winner and a loser. A win worth 3 points and a loss is worth 0 points.

        // Function: given an array of pairs representing matches against eachother with competitions and results:
        /* Competitions array
           [
           ["HTML", "C#"],
           ["C#", "Python"],
           ["Python", "HTML"]
           ] 

            Results array
            [0, 0, 1]
        */
        //  In the results array a 1 means the home team won and a zero means the away team won.
        //  One winner will be decided by the function.

        public static int HOME_TEAM_WON = 1;

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            string currentBestTeam = "";
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores[currentBestTeam] = 0;

            for (int index = 0; index < competitions.Count; index++)
            {
                List<string> competition = competitions[index];
                int result = results[index];

                string homeTeam = competition[0];
                string awayTeam = competition[1];

                string winningTeam = (result == HOME_TEAM_WON) ? homeTeam : awayTeam;

                updateScores(winningTeam, 3, scores);

                if (scores[winningTeam] > scores[currentBestTeam])
                {
                    currentBestTeam = winningTeam;
                }

                //if (scores[winningTeam] == scores[currentBestTeam])
                //{
                //    //TODO: Tie functionality
                //}
                //else if (scores[winningTeam] > scores[currentBestTeam])
                //{
                //    currentBestTeam = winningTeam;
                //}
            }
            System.Console.WriteLine($"The winner of the tournament is {currentBestTeam}!");
            return currentBestTeam;
        }

        public static void updateScores(string team, int points, Dictionary<string, int> scores)
        {
            if (!scores.ContainsKey(team))
            {
                scores[team] = 0;
            }

            scores[team] = scores[team] + points;
        }
    }
}