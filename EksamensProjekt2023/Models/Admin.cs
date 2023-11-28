namespace EksamensProjekt2023.Models
{
    public class Admin
    {
        public int AdminLvl { get; set; }
        public string? AdminName { get; set; } 

        public Admin(int adminLvl, string adminName)
        {
            AdminLvl = adminLvl;
            AdminName = adminName;
        }

        
    }
}
