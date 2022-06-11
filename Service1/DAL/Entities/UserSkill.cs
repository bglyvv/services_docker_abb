using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service1.DAL.Entities
{
    public class UserSkill
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
