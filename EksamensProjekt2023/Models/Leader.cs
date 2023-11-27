namespace EksamensProjekt2023.Models
{
    public class Leader
    {
        public int LeaderLvl { get; set; }
        public string? LeaderName { get; set;}

        public Leader(int  leaderLvl, string leaderName)
        {
            LeaderLvl = leaderLvl;
            LeaderName = leaderName; 
        }
    }
}
