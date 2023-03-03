using System;

namespace Heist
{
    class TeamMember
    {
 public TeamMember (string name, int skill, double courage)
            {
                Name = name;
                Skill = skill;
                Courage = courage;

            }

            public string Name {get; set;}
            public int Skill {get; set;}
            public double Courage {get; set;}

        //    public string MemberInformation()
        //     {
        //         return $"Name: {Name} | Skill Level: {Skill} | Courage: {Courage}";
        //     }
    }
}