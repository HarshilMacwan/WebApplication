using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssignment1.Models
{
    public static class ClubRepository
    {
        private static List<Club> clubRepository = new List<Club> 
        {
            new Club{ClubName="Arsenal",Website="www.Arsenal.com",Email="Arsenal@dayna.ca",Phone="1234567890" },
            new Club{ClubName="Manchester",Website="www.Manchester.com",Email="Manchester@dayna.ca",Phone="1234567891" },
            new Club{ClubName="BourneMouth",Website="www.BourneMouth.com",Email="BourneMouth@dayna.ca",Phone="1234567892" },
            new Club{ClubName="Aston Villa",Website="www.AstonVilla.com",Email="AstonVilla@dayna.ca",Phone="1234567893" },
            new Club{ClubName="Brightin",Website="www.Brightin.com",Email="Brightin@dayna.ca",Phone="1234567894" },
            new Club{ClubName="Burnley",Website="www.Burnley.com",Email="Burnley@dayna.ca",Phone="1234567895" },
            new Club{ClubName="Chelsa",Website="www.Chelsa.com",Email="Chelsa@dayna.ca",Phone="1234567896" },
           
        };
        public static IEnumerable<Club> Clubs { get { return clubRepository; } }
        public static void addClub(Club club) { clubRepository.Add(club); }
        
    }
}
