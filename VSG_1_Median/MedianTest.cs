using Xunit;

namespace VSG_1_Median;

public class MedianTest
{
    [Fact]
    public void Median_Should_Return_Correct_Value()
    {
        // Write a method to calculate the median of the employees list
        // and return the age, birthday and the name of the median employee
        // example for a median; [100,5,3,8,999] => 8

        var employeesOrdered = Employees
            .Where(e => e.Birthday != null)
            .OrderBy(e => e.Birthday)
            .ToList();

        var cnt = employeesOrdered.Count;
        var middle = employeesOrdered.Count / 2;

        var median =
            cnt % 2 == 0
                ? (
                    GetAge(employeesOrdered[middle].Birthday)
                    + GetAge(employeesOrdered[middle + 1].Birthday)
                ) / 2.0
                : GetAge(employeesOrdered[middle].Birthday);

        if (cnt % 2 == 0)
        {
            Console.WriteLine(
                $"Two {employeesOrdered[middle].Rep} {employeesOrdered[middle + 1].Rep}"
            );
        }
        else
        {
            Console.WriteLine($"{employeesOrdered[middle].Rep}");
        }

        Assert.Equal(52, (int)median);
    }

    private static double GetAge(DateTime? birthday)
    {
        return (ReferenceDate - birthday).Value.TotalDays / 365;
    }

    private static readonly DateTime ReferenceDate = new(2026, 6, 17);

