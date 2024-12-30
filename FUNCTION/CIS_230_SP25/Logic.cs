namespace CIS_230_SP25;

public static class Logic
{
    public static string[] GenerateStringArray(int index)
    {
        return index switch
        {
            1 => new[] { "Washington", "Lincoln", "Jefferson", "Roosevelt", "Kennedy", "Reagan", "Trump" }, // Presidents
            2 => new[] { "Peter", "James", "John", "Andrew", "Philip", "Bartholomew", "Matthew", "Thomas", "James (Son of Alphaeus)", "Thaddaeus", "Simon", "Judas" }, // Disciples
            3 => new[] { "Africa", "Antarctica", "Asia", "Europe", "North America", "Australia", "South America" }, // Continents
            4 => new[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" }, // Planets
            5 => new[] { "Hydrogen", "Helium", "Lithium", "Beryllium", "Boron", "Carbon", "Nitrogen", "Oxygen", "Fluorine", "Neon" }, // Elements
            _ => new[] { "NCC-1701", "NCC-1701-D", "NCC-74656", "NX-01", "NCC-1864", "NCC-1031", "NCC-80102" } // Default remains unchanged
        };
    }

    public static int[] GenerateIntegerArray(int index)
    {
        return index switch
        {
            1 => new[] { 1512, 41000, 46379, 48315, 2151, 1207 }, // Series star dates
            2 => new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, // Fibonacci numbers
            3 => new[] { 2020, 2016, 2012, 2008, 2004, 2000 }, // Leap years
            4 => new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, // Even numbers
            5 => new[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 }, // Perfect squares
            _ => new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 } // Prime numbers
        };
    }
}