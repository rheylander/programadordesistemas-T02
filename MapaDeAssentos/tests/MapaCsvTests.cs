using System;
using MatrizesWinFormsAssentos;

internal static class MapaCsvTests
{
    private static int total;
    private static void Check(bool condition, string name)
    {
        total++;
        if (!condition) throw new Exception(name);
    }

    private static void Invalid(string[] text, string name)
    {
        int[,] result;
        string error;
        bool ok = MapaCsv.TryParse(text, out result, out error);
        Check(!ok && result == null && !string.IsNullOrEmpty(error), name);
    }

    public static void Main()
    {
        int[,] result;
        string error;
        Check(MapaCsv.TryParse(new[] { "2;2", "0;1", "2;0" }, out result, out error)
            && result[0,1] == 1 && result[1,0] == 2 && error == null, "valid 2x2");
        string[] maximum = new string[31];
        maximum[0] = "30;30";
        for (int i = 1; i <= 30; i++) maximum[i] = new string('0', 30).Replace("0", "0;").TrimEnd(';');
        Check(MapaCsv.TryParse(maximum, out result, out error)
            && result.GetLength(0) == 30 && result.GetLength(1) == 30, "valid 30x30");
        Invalid(null, "null");
        Invalid(new string[0], "empty");
        Invalid(new[] { "1;2", "0;0" }, "below minimum");
        Invalid(new[] { "31;2" }, "too many rows");
        Invalid(new[] { "2;31" }, "too many columns");
        Invalid(new[] { "2147483647;2147483647" }, "huge dimensions");
        Invalid(new[] { "2147483648;2" }, "overflow");
        Invalid(new[] { "x;2" }, "invalid header");
        Invalid(new[] { "2;2;3", "0;0", "0;0" }, "extra header value");
        Invalid(new[] { "2;2", "0;0" }, "missing row");
        Invalid(new[] { "2;2", "0;0", "0;0", "0;0" }, "extra row");
        Invalid(new[] { "2;2", "0;0", "0" }, "late missing column");
        Invalid(new[] { "2;2", "0;0", "0;0;0" }, "extra column");
        Invalid(new[] { "2;2", "0;1", "2;3" }, "late invalid state");
        Invalid(new[] { "2;2", "0;1", "2;-1" }, "negative state");
        Invalid(new[] { "2;2", "0;1", "2;x" }, "text state");
        Invalid(new[] { "2;2", "0;1", null }, "null row");
        Console.WriteLine("PASS: " + total + " CSV regression tests");
    }
}

