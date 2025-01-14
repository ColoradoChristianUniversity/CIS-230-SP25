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

    public static (string Name, string StateCode)[] GenerateStates()
    {
        return
        [
            ("Alabama", "AL"), ("Alaska", "AK"), ("Arizona", "AZ"), ("Arkansas", "AR"),
            ("California", "CA"), ("Colorado", "CO"), ("Connecticut", "CT"), ("Delaware", "DE"),
            ("Florida", "FL"), ("Georgia", "GA"), ("Hawaii", "HI"), ("Idaho", "ID"),
            ("Illinois", "IL"), ("Indiana", "IN"), ("Iowa", "IA"), ("Kansas", "KS"),
            ("Kentucky", "KY"), ("Louisiana", "LA"), ("Maine", "ME"), ("Maryland", "MD"),
            ("Massachusetts", "MA"), ("Michigan", "MI"), ("Minnesota", "MN"), ("Mississippi", "MS"),
            ("Missouri", "MO"), ("Montana", "MT"), ("Nebraska", "NE"), ("Nevada", "NV"),
            ("New Hampshire", "NH"), ("New Jersey", "NJ"), ("New Mexico", "NM"), ("New York", "NY"),
            ("North Carolina", "NC"), ("North Dakota", "ND"), ("Ohio", "OH"), ("Oklahoma", "OK"),
            ("Oregon", "OR"), ("Pennsylvania", "PA"), ("Rhode Island", "RI"), ("South Carolina", "SC"),
            ("South Dakota", "SD"), ("Tennessee", "TN"), ("Texas", "TX"), ("Utah", "UT"),
            ("Vermont", "VT"), ("Virginia", "VA"), ("Washington", "WA"), ("West Virginia", "WV"),
            ("Wisconsin", "WI"), ("Wyoming", "WY")
        ];
    }

    public static (string Name, string StateCode)[] GenerateCapitals()
    {
        return
        [
            ("Montgomery", "AL"), ("Juneau", "AK"), ("Phoenix", "AZ"), ("Little Rock", "AR"),
            ("Sacramento", "CA"), ("Denver", "CO"), ("Hartford", "CT"), ("Dover", "DE"),
            ("Tallahassee", "FL"), ("Atlanta", "GA"), ("Honolulu", "HI"), ("Boise", "ID"),
            ("Springfield", "IL"), ("Indianapolis", "IN"), ("Des Moines", "IA"), ("Topeka", "KS"),
            ("Frankfort", "KY"), ("Baton Rouge", "LA"), ("Augusta", "ME"), ("Annapolis", "MD"),
            ("Boston", "MA"), ("Lansing", "MI"), ("St. Paul", "MN"), ("Jackson", "MS"),
            ("Jefferson City", "MO"), ("Helena", "MT"), ("Lincoln", "NE"), ("Carson City", "NV"),
            ("Concord", "NH"), ("Trenton", "NJ"), ("Santa Fe", "NM"), ("Albany", "NY"),
            ("Raleigh", "NC"), ("Bismarck", "ND"), ("Columbus", "OH"), ("Oklahoma City", "OK"),
            ("Salem", "OR"), ("Harrisburg", "PA"), ("Providence", "RI"), ("Columbia", "SC"),
            ("Pierre", "SD"), ("Nashville", "TN"), ("Austin", "TX"), ("Salt Lake City", "UT"),
            ("Montpelier", "VT"), ("Richmond", "VA"), ("Olympia", "WA"), ("Charleston", "WV"),
            ("Madison", "WI"), ("Cheyenne", "WY")
        ];
    }
}