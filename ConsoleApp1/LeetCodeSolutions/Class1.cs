namespace ConsoleApp1.LeetCodeSolutions
{
    public class Team
    {
        public string teamName { get;   set; }
        public int noOfPlayers { get;   set; }

        public Team(string teamname, int noofplayers)
        {
            teamName = teamname;
            noOfPlayers = noofplayers;

        }

        public void AddPlayer(int num)
        {
            noOfPlayers++;
        }

        public bool RemovePlayer(int num)
        {
            int tempnum = noOfPlayers - 1;
            if (tempnum < 0)
            {
                return false;
            }
            else
            {
                noOfPlayers--;
                return true;
            }


        }


    }

    public class Subteam : Team
    {

        public Subteam(string teamName, int noOfPlayers) : base(teamName, noOfPlayers)
        {

        }

        public void ChangeTeamName(string name)
        {
            
            base.teamName = name;
        }

    }
}
