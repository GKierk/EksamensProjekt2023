namespace EksamensProjekt2023.Models
{
    public class Boardmember
    {
        public int BoardmemberLvl { get; set; }
        public string BoardmemberName { get; set; }

        public Boardmember(int boardmemberLvl, string boardmemberName)
        {
            BoardmemberLvl = boardmemberLvl;
            BoardmemberName = boardmemberName;
        }
    }
}
