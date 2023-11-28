namespace EksamensProjekt2023.Models
{
    public class Member
    {
        public int MemberLvl { get; set; }
        public string MemberName { get; set; }

        public Member(int memberLvl, string memberName)
        {
            MemberLvl = memberLvl;
            MemberName = memberName;
        }
    }
}
