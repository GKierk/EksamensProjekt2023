using System;


namespace EksamensProjekt2023.Models
{
    public class Role
    {
        private Admin _admin;
        private Leader _leader;
        private Boardmember _boardmember;
        private Member _member;

        public Role(Admin admin, Leader leader, Boardmember boardmember, Member member)
        { 
            _admin = admin;
            _leader = leader;
            _boardmember = boardmember;
            _member = member;

        }
        
    }

    
}
