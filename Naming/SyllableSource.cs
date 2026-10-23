using System;

namespace RandomNames.Naming
{
    /// <summary>
    /// Builds street names like "Oakbrook Avenue" or "Harrington Lane", and district names like
    /// "Oakbrook", "Old Ashford" or "Maple Heights".
    /// </summary>
    public class SyllableSource : INameSource
    {
        private static readonly string[] StreetTypes =
        {
            "Street", "Avenue", "Road", "Lane", "Boulevard", "Drive", "Way", "Place",
            "Court", "Terrace", "Crescent", "Parkway", "Row", "Close", "Hill",
        };

        private static readonly string[] DistrictTypes =
        {
            "Heights", "Hills", "Park", "Village", "Gardens", "Square", "Quarter", "Grove",
            "Green", "Point", "End", "Town", "Meadows", "Commons", "Downs",
        };

        private static readonly string[] Prefixes =
        {
            "Oak", "Maple", "Elm", "Pine", "Cedar", "Birch", "Willow", "Ash", "Silver", "Golden",
            "Stone", "River", "Lake", "Spring", "Summer", "Winter", "Fox", "Deer", "Raven", "Hawk",
            "Green", "Red", "Black", "White", "North", "South", "East", "West", "High", "Fair",
        };

        private static readonly string[] Suffixes =
        {
            "brook", "field", "wood", "ridge", "dale", "ford", "view", "haven", "gate", "mere",
            "crest", "bury", "ton", "wick", "stead", "vale", "moor", "hurst", "well", "side",
        };

        private static readonly string[] Surnames =
        {
            "Harrington", "Whitmore", "Calloway", "Ashford", "Pemberton", "Lindqvist", "Moreau",
            "Castellano", "Okafor", "Novak", "Sato", "Fitzgerald", "Delgado", "Brennan", "Kowalski",
            "Montgomery", "Vasquez", "Thornton", "Abernathy", "Halvorsen",
        };

        private static readonly string[] DistrictQualifiers =
        {
            "Old", "New", "Upper", "Lower", "North", "South", "East", "West", "Little", "Great",
        };

        public bool IsAvailable(NameRequest request) => true;

        public string Generate(Random random, NameRequest request)
        {
            return request.Category == NameCategory.District ? GenerateDistrict(random) : GenerateStreet(random);
        }

        private static string GenerateStreet(Random random)
        {
            string stem;
            switch (random.Next(3))
            {
                case 0:
                    stem = Pick(random, Prefixes) + Pick(random, Suffixes);
                    break;
                case 1:
                    stem = Pick(random, Prefixes);
                    break;
                default:
                    stem = Pick(random, Surnames);
                    break;
            }
            return $"{stem} {Pick(random, StreetTypes)}";
        }

        // District names often stand on their own ("Oakbrook"), unlike street names.
        private static string GenerateDistrict(Random random)
        {
            var compound = Pick(random, Prefixes) + Pick(random, Suffixes);
            switch (random.Next(4))
            {
                case 0:
                    return compound;
                case 1:
                    return $"{Pick(random, DistrictQualifiers)} {compound}";
                case 2:
                    return $"{compound} {Pick(random, DistrictTypes)}";
                default:
                    var stem = random.Next(2) == 0 ? Pick(random, Prefixes) : Pick(random, Surnames);
                    return $"{stem} {Pick(random, DistrictTypes)}";
            }
        }

        private static string Pick(Random random, string[] words) => words[random.Next(words.Length)];
    }
}
