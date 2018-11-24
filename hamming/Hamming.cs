using System;
using System.Linq;

public static class Hamming {
    public static int Distance (string firstStrand, string secondStrand) {
        if (firstStrand.Length != secondStrand.Length) {
            throw new ArgumentException ("Cannot compute distance between strands of differing lengths");
        }

        return firstStrand
            .Zip (secondStrand, (first, second) => new { first, second })
            .Count ((tuple) => tuple.first != tuple.second);
    }
}
