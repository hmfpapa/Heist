using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Dictionary<string, TeamMember> team1 = new();

            string nameResponse = "NAME";
            Console.WriteLine("Choose your difficulty (0 to 100)");
            int bankDifficulty = int.Parse(Console.ReadLine().Trim());

            while (nameResponse != "")
            {


                Console.WriteLine("Enter team member's name: (Press enter to stop entering names and start a trial run)");
                nameResponse = Console.ReadLine();

                if (nameResponse == "")
                {
                    continue;
                }

                Console.WriteLine($"What is {nameResponse}'s skill level? (0 to 100)");
                int skillResponse = int.Parse(Console.ReadLine().Trim());

                Console.WriteLine($"How courageous is {nameResponse}? (0 to 2)");
                double courageResponse = double.Parse(Console.ReadLine().Trim());

                TeamMember newMember = new TeamMember(nameResponse, skillResponse, courageResponse);

                // Console.WriteLine(newMember.MemberInformation());

                team1.Add($"{newMember.Name}", newMember);

            }

            Console.WriteLine("How Many trial runs would you like to perform?");
            int trialRuns = int.Parse(Console.ReadLine());

            int wins = 0;
            int losses = 0;

            for (int i = 1; i <= trialRuns; i++)
            {



                int luck = new Random().Next(-10, 11);
                bankDifficulty = bankDifficulty + luck;
                int teamSkillLevel = team1.Sum(x => x.Value.Skill);

                Console.WriteLine($"Your current team skill level is {teamSkillLevel}. The bank difficulty is {bankDifficulty}");

                if (teamSkillLevel < bankDifficulty)
                {

                    Console.WriteLine("You have failed");
                    losses += 1;
                }
                else
                {
                    Console.WriteLine("You have succeeded!");
                    wins += 1;
                }
            }
            Console.WriteLine($"{wins} wins!");
            Console.WriteLine($"{losses} losses :(");

        }
    }

}



