using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using CodeFirstPrimer.Models.NHL;

namespace CodeFirstPrimer.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Team> GeTeams()
        {

         List<Team> Teams = new List<Team>()
        {
            new Team()
            {
                TeamName = "Canucks",
                City = "Vancouver",
                Province = "BC",


            },
            new Team()
            {
                TeamName = "Oilers",
                City = "Edmonton",
                Province = "Alberta",


            },
            new Team()
            {
                TeamName = "Flames",
                City = "Calgary",
                Province = "Alberta",


            },
        };
            return Teams;

        }

        public static List<Player> GetPlayers(NhlContext context)
         {
             List<Player> Players = new List<Player>()
             {
                 new Player
                 {
                     FirstName = "Mahesh Kumar",
                     LastName = "Yadav",
                     Position = "Coach",
                     TeamName = context.Teams.Find("Canucks").TeamName,
                     Salary = 89,
                 },
                 new Player
                 {
                     FirstName = "Naresh Kumar",
                     LastName = "Yadav",
                     Position = "Forward",
                     TeamName = context.Teams.Find("Oilers").TeamName,
                     Salary = 6.9,
                 },
                 new Player
                 {
                     FirstName = "Kumar Kumar",
                     LastName = "Yadav",
                     Position = "Left Wing",
                     TeamName = context.Teams.Find("Flames").TeamName,
                     Salary = 4.5,
                 },
             };
             return Players;
         }
    
}
}