    private static readonly List<Employee> Employees =
    [
        new("Clay", "Deaves", new DateTime(1971, 1, 28), [new("Goldenrod"), new("Aquamarine")]),
        new("Burty", "Lemerie", new DateTime(1002, 12, 23), [new("Blue"), new("Mauv")]),
        new("Linell", "Yakutin", new DateTime(1973, 2, 22), []),
        new("Emmalyn", "Urry", null, [new("Maroon")]),
        new("Evaleen", "Brayley", null, [new("Violet"), new("Maroon")]),
        new(
            "Doyle",
            "Boagey",
            new DateTime(1978, 9, 20),
            [new("Orange"), new("Goldenrod"), new("Crimson"), new("Blue"), new("Purple")]
        ),
        new(
            "Leonelle",
            "Arrandale",
            new DateTime(1994, 5, 3),
            [new("Crimson"), new("Indigo"), new("Teal"), new("Mauv"), new("Teal")]
        ),
        new(
            "Joey",
            "O'Hannen",
            new DateTime(1956, 11, 10),
            [new("Green"), new("Fuscia"), new("Mauv"), new("Teal")]
        ),
        new("Michal", "Bakes", new DateTime(1253, 10, 6), []),
        new(
            "Nikolia",
            "Burkhill",
            new DateTime(1973, 7, 8),
            [new("Aquamarine"), new("Red"), new("Maroon"), new("Green")]
        ),
        new(
            "Ulrica",
            "Cauderlie",
            new DateTime(1991, 5, 3),
            [new("Goldenrod"), new("Turquoise"), new("Violet")]
        ),
        new("Ingamar", "Boud", new DateTime(1994, 5, 11), []),
        new("Jodi", "Leafe", new DateTime(1997, 3, 11), []),
        new("Humfrey", "Thaxton", null, [new("Maroon")]),
        new("Queenie", "Jedrys", null, [new("Aquamarine"), new("Green"), new("Orange")]),
        new("Adda", "Olman", null, [new("Puce")]),
        new(
            "Crosby",
            "Itzchaki",
            new DateTime(1957, 5, 13),
            [new("Yellow"), new("Maroon"), new("Puce")]
        ),
        new("Felic", "Broomfield", new DateTime(1980, 4, 10), [new("Orange")]),
        new(
            "Gavrielle",
            "Yewdale",
            new DateTime(1987, 5, 21),
            [new("Blue"), new("Green"), new("Violet")]
        ),
        new(
            "Gelya",
            "Garth",
            new DateTime(1994, 5, 7),
            [new("Mauv"), new("Turquoise"), new("Green"), new("Goldenrod"), new("Orange")]
        ),
        new(
            "Ancell",
            "Coyne",
            new DateTime(1969, 7, 25),
            [new("Fuscia"), new("Red"), new("Goldenrod"), new("Maroon"), new("Fuscia")]
        ),
        new(
            "George",
            "Ferrieres",
            new DateTime(1991, 10, 30),
            [new("Turquoise"), new("Orange"), new("Green")]
        ),
        new(
            "Gena",
            "O'Finan",
            new DateTime(1993, 1, 15),
            [new("Green"), new("Goldenrod"), new("Maroon"), new("Indigo"), new("Puce")]
        ),
        new("Pietra", "Woodstock", new DateTime(1962, 2, 5), []),
        new("Taber", "Savile", new DateTime(1993, 5, 24), [new("Goldenrod")]),
        new("Astrid", "Hellyar", new DateTime(1969, 6, 6), [new("Mauv"), new("Maroon")]),
        new(
            "Martie",
            "Pannaman",
            new DateTime(1983, 12, 24),
            [new("Maroon"), new("Indigo"), new("Puce")]
        ),
        new("Burg", "Chatin", new DateTime(2002, 9, 3), [new("Fuscia"), new("Green")]),
        new(
            "Zack",
            "Duddin",
            new DateTime(1951, 9, 2),
            [new("Yellow"), new("Aquamarine"), new("Fuscia"), new("Puce"), new("Crimson")]
        ),
        new("Henry", "Ilchuk", null, [new("Mauv"), new("Green")]),
        new(
            "Krystle",
            "Alldridge",
            new DateTime(1973, 9, 2),
            [new("Purple"), new("Blue"), new("Pink"), new("Turquoise")]
        ),
        new("Alonzo", "Lefwich", null, [new("Khaki")]),
        new("Aliza", "Vela", new DateTime(1999, 9, 26), []),
        new(
            "Tricia",
            "Benninger",
            new DateTime(1958, 2, 12),
            [new("Red"), new("Purple"), new("Violet"), new("Teal")]
        ),
        new(
            "Kaitlin",
            "Pepineaux",
            null,
            [new("Teal"), new("Crimson"), new("Violet"), new("Fuscia"), new("Blue")]
        ),
        new("Georg", "Advani", new DateTime(1977, 3, 28), [new("Turquoise")]),
        new(
            "Hedwig",
            "Gilman",
            new DateTime(1976, 4, 22),
            [new("Violet"), new("Aquamarine"), new("Yellow")]
        ),
        new("Lynette", "Vallantine", new DateTime(1952, 12, 22), [new("Turquoise")]),
        new(
            "Lillis",
            "Farris",
            new DateTime(1957, 1, 22),
            [new("Crimson"), new("Purple"), new("Khaki"), new("Khaki"), new("Orange")]
        ),
        new(
            "Betteann",
            "Trett",
            new DateTime(1953, 8, 28),
            [new("Indigo"), new("Indigo"), new("Green"), new("Red"), new("Red")]
        ),
        new(
            "Cathleen",
            "Gavin",
            new DateTime(1955, 6, 21),
            [new("Turquoise"), new("Yellow"), new("Crimson"), new("Turquoise")]
        ),
        new(
            "Alfi",
            "Farens",
            new DateTime(1965, 10, 12),
            [new("Puce"), new("Teal"), new("Red"), new("Indigo"), new("Purple")]
        ),
        new(
            "Sunshine",
            "Dinwoodie",
            new DateTime(1995, 7, 7),
            [new("Blue"), new("Teal"), new("Red"), new("Khaki"), new("Puce")]
        ),
        new(
            "Parrnell",
            "Fermoy",
            new DateTime(1959, 1, 2),
            [new("Puce"), new("Aquamarine"), new("Teal"), new("Orange")]
        ),
        new(
            "Ninnette",
            "Lofthouse",
            new DateTime(1953, 9, 30),
            [new("Indigo"), new("Turquoise"), new("Red")]
        ),
        new("Radcliffe", "Pragnell", new DateTime(1984, 8, 4), [new("Puce"), new("Red")]),
        new("Orin", "Minet", new DateTime(1991, 5, 20), [new("Teal"), new("Puce"), new("Pink")]),
        new("Marijn", "Housden", new DateTime(1954, 2, 4), []),
        new("Nickie", "Serraillier", new DateTime(1963, 3, 30), [new("Puce")]),
        new("Lara", "Parkins", new DateTime(1969, 7, 13), [new("Red")]),
    ];

    private record Employee(
        string FirstName,
        string LastName,
        DateTime? Birthday,
        List<Color> FavoriteColors
    )
    {
        public string Rep =>
            $"{FirstName}, {LastName},  {GetAge(Birthday.Value)} years, {Birthday}";
    }

    private record Color(string Value);
}
