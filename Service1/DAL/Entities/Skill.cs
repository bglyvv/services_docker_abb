using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service1.DAL.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserSkill> UserSkills { get; set; }
    }
}
