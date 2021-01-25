using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence) =>
        !sequence.All("ACGT".Contains)
            ? throw new ArgumentException()
            : (sequence + "ACGT").GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count() - 1);
}