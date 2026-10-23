using System;
using System.Collections.Generic;

namespace RandomNames.Naming
{
    /// <summary>
    /// Builds street names like "Oakbrook Avenue" or "Harrington Lane", district names like
    /// "Oakbrook", "Old Ashford" or "Maple Heights", and transit line names like "Red Line",
    /// "Harbor Express" or "Oakbrook–Ashford Line".
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

        private static readonly string[] LineColors =
        {
            "Red", "Blue", "Green", "Orange", "Yellow", "Purple", "Silver", "Gold", "Pink", "Brown",
            "Teal", "Crimson", "Indigo", "Emerald", "Amber",
        };

        private static readonly string[] LineAreas =
        {
            "Northern", "Southern", "Eastern", "Western", "Central", "Circle", "Metropolitan", "Coastal",
            "Riverside", "Lakeshore", "Harbor", "Valley", "Hillside", "Airport", "Crosstown", "Downtown",
            "Uptown", "Parkside", "Bayside", "University",
        };

        private static readonly string[] LineTypes =
        {
            "Line", "Line", "Line", "Express", "Link", "Loop", "Shuttle", "Connector", "Rapid", "Flyer",
        };

        public bool IsAvailable(NameRequest request) => true;

        public string Generate(Random random, NameRequest request)
        {
            switch (request.Category)
            {
                case NameCategory.District:
                    return GenerateDistrict(random);
                case NameCategory.TransitLine:
                    return GenerateTransitLine(random, request.PlaceNames);
                default:
                    return GenerateStreet(random);
            }
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

        // Lines are named after a color, an area they serve, or the places at their ends.
        private static string GenerateTransitLine(Random random, IReadOnlyList<string> placeNames)
        {
            switch (random.Next(4))
            {
                case 0:
                    return $"{Pick(random, LineColors)} Line";
                case 1:
                    return $"{Pick(random, LineAreas)} {Pick(random, LineTypes)}";
                case 2:
                    return $"{GeneratePlace(random, placeNames)} {Pick(random, LineTypes)}";
                default:
                    string from = GeneratePlace(random, placeNames), to;
                    do to = GeneratePlace(random, placeNames); while (to == from);
                    return $"{from}–{to} {(random.Next(2) == 0 ? "Line" : "Express")}";
            }
        }

        // Half the places come from the city itself (its district names) when it has any.
        private static string GeneratePlace(Random random, IReadOnlyList<string> placeNames)
        {
            if (placeNames != null && placeNames.Count > 0 && random.Next(2) == 0)
                return placeNames[random.Next(placeNames.Count)];
            return random.Next(3) == 0 ? Pick(random, Surnames) : Pick(random, Prefixes) + Pick(random, Suffixes);
        }

        private static string Pick(Random random, string[] words) => words[random.Next(words.Length)];
    }
}
