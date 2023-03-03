﻿using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Dictionary<string, TeamMember> team1 = new();
            string response = "y";
            while (response == "y")
            {

                Console.WriteLine("Enter team member's name:");
                string nameResponse = Console.ReadLine();

                if (nameResponse == "")
                {
                    Console.WriteLine($"Team count: {team1.Count}");

                    foreach (KeyValuePair<string, TeamMember> t in team1)
                    {
                        Console.WriteLine(t.Value.MemberInformation());
                    }
                    break;
                }
                else
                {
            Console.WriteLine("What is team member's skill level? (0 to 100)");
            int skillResponse = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("How courageous is this team member? (0 to 2)");
            double courageResponse = double.Parse(Console.ReadLine().Trim());

            TeamMember newMember = new TeamMember(nameResponse, skillResponse, courageResponse);

            Console.WriteLine(newMember.MemberInformation());

                team1.Add($"{newMember.Name}", newMember);

          Console.WriteLine("Would you like to enter another new team member? Y/N:");
          response = Console.ReadLine().ToLower();

                }
            }

        }
    }
}

