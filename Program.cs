using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

Console.WriteLine("Enter team member's name:");
string nameResponse = Console.ReadLine().Trim();

Console.WriteLine("What is team member's skill level? (0 to 100)");
int skillResponse = int.Parse(Console.ReadLine().Trim());


Console.WriteLine("How courageous is this team member? (0 to 2)");
double courageResponse = double.Parse(Console.ReadLine().Trim());

  string MemberInformation(TeamMember member){
                return $"{member.Name} {member.Skill} {member.Courage}";
            }

TeamMember mem1 = new TeamMember(nameResponse, skillResponse, courageResponse);

string information = MemberInformation(mem1);

Console.WriteLine(information);
        }
    }
}
