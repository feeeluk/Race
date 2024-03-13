﻿using System;
using System.Collections.Generic;

namespace Race
{
    public class Team
    {
        // ****************************************************************
        // Fields
        // ****************************************************************
        public static List<Team> teams = new List<Team>();
        public List<Vehicle> vehiclesInTeam = new List<Vehicle>();


        // ****************************************************************
        // Properties
        // ****************************************************************
        public string Name { get; set; }
        public static int NumberOfTeams { get; private set; }


        // ****************************************************************
        // Constructor
        // ****************************************************************
        public Team(string name)
        {
            Name = name;
            NumberOfTeams++;
            teams.Add(this);
        }


        // ****************************************************************
        // Methods
        // ****************************************************************
    }
}
